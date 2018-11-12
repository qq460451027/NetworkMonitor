using SnmpSharpNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitor
{
    public partial class frmCheckSNMPDetails : Form
    {
        public string id { get; set; }
        public frmCheckSNMPDetails()
        {
            InitializeComponent();
        }

        public static string getchsfromhex(string hexstr)
        {
            if (hexstr == null)
                throw new ArgumentNullException("hex");
            if (hexstr.Length % 2 != 0)
            {
                hexstr += "20";//空格
            }
            // 需要将 hex 转换成 byte 数组。
            byte[] bytes = new byte[hexstr.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                try
                {
                    // 每两个字符是一个 byte。
                    bytes[i] = byte.Parse(hexstr.Substring(i * 2, 2),
                    System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    throw new ArgumentException("不合法十六进制字符");
                }
            }

            // 获得 GB2312
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("gb2312");
            return chs.GetString(bytes);
        }
        private void snmpwalk()
        {
            try
            {
                string hexstr = @"[0-9a-fA-F]{2}\s[0-9a-fA-F]{2}\s[0-9a-fA-F]{2}\s";
                //匹配连续三组十六进制字符的正则式
                Regex regex = new Regex(hexstr);
                OctetString community = new OctetString("public");
                AgentParameters param = new AgentParameters(community);
                param.Version = SnmpVersion.Ver1;
                IpAddress agent = new IpAddress(Common.getipbyid(id));
                UdpTarget target = new UdpTarget((IPAddress)agent, 161, 2000, 1);

                List<string> miblist = Common.getmonitoritems(id);
                //Dictionary<string, string> output_cache = new Dictionary<string, string>();
                Pdu pdu = new Pdu(PduType.GetNext);
                for (int i = 0; i < miblist.Count; i++)
                {
                    Oid rootOid = new Oid(miblist[i]);
                    Oid lastOid = (Oid)rootOid.Clone();
                    while (lastOid != null)
                    {
                         string resultstring = null;
                            if (pdu.RequestId != 0)
                            {
                                pdu.RequestId += 1;
                            }
                            pdu.VbList.Clear();
                            pdu.VbList.Add(lastOid);
                            SnmpV1Packet result = (SnmpV1Packet)target.Request(pdu, param);
                            if (result != null)
                            {
                                if (result.Pdu.ErrorStatus != 0)
                                {
                                    Common.writetologfrm(string.Format("SNMP Walk(GET-Next错误),错误号:{0} 错误位置:{1}", result.Pdu.ErrorStatus, result.Pdu.ErrorIndex));
                                    lastOid = null;
                                    break;
                                }
                                else
                                {
                                    foreach (Vb vb in result.Pdu.VbList)
                                    {   //检查子节点
                                        if (rootOid.IsRootOf(vb.Oid))
                                        {
                                        //如果字符是三组16进制开头的，则转码成中文
                                            string sourcevalue = vb.Value.ToString();
                                            MatchCollection matchlist = regex.Matches(sourcevalue);
                                            if (matchlist.Count > 0)
                                            {
                                                sourcevalue = sourcevalue.Replace(" ", "");
                                                resultstring += getchsfromhex(sourcevalue);
                                            }
                                            else
                                            {
                                                resultstring += vb.Value.ToString();
                                            }
                                            resultstring += "\r\n---------------------------------\r\n";
                                            lastOid = vb.Oid;
                                        //键与值加入dictionary
                                            dict.Add(vb.Oid.ToString(), resultstring);
                                        }
                                        else
                                        {//到尾后清空oid
                                            lastOid = null;
                                        }
                                    } }}
                            else
                            {
                                Common.writetologfrm("SNMP Walk(GET-Next）未能收到回复");
                            }
                }
                    //获取中文名，与oid合并后加入listbox
                    string tmpstr = "sys_mib='" + rootOid + "'";
                    DataRow[] dr = Common.dt_snmp_allitems.Select(tmpstr);
                    string chsname = dr[0]["sys_service"].ToString();
                    list_items.Items.Add(chsname + "@" + rootOid.ToString());
                }
            }
            catch (Exception e) {
                MessageBox.Show(string.Format("获取SNMP消息遇到错误!\r\n{0}", e.Message),"错误", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void loaddetails(int listboxindex,Dictionary<string,string>dict) {
            txt_details.Text = "";
            //dictionary<string(sys_service@sys_mib),string(snmpdata)>
            string selecteditemoid= list_items.Items[listboxindex].ToString().Split('@')[1];
            foreach (KeyValuePair<string, string> i in dict)
            {
                if (i.Key.StartsWith(selecteditemoid))
                {
                    txt_details.Text += dict[i.Key];
                }
            }
        }
        Dictionary<string, string> dict;
        private void frmCheckSNMPDetails_Load(object sender, EventArgs e)
        {
            dict = new Dictionary<string, string>();
            snmpwalk();
        }

        private void list_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddetails(list_items.SelectedIndex,dict);
        }
    }
}

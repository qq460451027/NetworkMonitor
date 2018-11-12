using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQLHelper;
namespace monitor
{
    public partial class frmError : Form
    {
        public frmError()
        {
            InitializeComponent();
        }
        private void frmError_Load(object sender, EventArgs e)
        {
            frmhandle = this;
        }

        private void loglist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static frmError frmhandle;
        public static string write {
            set {
                frmhandle.Invoke(new MethodInvoker(
                    () => { frmhandle.loglist.Items.Add(value); }));
            }
        }

        private void btn_dropall_Click(object sender, EventArgs e)
        {
            loglist.Items.Clear();
        }
        // i[0] SNMP/ICMP
        // i[1] ID
        // i[2] details
        // i[3] timestamp
        private string log_getid(string str) {
            string []i=str.Split(' ');
            return i[1].Split(':')[1];
        }
        private string log_getdetails(string str) {
            string[] i = str.Split(' ');
            return i[2];
        }
        private string log_gettimestamp(string str)
        {
            string[] i = str.Split(' ');
            return i[3];
        }
        private void btn_savetodatabase_Click(object sender, EventArgs e)
        {
            //sql待执行语句集
            List<string> temp = new List<string>();
            List<string> sqlstr = new List<string>();
            foreach (string i in loglist.Items) {
                temp.Add(i);
            }
            loglist.Items.Clear();//保存副本并清空原始数据
            try
            {
                for (int j = 0; j < temp.Count; j++)
                {
                    string i = temp[j];
                    if (temp[j].ToString().StartsWith("SNMP异常"))
                    {
                        string tmp = temp[j].ToString();
                        Common.writetofile(tmp, "writetodatabase.txt");
                        string t = string.Format("insert into log_snmp (dev_id,details,timestamp)values('{0}','{1}','{2}');", log_getid(tmp), log_getdetails(tmp), log_gettimestamp(tmp));
                        sqlstr.Add(t);
                    }
                    else if (temp[j].ToString().StartsWith("ICMP异常"))
                    {
                        string tmp = temp[j].ToString();
                        Common.writetofile(tmp, "writetodatabase.txt");
                        string t = string.Format("insert into log_icmp (dev_id,details,timestamp)values('{0}','{1}','{2}');", log_getid(tmp), log_getdetails(tmp), log_gettimestamp(tmp));
                        sqlstr.Add(t);
                    }
                }
            }
            catch { }
            foreach (string t in sqlstr) {
                int status=MySqlHelper.ExecuteSql(t);
                if (status == 0) Common.writetologfrm(string.Format("执行失败!\r\n内容为:{0}", t));
            }
            Common.writetologfrm("日志转储成功！");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loglist_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}

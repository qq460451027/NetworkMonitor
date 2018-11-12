using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using SnmpSharpNet;
using System.Net.Sockets;

namespace monitor
{
    public partial class frmServerMonitor : Form
    {
        public frmServerMonitor()
        {
            InitializeComponent();
        } 
        private void frmServerMonitor_Load(object sender, EventArgs e)
        {
           
            dataGridView_server.DataSource = Common.dt_snmp;
            Thread.Sleep(500);
            Common.writetologfrm("SNMP 开始监控...");
            StartSNMPThreads();
            
        }
        public void destorythread() {
            //终止线程
            canceltokensource.Cancel();
        }
        private void StartSNMPThreads() {
            try
            {
                int MaxSNMPDev = Common.dt_snmp.Rows.Count;//线程数

                for (int i = 0; i < MaxSNMPDev; i++)
                {
                    string id = dataGridView_server.Rows[i].Cells["Id"].Value.ToString();
                    CreateSNMPThreads(id);//遍历表格，创建线程
                }
            }
            catch (Exception e) {
                MessageBox.Show(string.Format("遇到错误，请重试!{0}",e.Message),"错误"
                    ,MessageBoxButtons.OK);
            }
        }

        CancellationTokenSource canceltokensource = new CancellationTokenSource();
        //struct inputmodel {
        //    public CancellationTokenSource canceltoken;
        //    public object id;
        //};//传入参数只能有1个，所以用结构体传入CancellationToken与ID
        private void CreateSNMPThreads(object id) {
            //inputmodel inputmod = new inputmodel();
            //inputmod.canceltoken = canceltokensource;
            //inputmod.id = id;//填充结构体后传入线程池
            ThreadPool.QueueUserWorkItem(GetSNMPResponse,id);
        }
        private void show_success(string id) {
            for (int i = 0; i < dataGridView_server.Rows.Count; i++) {
                if (dataGridView_server.Rows[i].Cells["Id"].Value.ToString() == id)
                {
                    dataGridView_server.Rows[i].Cells["dev_snmp_status"].Style.BackColor = Color.LightSeaGreen;
                    break;
                }
            }
        }//将对应id的条目的状态栏设置为绿色
        private void show_failed(string id) {
            for (int i = 0; i < dataGridView_server.Rows.Count; i++)
            {
                if (dataGridView_server.Rows[i].Cells["Id"].Value.ToString() == id)
                {
                    dataGridView_server.Rows[i].Cells["dev_snmp_status"].Style.BackColor = Color.OrangeRed;
                    break;
                }
            }
        }//将对应id的条目的状态栏设置为橘红色
        private  void GetSNMPResponse(object input_id)
        {           
            //inputmodel temp =new inputmodel();
            //temp = (inputmodel)mod;
            //CancellationTokenSource token = temp.canceltoken; 
            string id = (string)input_id;
            string ipaddr = null;
            for (int i = 0; i < Common.dt_snmp.Rows.Count; i++)
            {
                string tmp = Common.dt_snmp.Rows[i]["Id"].ToString();
                if (tmp == (string)id)
                {
                    ipaddr = Common.dt_snmp.Rows[i]["dev_ip"].ToString();
                }
            }
                int feq = Common.getfequency((string)id);
                //填充snmp包头信息
                OctetString community = new OctetString("public");
                //社区
                AgentParameters param = new AgentParameters(community);
                //版本
                param.Version = SnmpVersion.Ver1;
                //ip地址代理
                IpAddress agent = new IpAddress(ipaddr);
                //定义udp包
                UdpTarget target = new UdpTarget((IPAddress)agent, 161, 2000, 1);
                Pdu pdu = new Pdu(PduType.Get);
                //填充pdu列表
                pdu.VbList.Add(".1.3.6.1.2.1.1.3.0");//设备名的OID号
                for (; ; )
                {
                if (canceltokensource.IsCancellationRequested == true) {
                    Common.writetologfrm(string.Format("SNMP 设备ID:{1} 线程{0}终止",Thread.CurrentThread.ManagedThreadId,id.ToString()));
                    target.Dispose();
                    this.Close(); 
                    break;//若收到cancellationToken消息则取消此线程
                }
                    Dictionary<string, string> output_cache = new Dictionary<string, string>();
                    try
                    {
                    //创建snmp请求
                    SnmpV1Packet result = (SnmpV1Packet)target.Request(pdu, param);
                        if (result != null)
                        {
                            //errorstatus不等于0则错误
                            if (result.Pdu.ErrorStatus != 0)
                            {
                                this.Invoke(new MethodInvoker(() => show_failed((string)id)));
                            }
                            else
                            {//正确则返回pdu数据
                                for (int x = 0; x < result.Pdu.VbList.Count; x++)
                                {
                                    this.Invoke(new MethodInvoker(() => show_success((string)id)));
                                    output_cache.Add(result.Pdu.VbList[x].Oid.ToString(), result.Pdu.VbList[x].Value.ToString());
                                }
                            } }
                        else
                        {
                            this.Invoke(new MethodInvoker(() => show_failed((string)id)));
                        }}
                    catch (Exception e)
                    {
                        this.Invoke(new MethodInvoker(() => Common.writetologfrm(string.Format("SNMP异常 ID:{0} 描述:{1} ", id.ToString(), e.Message))));
                        this.Invoke(new MethodInvoker(() => show_failed((string)id)));
                        continue;
                    }
                    finally
                    {
                        Thread.Sleep(Common.getfequency((string)id));
                    }}
            //target.Dispose();
        }//SNMP线程工作内容
        private void 发送唤醒包ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_server.SelectedRows != null)
            {
                int i = dataGridView_server.CurrentRow.Index;
                string mac = dataGridView_server.Rows[i].Cells["Id"].Value.ToString();
                frmSendStartupPacket frmsendpack = new frmSendStartupPacket();
                frmsendpack.id = mac;
                frmsendpack.Show();
            }
            else {
                MessageBox.Show("没有选择设备！请重试", "唤醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmServerMonitor_SizeChanged(object sender, EventArgs e)
        {
            dataGridView_server.Dock = DockStyle.Fill;
        }
        protected override void WndProc(ref Message msg)
        {
            const int CMD = 0x0112;
            const int CLOSE = 0xF060;
            if (msg.Msg == CMD && (int)msg.WParam == CLOSE)
            {
                this.Hide();
            }
            base.WndProc(ref msg);
        }//重写窗体关闭事件

        private void dataGridView_server_DoubleClick(object sender, EventArgs e)
        {
            frmCheckSNMPDetails frmchksnmp = new frmCheckSNMPDetails();
            frmchksnmp.id = dataGridView_server.Rows[dataGridView_server.CurrentRow.Index].Cells["Id"].Value.ToString();
            frmchksnmp.Show();
        }

        private void dataGridView_server_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void button1_Click(object sender,EventArgs e) {
            
        }

        private void dataGridView_server_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

//              frmCheckSNMPDetails frmchksnmp = new frmCheckSNMPDetails();
//              frmchksnmp.id = (int) dataGridView_server.Rows[dataGridView_server.CurrentRow.Index].Cells["Id"].Value;
//              frmchksnmp.Show();
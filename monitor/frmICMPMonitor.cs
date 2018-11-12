using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitor
{
    public partial class frmICMPMonitor : Form
    {
        public frmICMPMonitor()
        {
            InitializeComponent();
        }
        public void StartICMPThreads()
        {
            try
            {
                int MaxICMPDev = Common.dt_icmp.Rows.Count;//线程数

                for (int i = 0; i < MaxICMPDev; i++)
                {
                    string id = dataGridView_device.Rows[i].Cells["Id"].Value.ToString();
                    CreateICMPThreads(id);//遍历表格，创建线程
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("遇到错误，请重试!{0}", e.Message), "错误"
                    , MessageBoxButtons.OK);
            }
        }
        string status;
        CancellationTokenSource canceltokensource = new CancellationTokenSource();
        //struct inputmodel
        //{
        //    public CancellationTokenSource canceltoken;
        //    public object id;
        //};
        public void CreateICMPThreads(object id)
        {
            //inputmodel inputmod = new inputmodel();
            //inputmod.canceltoken = canceltokensource;
            //inputmod.id = id;
            ThreadPool.QueueUserWorkItem(GetICMPResponse,id);
        }
        public string getid(int rownum)
        {
            string i=null;
            dataGridView_device.Invoke(new MethodInvoker(() =>
            {
                i = (string)dataGridView_device.Rows[(int)rownum].Cells["Id"].Value;
            }));
            return i;
        }//根据datatable的行号获取id，0-（n-1）
        public void destorythread() {
            canceltokensource.Cancel();
        }
        
        private int getrownum(string id) {
            int num=-1;
            this.Invoke(new MethodInvoker(() => {
                for (int i = 0; i < dataGridView_device.Rows.Count; i++)
                {
                    if (dataGridView_device.Rows[i].Cells["Id"].Value.ToString() == id)
                        num = i;
                }
            }));
            return num;
        }
        public void GetICMPResponse(object input_id)
        {
            //inputmodel input = new inputmodel();
            //input = (inputmodel)mod;
            //CancellationTokenSource tmptoken = input.canceltoken;
            string id = input_id.ToString();


            for (; ; )
            {
                if (canceltokensource.IsCancellationRequested==true) {
                    Common.writetologfrm(string.Format("ICMP 设备ID:{1} 线程{0}终止", Thread.CurrentThread.ManagedThreadId,id.ToString()));
                    this.Close();
                    break;
                }
                bool i = false ;                       
                int rownum=getrownum((string)id);
                i = Common.checkonline((string)id);
                if (i == true)
                    //多个线程同时操作非创建线程的时候需要使用invoke，否则会报错
                    dataGridView_device.Invoke(new MethodInvoker(() =>
                    {
                        dataGridView_device.Rows[rownum].Cells["dev_icmp_status"].Style.BackColor = Color.LightSeaGreen;
                    }));
                else
                {
                    bool retry=Common.checkonline((string)id);

                    if (retry == false)
                    {
                        dataGridView_device.Invoke(new MethodInvoker(() =>
                        {
                            dataGridView_device.Rows[rownum].Cells["dev_icmp_status"].Style.BackColor = Color.OrangeRed;
                            Common.writetologfrm("ICMP异常 ID:" + id.ToString() + " 设备检测到离线");
                        }));
                    }
                    else {
                        dataGridView_device.Invoke(new MethodInvoker(() =>
                        {
                            dataGridView_device.Rows[rownum].Cells["dev_icmp_status"].Style.BackColor = Color.LightSeaGreen;
                        }));

                    }

                }
                Thread.Sleep(Common.getfequency((string)id));
            }

        }//ICMP线程工作内容
        private void frmICMPMonitor_Load(object sender, EventArgs e)
        {
            dataGridView_device.DataSource = Common.dt_icmp;
            //Thread.Sleep(500);  //
            StartICMPThreads();
            Common.writetologfrm( "ICMP 开始监控..."); 
        }
        private void frmICMPMonitor_SizeChanged(object sender, EventArgs e)
        {
            dataGridView_device.Dock = DockStyle.Fill;
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

        private void dataGridView_device_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnmpSharpNet;
using MySQLHelper;
using System.Threading;
using System.Diagnostics;
namespace monitor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string connstring;
        public string connstring_tmp { get ; set; }
        public static string size { get; set; }
        //句柄

        frmError frmerror;
        frmMaintable frmmain;
        frmSNMPSettings snmpchange;
        frmServerMonitor frmsnmpmonitor;
        frmICMPMonitor frmicmpmonitor;
        frmPrinterMonitor frmprintmonitor;
        private void 高级协议ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sNMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            snmpchange = new frmSNMPSettings();
            snmpchange.Show();
        }
        private void 连接到存储数据库ToolStripMenuItem_Click(object sender, EventArgs e)

        {
            连接到存储数据库ToolStripMenuItem.Enabled = false;
            frmConnect frmconnect = new frmConnect();
            frmconnect.ShowDialog();
            //开始连接数据库
            try {
                Common.flushalldataset();
            }
            catch (Exception x){
                MessageBox.Show("链接数据库发生异常，请检查连接或账号密码！\r\n"+x.Message, "连接错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            loadallthreads();
            startmonitor();
            开始监控ToolStripMenuItem.Enabled = false;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void 增加监控点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNode addnode = new frmAddNode();
            addnode.ShowDialog();
            restartallthreads();

        }

        private void 删除监控点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteNode delnode = new frmDeleteNode();
            delnode.ShowDialog();
            restartallthreads();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        public void stopmonitor()
        {
            连接到存储数据库ToolStripMenuItem.Enabled = true;
            toolStripMenuItem3.Enabled = false;//断开
            增加监控点ToolStripMenuItem.Enabled = false;
            删除监控点ToolStripMenuItem.Enabled = false;
            sNMPToolStripMenuItem.Enabled = false;
            MySqlHelper.connstr = "";
        }//停止监控的具体操作
        public void startmonitor()
        {
            toolStripMenuItem3.Enabled = true;//断开
            连接到存储数据库ToolStripMenuItem.Enabled = false;
            增加监控点ToolStripMenuItem.Enabled = true;
            删除监控点ToolStripMenuItem.Enabled = true;
            sNMPToolStripMenuItem.Enabled = true;
        }//开始监控具体操作
        
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            stopmonitor();
            destoryallthreads();
            MessageBox.Show("已断开数据库连接。已停止监控。", "网络设备监控", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//停止监控

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            stopmonitor();
            frmerror = new frmError();
            frmerror.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(frmerror);
            frmerror.Show();
            连接到存储数据库ToolStripMenuItem.PerformClick();
        }//主窗口加载

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MySqlHelper.connstr, "xx", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmsnmpmonitor.Show();
        }//打开服务器监控窗口

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmicmpmonitor.Show();
        }//打开设备监控窗口

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmmain = new frmMaintable();
            frmmain.Show();
        }//打开主表窗口



        private void 如何开启WindowsSNMP服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"help.chm");
        }//打开snmp教程

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {          
            frmerror.Show();
        }//打开日志窗口
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 复制本条数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frmsetting = new frmSettings();
            frmsetting.ShowDialog();
        }

        private void 停止监控ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            destoryallthreads();
            开始监控ToolStripMenuItem.Enabled = true;
            停止监控ToolStripMenuItem.Enabled = false;
        }
        private void destoryallthreads() {
            frmsnmpmonitor.destorythread();
            frmsnmpmonitor.Close();
            frmicmpmonitor.destorythread();
            frmicmpmonitor.Close();
            frmprintmonitor.destorythread();
            frmprintmonitor.Close();
            splitContainer2.Panel1.Controls.Clear();
            splitContainer3.Panel1.Controls.Clear();
            splitContainer3.Panel2.Controls.Clear();
            //splitContainer1.Panel2.Controls.Clear();
        }
        private void loadallthreads() {
            
            
            
            Common.flushalldataset();
            Common.writetologfrm("缓存表刷新完成...");

            frmicmpmonitor = new frmICMPMonitor();
            frmicmpmonitor.TopLevel = false;
            splitContainer2.Panel1.Controls.Add(frmicmpmonitor);
            frmicmpmonitor.Show();


            frmsnmpmonitor = new frmServerMonitor();
            frmsnmpmonitor.TopLevel = false;
            splitContainer3.Panel1.Controls.Add(frmsnmpmonitor);
            frmsnmpmonitor.Show();


            frmprintmonitor = new frmPrinterMonitor();
            frmprintmonitor.TopLevel = false;
            splitContainer3.Panel2.Controls.Add(frmprintmonitor);
            frmprintmonitor.Show();
            resize();
            Common.writetologfrm("加载完成...");
        }
        private void restartallthreads() {

            destoryallthreads();
            loadallthreads();
            
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmprintmonitor.Show();
        }

        private void 尝试远程开机ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void resize() {
            frmerror.Dock = DockStyle.Fill;
            frmicmpmonitor.Dock = DockStyle.Fill;
            frmsnmpmonitor.Dock = DockStyle.Fill;
            frmprintmonitor.Dock = DockStyle.Fill;
        }
      

        private void splitContainer2_SplitterMoving(object sender, SplitterCancelEventArgs e)
        {
            resize();
            frmprintmonitor.PerformAutoScale();
            frmerror.PerformAutoScale();
            frmicmpmonitor.PerformAutoScale();
            frmsnmpmonitor.PerformAutoScale();
        }

        private void splitContainer3_SplitterMoving(object sender, SplitterCancelEventArgs e)
        {
           
        }

        private void control2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void 开始监控ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadallthreads();
            停止监控ToolStripMenuItem.Enabled =true;
            开始监控ToolStripMenuItem.Enabled = false;
        }
    }
}

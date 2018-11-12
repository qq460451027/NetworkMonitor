using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitor
{
    public partial class frmSendStartupPacket : Form
    {
        public frmSendStartupPacket()
        {
            InitializeComponent();
        }
        public string id { get; set; }
        private void frmSendStartupPacket_Load(object sender, EventArgs e)
        {

                this.Width = 454;
                if (id == null) { MessageBox.Show("没有检测到所选的设备！请手动输入...", "设备唤醒", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                txt_mac.Text = Encoding.Default.GetString(Common.getmac(id)).ToUpper();

        }  
        public int WakeUp(byte[] mac)
        {
            UdpClient client = new UdpClient();
            if (txt_gateway.Text == null)
            {
                client.Connect(IPAddress.Broadcast, 30000);//连接到同一子网广播地址
            }
            else {
                MessageBox.Show(string.Format("内容为:{0}+", txt_gateway.Text), "title");
                string[] tmp = txt_gateway.Text.Split('.');
                int[] addr_tmp=null;
                for (int i = 0; i < 4; i++)
                    addr_tmp[i] = Convert.ToUInt16(tmp[i]);
                IPAddress ip = new IPAddress(new byte[] {});
                client.Connect(ip, 30000);//连接到另一子网广播地址
            }  
            //唤醒包格式为FF*6+mac*16
            byte[] packet = new byte[17 * 6];
            for (int i = 0; i < 6; i++)
                packet[i] = 0xFF;
            for (int i = 1; i <= 16; i++)
                for (int j = 0; j < 6; j++)
                    packet[i * 6 + j] = mac[j];
            int result = client.Send(packet, packet.Length);
            list_log.Items.Add("已发送唤醒包，返回"+result.ToString());
            return result;
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            WakeUp(Common.getmac(id));
            list_log.Items.Add("已发送唤醒包...请等待");
            timer1.Enabled = true;
            list_log.Items.Add("正在检测设备在线状态...");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool status=Common.checkonline(id);
            if (status == true) { list_log.Items.Add("设备已检测到在线..."); }
            else { list_log.Items.Add("设备尚未在线..."); }
        }

        private void chk_needcalc_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_needcalc.Checked == true) { this.Width = 870;}
            else { this.Width = 454;}
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            byte[] ipaddr = IPAddress.Parse(txt_calc_ip.Text).GetAddressBytes();
            byte[] netmask = IPAddress.Parse(txt_calc_netmask.Text).GetAddressBytes();;
            for (int i = 0; i < ipaddr.Length; i++) {
                ipaddr[i] = (byte)((~netmask[i]) | ipaddr[i]);
            }
            txt_gateway.Text = string.Format("{0}.{1}.{2}.{3}",ipaddr[0].ToString(),ipaddr[1].ToString(),ipaddr[2].ToString(),ipaddr[3].ToString());

        }
    }
}

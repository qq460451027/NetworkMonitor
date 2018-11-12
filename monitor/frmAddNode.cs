using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQLHelper;
namespace monitor
{
    public partial class frmAddNode : Form
    {
        public frmAddNode()
        {
            InitializeComponent();
        }

        int rowcount,rowcount1;
        DataTable maintable;
        DataTable servertype;
        DataTable monitormode;
        private void frmAddNode_Load(object sender, EventArgs e)
        {
            //生成编号
            string date;
            date = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString()
                + DateTime.Now.Day.ToString()
                + DateTime.Now.Hour.ToString()+DateTime.Now.Minute.ToString();
            date.Replace(" ","");
            txt_id.Text = date;
            //获取设备类型并填充到设备类型的ComboBox
            servertype =MySqlHelper.GetDataSet("select * from settings_servertype;").Tables[0];
            rowcount =servertype.Rows.Count;
            for (int j = 0; j < rowcount; j++)
            {
                cmb_type.Items.Add(servertype.Rows[j]["Id"].ToString()+"."+
                    servertype.Rows[j]["server_types"].ToString());
            }
            cmb_type.SelectedIndex = 0;
            //
            monitormode = MySqlHelper.GetDataSet("select * from settings_monitorway;").Tables[0];
            rowcount1 = monitormode.Rows.Count;
            for (int j = 0; j < rowcount1; j++)
            {
                cmb_mode.Items.Add(monitormode.Rows[j]["Id"].ToString() + "." +
                    monitormode.Rows[j]["sys_mode"].ToString());
            }
            cmb_mode.SelectedIndex = 0;

        }

        private void btn_addnode_Click(object sender, EventArgs e)
            {
            //check
            ;
            txt_mac.Text = txt_mac.Text.ToUpper();
            if (string.IsNullOrWhiteSpace(txt_ip.Text) == true || string.IsNullOrWhiteSpace(txt_mac.Text) == true || string.IsNullOrWhiteSpace(txt_name.Text) == true ||
                string.IsNullOrWhiteSpace(txt_extinfo.Text) == true || string.IsNullOrWhiteSpace(txt_feq.Text) == true)
            {
                MessageBox.Show("信息不完整，请检查！", "信息不完整",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string name = cmb_type.SelectedItem.ToString().Split('.')[1].ToString();
                if (cmb_mode.SelectedItem == "Printer") name = "NULL";
                    string mode = cmb_mode.SelectedItem.ToString().Split('.')[1].ToString();
                    string valuestr = string.Format("'{0}','{1}','{2}','{3}','{4}'" +
                        ",'{5}',{6},{7}", txt_id.Text, txt_name.Text, name,mode,txt_ip.
                        Text, txt_mac.Text, txt_extinfo.Text, txt_feq.Text);
                    string command = "insert into main_table(id,dev_name,dev_type," +
                    "dev_monitor_mode,dev_ip,dev_mac,dev_extinfo,dev_feq)values(" + valuestr + ");";
                    if (MySqlHelper.ExecuteSql(command) == 0)
                    {
                        MessageBox.Show("添加过程出错，请重试...", "添加监控点",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("添加成功", "添加监控点",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                
                
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
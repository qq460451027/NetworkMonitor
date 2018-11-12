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
using MySql.Data.Common;
using MySql.Data.Types;
namespace monitor
{
    public partial class frmDeleteNode : Form
    {
        public frmDeleteNode()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int rowcount;
        DataTable maintable;
        
        private void cmb_devicename_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = "dev_name = \'" + cmb_devicename.Text + "\'";
            DataRow[] row = maintable.Select(i);
            txt_ip.Text = row[0]["dev_ip"].ToString();
            txt_type.Text = row[0]["dev_type"].ToString();
            txt_mac.Text = row[0]["dev_mac"].ToString();
            txt_others.Text = row[0]["dev_extinfo"].ToString();
            txt_id.Text = row[0]["Id"].ToString();
            //tb.Rows[j]["dev_name"].ToString();


        }

        private void frmDeleteNode_Load(object sender, EventArgs e)
        {
            DataSet db = MySqlHelper.GetDataSet("select * from main_table;");
            rowcount = db.Tables[0].Rows.Count;
            DataTable tb = db.Tables[0];
            maintable = tb;
            for (int j = 0; j < rowcount; j++) {
                cmb_devicename.Items.Add(tb.Rows[j]["dev_name"].ToString());
            }
            cmb_devicename.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlstr = string.Format("delete from main_table where Id='{0}'",txt_id.Text);
            int i = MySqlHelper.ExecuteSql(sqlstr);
            if (i == 1) { MessageBox.Show("删除成功", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else { MessageBox.Show("删除失败", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            
        }
    }
}

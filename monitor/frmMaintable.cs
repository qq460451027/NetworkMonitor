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
    public partial class frmMaintable : Form
    {
        public frmMaintable()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void flush_maintable() {
            string sql_getmaintable = "select Id,dev_name,dev_type,dev_monitor_mode,dev_ip,dev_mac,dev_extinfo,dev_feq from main_table;";
            DataSet db = MySqlHelper.GetDataSet(sql_getmaintable);
            dt = db.Tables[0];
            dataGridView1.DataSource = dt;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            flush_maintable();
        }

        private void frmMaintable_Load(object sender, EventArgs e)
        {
            flush_maintable();
        }
    }
}

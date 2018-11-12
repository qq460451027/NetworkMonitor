using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQLHelper;
namespace monitor
{
    public partial class frmSNMPSettings : Form
    {
        public frmSNMPSettings()
        {
            InitializeComponent();
        }
        private bool getboolvalue(int i) {
            if (i == 0) {
                return false;
            }
            else
            {
                return true;
            }
        }
        private int setboolvalue(Boolean i) {
            if (i == true)
            {
                return 1;
            }
            else if (i == false)
            {
                return 0;
            }
            else { return -1; }

        }
        private void frmSNMPSettings_Load(object sender, EventArgs e)
        {
            radio_all.PerformClick();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void fill_list_all() {//填充右侧所有项目表
            list_all.Items.Clear();
            int i = Common.dt_snmp_allitems.Rows.Count;
            for (int k = 0; k < i; k++) {
                list_all.Items.Add(Common.dt_snmp_allitems.Rows[k]["Id"].ToString()
                    + "," + Common.dt_snmp_allitems.Rows[k]["sys_service"].ToString());
            } 
        }
        private void fill_list_enabled(string type) {//填充左侧启用项目表
            list_enabled.Items.Clear();
            //type   
            //1.sys_windows_enabled    2.sys_linux_enabled   3.sys_common_enabled
            //4.sys_items_enabled
            DataRow [] dr = Common.dt_snmp_allitems.Select(type + "=1");
            for (int k = 0; k < dr.Count(); k++) {
                list_enabled.Items.Add(dr[k]["Id"].ToString()+","+
                    dr[k]["sys_service"].ToString());
            }
        }
        private void radio_all_CheckedChanged(object sender, EventArgs e)
        {
            fill_list_all();
            fill_list_enabled("sys_items_enabled");
        }

        private void radio_windows_CheckedChanged(object sender, EventArgs e)
        {
            fill_list_all();
            fill_list_enabled("sys_windows_enabled");
        }

        private void radio_unix_CheckedChanged(object sender, EventArgs e)
        {
            fill_list_all();
            fill_list_enabled("sys_linux_enabled");
        }

        private void radio_otherdevices_CheckedChanged(object sender, EventArgs e)
        {
            fill_list_all();
            fill_list_enabled("sys_common_enabled");
        }

        private void list_enabled_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (radio_windows.Checked == true) {
                string index=list_all.SelectedItem.ToString().Split(',')[0];
                string sqlstr = string.Format("update settings_miblib set " +
                    "sys_windows_enabled='1' where Id='{0}';", index);
                MySqlHelper.ExecuteSql(sqlstr);
                Common.flushmiblist();
                fill_list_enabled("sys_windows_enabled");
            }
            else if (radio_unix.Checked == true) {
                string index = list_all.SelectedItem.ToString().Split(',')[0];
                string sqlstr = string.Format("update settings_miblib set " +
                    "sys_linux_enabled='1' where Id='{0}';", index);
                MySqlHelper.ExecuteSql(sqlstr);
                Common.flushmiblist();
                fill_list_enabled("sys_linux_enabled");
            }
            else if (radio_otherdevices.Checked == true) {
                string index = list_all.SelectedItem.ToString().Split(',')[0];
                string sqlstr = string.Format("update settings_miblib set " +
                    "sys_common_enabled='1' where Id='{0}';", index);
                MySqlHelper.ExecuteSql(sqlstr);
                Common.flushmiblist();
                fill_list_enabled("sys_common_enabled");
            }
        }

        private void btn_drop_Click(object sender, EventArgs e)
        {
            if (radio_windows.Checked == true)
            {
                string index = list_enabled.SelectedItem.ToString().Split(',')[0];
                string sqlstr = string.Format("update settings_miblib set" +
                    " sys_windows_enabled='0' where Id='{0}';", index);
                MySqlHelper.ExecuteSql(sqlstr);
                Common.flushmiblist();
                fill_list_enabled("sys_windows_enabled");
            }
            else if (radio_unix.Checked == true)
            {
                string index = list_enabled.SelectedItem.ToString().Split(',')[0];
                string sqlstr = string.Format("update settings_miblib set" +
                    " sys_linux_enabled='0' where Id='{0}';", index);
                MySqlHelper.ExecuteSql(sqlstr);
                Common.flushmiblist();
                fill_list_enabled("sys_linux_enabled");
            }
            else if (radio_otherdevices.Checked == true)
            {
                string index = list_enabled.SelectedItem.ToString().Split(',')[0];
                string sqlstr = string.Format("update settings_miblib set" +
                    " sys_common_enabled='0' where Id='{0}';", index);
                MySqlHelper.ExecuteSql(sqlstr);
                Common.flushmiblist();
                fill_list_enabled("sys_common_enabled");
            }
        }
    }
}

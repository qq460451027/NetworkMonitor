using System;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using SnmpSharpNet;
using System.Data;
using System.Data;
using MySQLHelper;
using System.Net.NetworkInformation;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace monitor
{
    class Common
    {
        public static void writetosnmp() {


        }
        public static void writetoicmp() {


        }
        public static void dumplogdatabase() {



        }
        public static void writetologfrm(string str)
        {
            frmError.write = str + " " + string.Format("{0}:{1}:{2}", DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString(),DateTime.Now.Second.ToString());
            
        }
        public static void writetofile(string str, string filename) {
            //日志文件不存在则创建
            if (!File.Exists(filename)) {
                FileStream file = File.Create(filename);
                file.Close();
                file.Dispose();
            }
            //true 若要将数据追加到该文件; false 覆盖该文件
            StreamWriter writer = new StreamWriter(filename, true);
            writer.Write(str);
            writer.Flush();
        }
        //公用表及相关操作
        public static DataTable dt; //主表datatable
        public static DataTable dtoid;  //snmp oid table
        public static DataTable dtfeq;//频率表 ,储存dev_name,dev_ip,dev_feq
        public static DataTable dt_icmp;//icmp设备表
        public static DataTable dt_snmp;//snmp设备表
        //public static DataTable dt_snmp_items_enabled;//所有启用的snmp监控条目
        public static DataTable dt_snmp_allitems;
        public static DataTable dt_snmp_enableditems;
        public static DataTable dt_printer;
        //Id,dev_name,dev_type,dev_monitor_mode,dev_ip,dev_mac,dev_extinfo,dev_feq,dev_icmp_status,dev_snmp_status

        public static void flushalldataset() {
            dt = MySqlHelper.GetDataSet("select Id,dev_name,dev_type,dev_monitor_mode,dev_ip,dev_mac,dev_extinfo,dev_feq from main_table;").Tables[0];           //填充主表缓存
            dtoid = MySqlHelper.GetDataSet("select * from settings_miblib;").Tables[0];            //填充oid缓存
            dtfeq = MySqlHelper.GetDataSet("select id,dev_feq from main_table;").Tables[0];          //填充频率缓存
            dt_icmp = MySqlHelper.GetDataSet("select Id,dev_name,dev_type,dev_monitor_mode,dev_ip,dev_mac,dev_extinfo,dev_feq,dev_icmp_status from main_table where dev_monitor_mode='ICMP';").Tables[0];       //填充设备表
            dt_snmp = MySqlHelper.GetDataSet("select Id,dev_name,dev_type,dev_monitor_mode,dev_ip,dev_mac,dev_extinfo,dev_feq,dev_snmp_status from main_table where dev_monitor_mode='SNMP';").Tables[0];
            //dt_snmp_items_enabled = MySqlHelper.GetDataSet("select * from settings_miblib;").Tables[0];
            dt_snmp_allitems= MySqlHelper.GetDataSet("select * from settings_miblib;").Tables[0];
            dt_snmp_enableditems = MySqlHelper.GetDataSet("select * from settings_miblib where sys_items_enabled=1;").Tables[0];
            dt_printer = MySqlHelper.GetDataSet("select Id,dev_name,dev_monitor_mode,dev_ip,dev_mac,dev_extinfo,dev_feq from main_table where dev_monitor_mode='Printer';").Tables[0];
        }   //刷新所有表
        public static void flushmiblist() {
            dt_snmp_allitems = MySqlHelper.GetDataSet("select * from settings_miblib;").Tables[0];
            dt_snmp_enableditems = MySqlHelper.GetDataSet("select * from settings_miblib where sys_items_enabled=1;").Tables[0];
            //DataRow [] dtsnmpenableditems=dt_snmp_allitems.Select("sys_items_enabled='1'");
        }
        public static int getfequency(string id)
        {
            string requeststr = "Id='" + id + "'";
            DataRow[] i = dtfeq.Select(requeststr);
            int feq = Convert.ToInt32(i[0]["dev_feq"]);
            if (feq > 0) return feq*1000;//单位秒转毫秒
            else return 10;
        }//根据id读取监控频率
        public static List<string> getmonitoritems(string id) {
            List<string> miblist = new List<string>();
            string type = dt.Select("Id="+id)[0]["dev_type"].ToString();
            if (type == "type_linux") {
                DataRow[] t = dt_snmp_enableditems.Select("sys_linux_enabled=1");
                for (int i = 0; i < t.Count(); i++) {
                    miblist.Add(t[i]["sys_mib"].ToString());
                }
            }
            else if (type == "type_windows") {
                DataRow[] t = dt_snmp_enableditems.Select("sys_windows_enabled=1");
                for (int i = 0; i < t.Count(); i++)
                {
                    miblist.Add(t[i]["sys_mib"].ToString());
                }
            }
            else if (type == "type_common") {
                DataRow[] t = dt_snmp_enableditems.Select("sys_common_enabled=1");
                for (int i = 0; i < t.Count(); i++)
                {
                    miblist.Add(t[i]["sys_mib"].ToString());
                }
            }
            return miblist;
        }//筛选所有符合设备类型的mib列表
        public static List<string> getmonitoritems_chinesename(List<string>miblist) {
            List<string> namelist = new List<string>();
            foreach (string i in miblist) {
                DataRow[] t = dt_snmp_enableditems.Select("sys_mib='"+i+"'");
                    namelist.Add(t[0]["sys_mib"].ToString() + ".0");
            }
            return namelist;
        }
        public static string getipbyid(string id)
        {
            string str = "Id='" + id.ToString()+"'";
            DataRow[] dr = dt.Select(str);
            return dr[0]["dev_ip"].ToString();

        }//根据id读取ip值

        public static byte[] getmac(string id)
        { 
            string requeststr = "Id='" + id + "'";
            DataRow[] j = dt.Select(requeststr);
            string mac = Convert.ToString(j[0]["dev_mac"]);
            byte[] macbyte;
            mac.Trim();
            mac = mac.Replace("-","");
            mac = mac.Replace(":","");
            if (mac.Length != 12) MessageBox.Show("地址长度错误，请检查地址是否正确。", "MAC地址获取");
            macbyte = Encoding.Default.GetBytes(mac);
            return macbyte;
        }//根据id读取mac(byte)值
        public static bool checkip(string ip) {
            string regex = @"(?:(?:1[0-9][0-9]\.)|(?:2[0-4][0-9]\.)|(?:25[0-5]\.)|(?:[1-9][0-9]\.)
            |(?:[0-9]\.)){3}(?:(?:1[0-9][0-9])|(?:2[0-4][0-9])|(?:25[0-5])|(?:[1-9][0-9])|(?:[0-9]))";
            Regex r = new Regex(regex);
            MatchCollection i = r.Matches(regex);
            if (i.Count > 0)
                return true;
            else
                return false;
        }
        public static bool checkonline(string id)
        {
            string ip = getipbyid(id);
            Ping sender = new Ping();
            PingReply reply = sender.Send(ip, 120);//第一个参数为ip地址，第二个参数为ping的时间 
            if (reply.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

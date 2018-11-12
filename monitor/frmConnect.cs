using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySQLHelper;
using System.Security.Cryptography;

namespace monitor
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //合并连接字符串并传递给MySQLHelper的connstr
            string connstr=string.Format("Host={0};UserName={1};Password={2};Database=monitor;Port={3};" +
                "CharSet=utf8;Allow Zero Datetime=true",txt_database.Text,txt_username.Text,txt_passwd.Text,txt_port.Text);
            MySqlHelper.connstr = connstr;
            DataSet db = MySqlHelper.GetDataSet("show databases;");
            if (db.Tables.Count == 0) { MessageBox.Show("无法连接到数据库，请检查登陆信息是否正确!","连接",MessageBoxButtons.OK,MessageBoxIcon.Information); }
            else if (db.Tables.Count>0) { 
            this.Close();
            }
        }
       
        private byte[] key4;
        private string EncryptKey;
        public string encrypt(string txt)
        { 
            var bytes = Encoding.Default.GetBytes(txt);
            var key = Encoding.UTF8.GetBytes(EncryptKey);
            using (MemoryStream ms = new MemoryStream())
            {//创建密文数据流
                var encrypt = new DESCryptoServiceProvider();
                CryptoStream cs = new CryptoStream(ms, encrypt.CreateEncryptor(key,key4), CryptoStreamMode.Write);
                cs.Write(bytes, 0, bytes.Length);
                cs.FlushFinalBlock();//必须刷新缓冲，否则会数据不完整
                return Convert.ToBase64String(ms.ToArray());
            }
        }
        public string decrypt(string txt)
        {
            try
            {
                var bytes = Convert.FromBase64String(txt);
                var key = Encoding.UTF8.GetBytes(EncryptKey);
                using (MemoryStream ms = new MemoryStream())
                {
                    var descrypt = new DESCryptoServiceProvider();
                    CryptoStream cs = new CryptoStream(ms, descrypt.CreateDecryptor(key,key4), CryptoStreamMode.Write);
                    cs.Write(bytes, 0, bytes.Length);
                    cs.FlushFinalBlock();
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        private void frmConnect_Load(object sender, EventArgs e)
        {
            //初始化密钥与向量
            key4= Encoding.Default.GetBytes("1111111122222222");
            EncryptKey = "22222222";//偏移向量是密钥长度的倍数
            if (File.Exists("config.txt")==true) {
                StreamReader sr = new StreamReader("config.txt");
                string line;

                List<string> items = new List<string>(); ;
                while((line = sr.ReadLine()) != null) {
                   string x = decrypt(line.Split(':')[1]);
                    items.Add(line);
                }
                foreach (string i in items) {
                    if (i.Split(':')[0] == "host")
                        txt_database.Text = decrypt(i.Split(':')[1]);
                    if (i.Split(':')[0] == "port")
                        txt_port.Text = decrypt(i.Split(':')[1]);
                    if (i.Split(':')[0] == "username")
                        txt_username.Text = decrypt(i.Split(':')[1]);
                    if (i.Split(':')[0] == "password")
                        txt_passwd.Text = decrypt(i.Split(':')[1]);
                }
                sr.Dispose();
            }
            ActiveControl = txt_passwd;
            btn_save.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (File.Exists("config.txt"))
                File.Delete("config.txt");
            StreamWriter wr = new StreamWriter("config.txt");
            wr.WriteLine("host:" + encrypt(txt_database.Text));
            wr.WriteLine("port:" + encrypt(txt_port.Text));
            wr.WriteLine("username:" + encrypt(txt_username.Text));
            wr.WriteLine("password:" + encrypt(txt_passwd.Text));
            wr.Dispose();
            MessageBox.Show("保存成功！","保存凭据",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void txt_passwd_TextChanged(object sender, EventArgs e)
        {
            btn_save.Enabled=true;
        }
    }
}

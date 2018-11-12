namespace monitor
{
    partial class frmSendStartupPacket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mac = new System.Windows.Forms.TextBox();
            this.txt_gateway = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.list_log = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chk_needcalc = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_calc_ip = new System.Windows.Forms.TextBox();
            this.txt_calc_netmask = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAC地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "广播地址";
            // 
            // txt_mac
            // 
            this.txt_mac.Location = new System.Drawing.Point(138, 52);
            this.txt_mac.Name = "txt_mac";
            this.txt_mac.Size = new System.Drawing.Size(209, 21);
            this.txt_mac.TabIndex = 3;
            // 
            // txt_gateway
            // 
            this.txt_gateway.Location = new System.Drawing.Point(138, 109);
            this.txt_gateway.Name = "txt_gateway";
            this.txt_gateway.Size = new System.Drawing.Size(209, 21);
            this.txt_gateway.TabIndex = 4;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(248, 221);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(99, 23);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "发送唤醒包";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // list_log
            // 
            this.list_log.FormattingEnabled = true;
            this.list_log.ItemHeight = 12;
            this.list_log.Location = new System.Drawing.Point(78, 276);
            this.list_log.Name = "list_log";
            this.list_log.Size = new System.Drawing.Size(269, 268);
            this.list_log.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 67);
            this.label3.TabIndex = 7;
            this.label3.Text = "注：当设备与本机处于同一子网的情况下可以不用输入网关地址。若设备\r\n\r\n与本机不在同一子网则需要输入目标机的子网网关。";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chk_needcalc
            // 
            this.chk_needcalc.AutoSize = true;
            this.chk_needcalc.Location = new System.Drawing.Point(167, 169);
            this.chk_needcalc.Name = "chk_needcalc";
            this.chk_needcalc.Size = new System.Drawing.Size(180, 16);
            this.chk_needcalc.TabIndex = 8;
            this.chk_needcalc.Text = "不知道另一子网的广播地址？";
            this.chk_needcalc.UseVisualStyleBackColor = true;
            this.chk_needcalc.CheckedChanged += new System.EventHandler(this.chk_needcalc_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(527, 55);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 12);
            this.label.TabIndex = 9;
            this.label.Text = "IP地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "子网掩码";
            // 
            // txt_calc_ip
            // 
            this.txt_calc_ip.Location = new System.Drawing.Point(604, 52);
            this.txt_calc_ip.Name = "txt_calc_ip";
            this.txt_calc_ip.Size = new System.Drawing.Size(193, 21);
            this.txt_calc_ip.TabIndex = 11;
            // 
            // txt_calc_netmask
            // 
            this.txt_calc_netmask.Location = new System.Drawing.Point(604, 110);
            this.txt_calc_netmask.Name = "txt_calc_netmask";
            this.txt_calc_netmask.Size = new System.Drawing.Size(193, 21);
            this.txt_calc_netmask.TabIndex = 12;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(698, 183);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(99, 23);
            this.btn_calc.TabIndex = 13;
            this.btn_calc.Text = "计算";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // frmSendStartupPacket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 645);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txt_calc_netmask);
            this.Controls.Add(this.txt_calc_ip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.chk_needcalc);
            this.Controls.Add(this.txt_gateway);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.list_log);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_mac);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSendStartupPacket";
            this.Text = "frmSendStartupPacket";
            this.Load += new System.EventHandler(this.frmSendStartupPacket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mac;
        private System.Windows.Forms.TextBox txt_gateway;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ListBox list_log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chk_needcalc;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_calc_ip;
        private System.Windows.Forms.TextBox txt_calc_netmask;
        private System.Windows.Forms.Button btn_calc;
    }
}
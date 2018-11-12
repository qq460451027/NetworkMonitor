namespace monitor
{
    partial class frmDeleteNode
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_devicename = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_others = new System.Windows.Forms.RichTextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_mac = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // cmb_devicename
            // 
            this.cmb_devicename.FormattingEnabled = true;
            this.cmb_devicename.Location = new System.Drawing.Point(122, 37);
            this.cmb_devicename.Name = "cmb_devicename";
            this.cmb_devicename.Size = new System.Drawing.Size(206, 20);
            this.cmb_devicename.TabIndex = 1;
            this.cmb_devicename.SelectedIndexChanged += new System.EventHandler(this.cmb_devicename_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "MAC";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "备注";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "确认删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_others
            // 
            this.txt_others.BackColor = System.Drawing.Color.White;
            this.txt_others.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_others.Enabled = false;
            this.txt_others.Location = new System.Drawing.Point(122, 265);
            this.txt_others.Name = "txt_others";
            this.txt_others.Size = new System.Drawing.Size(206, 71);
            this.txt_others.TabIndex = 9;
            this.txt_others.Text = "";
            // 
            // txt_ip
            // 
            this.txt_ip.Enabled = false;
            this.txt_ip.Location = new System.Drawing.Point(122, 173);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(206, 21);
            this.txt_ip.TabIndex = 10;
            // 
            // txt_mac
            // 
            this.txt_mac.Enabled = false;
            this.txt_mac.Location = new System.Drawing.Point(122, 216);
            this.txt_mac.Name = "txt_mac";
            this.txt_mac.Size = new System.Drawing.Size(206, 21);
            this.txt_mac.TabIndex = 11;
            // 
            // txt_type
            // 
            this.txt_type.Enabled = false;
            this.txt_type.Location = new System.Drawing.Point(122, 130);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(206, 21);
            this.txt_type.TabIndex = 13;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(87, 133);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(29, 12);
            this.lb.TabIndex = 12;
            this.lb.Text = "类型";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(122, 84);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(206, 21);
            this.txt_id.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // frmDeleteNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 411);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.txt_mac);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.txt_others);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_devicename);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteNode";
            this.Text = "删除监控点";
            this.Load += new System.EventHandler(this.frmDeleteNode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_devicename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txt_others;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_mac;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label5;
    }
}
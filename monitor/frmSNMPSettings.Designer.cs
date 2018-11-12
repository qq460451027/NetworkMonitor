namespace monitor
{
    partial class frmSNMPSettings
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
            this.list_enabled = new System.Windows.Forms.ListBox();
            this.list_all = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_drop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_all = new System.Windows.Forms.RadioButton();
            this.radio_windows = new System.Windows.Forms.RadioButton();
            this.radio_unix = new System.Windows.Forms.RadioButton();
            this.radio_otherdevices = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // list_enabled
            // 
            this.list_enabled.FormattingEnabled = true;
            this.list_enabled.ItemHeight = 12;
            this.list_enabled.Location = new System.Drawing.Point(28, 127);
            this.list_enabled.Name = "list_enabled";
            this.list_enabled.Size = new System.Drawing.Size(366, 460);
            this.list_enabled.TabIndex = 0;
            this.list_enabled.SelectedIndexChanged += new System.EventHandler(this.list_enabled_SelectedIndexChanged);
            // 
            // list_all
            // 
            this.list_all.FormattingEnabled = true;
            this.list_all.ItemHeight = 12;
            this.list_all.Location = new System.Drawing.Point(431, 127);
            this.list_all.Name = "list_all";
            this.list_all.Size = new System.Drawing.Size(366, 460);
            this.list_all.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(401, 297);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(24, 57);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "《";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_drop
            // 
            this.btn_drop.Location = new System.Drawing.Point(401, 372);
            this.btn_drop.Name = "btn_drop";
            this.btn_drop.Size = new System.Drawing.Size(24, 57);
            this.btn_drop.TabIndex = 3;
            this.btn_drop.Text = "》";
            this.btn_drop.UseVisualStyleBackColor = true;
            this.btn_drop.Click += new System.EventHandler(this.btn_drop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "所有启用的项";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "所有项";
            // 
            // radio_all
            // 
            this.radio_all.AutoSize = true;
            this.radio_all.Location = new System.Drawing.Point(31, 34);
            this.radio_all.Name = "radio_all";
            this.radio_all.Size = new System.Drawing.Size(59, 16);
            this.radio_all.TabIndex = 6;
            this.radio_all.TabStop = true;
            this.radio_all.Text = "所有项";
            this.radio_all.UseVisualStyleBackColor = true;
            this.radio_all.CheckedChanged += new System.EventHandler(this.radio_all_CheckedChanged);
            // 
            // radio_windows
            // 
            this.radio_windows.AutoSize = true;
            this.radio_windows.Location = new System.Drawing.Point(121, 34);
            this.radio_windows.Name = "radio_windows";
            this.radio_windows.Size = new System.Drawing.Size(101, 16);
            this.radio_windows.TabIndex = 7;
            this.radio_windows.TabStop = true;
            this.radio_windows.Text = "Windows启用项";
            this.radio_windows.UseVisualStyleBackColor = true;
            this.radio_windows.CheckedChanged += new System.EventHandler(this.radio_windows_CheckedChanged);
            // 
            // radio_unix
            // 
            this.radio_unix.AutoSize = true;
            this.radio_unix.Location = new System.Drawing.Point(253, 34);
            this.radio_unix.Name = "radio_unix";
            this.radio_unix.Size = new System.Drawing.Size(119, 16);
            this.radio_unix.TabIndex = 8;
            this.radio_unix.TabStop = true;
            this.radio_unix.Text = "Unix/Linux启用项";
            this.radio_unix.UseVisualStyleBackColor = true;
            this.radio_unix.CheckedChanged += new System.EventHandler(this.radio_unix_CheckedChanged);
            // 
            // radio_otherdevices
            // 
            this.radio_otherdevices.AutoSize = true;
            this.radio_otherdevices.Location = new System.Drawing.Point(403, 34);
            this.radio_otherdevices.Name = "radio_otherdevices";
            this.radio_otherdevices.Size = new System.Drawing.Size(167, 16);
            this.radio_otherdevices.TabIndex = 9;
            this.radio_otherdevices.TabStop = true;
            this.radio_otherdevices.Text = "其他支持SNMP的设备启用项";
            this.radio_otherdevices.UseVisualStyleBackColor = true;
            this.radio_otherdevices.CheckedChanged += new System.EventHandler(this.radio_otherdevices_CheckedChanged);
            // 
            // frmSNMPSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 612);
            this.Controls.Add(this.radio_otherdevices);
            this.Controls.Add(this.radio_unix);
            this.Controls.Add(this.radio_windows);
            this.Controls.Add(this.radio_all);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_all);
            this.Controls.Add(this.btn_drop);
            this.Controls.Add(this.list_enabled);
            this.Controls.Add(this.btn_add);
            this.Name = "frmSNMPSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SNMP监控设定";
            this.Load += new System.EventHandler(this.frmSNMPSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox list_all;
        private System.Windows.Forms.ListBox list_enabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_drop;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.RadioButton radio_all;
        private System.Windows.Forms.RadioButton radio_windows;
        private System.Windows.Forms.RadioButton radio_unix;
        private System.Windows.Forms.RadioButton radio_otherdevices;
    }
}
namespace monitor
{
    partial class frmError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmError));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_savetodatabase = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_dropall = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.loglist = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_savetodatabase,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btn_dropall,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(584, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btn_savetodatabase
            // 
            this.btn_savetodatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_savetodatabase.Image = global::monitor.Properties.Resources.ATLConsumer;
            this.btn_savetodatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_savetodatabase.Name = "btn_savetodatabase";
            this.btn_savetodatabase.Size = new System.Drawing.Size(36, 36);
            this.btn_savetodatabase.Text = "转储到数据库";
            this.btn_savetodatabase.Click += new System.EventHandler(this.btn_savetodatabase_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 36);
            this.toolStripLabel1.Text = "转储到数据库";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btn_dropall
            // 
            this.btn_dropall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_dropall.Image = ((System.Drawing.Image)(resources.GetObject("btn_dropall.Image")));
            this.btn_dropall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_dropall.Name = "btn_dropall";
            this.btn_dropall.Size = new System.Drawing.Size(36, 36);
            this.btn_dropall.Text = "toolStripButton2";
            this.btn_dropall.Click += new System.EventHandler(this.btn_dropall_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(56, 36);
            this.toolStripLabel2.Text = "清空列表";
            // 
            // loglist
            // 
            this.loglist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loglist.FormattingEnabled = true;
            this.loglist.ItemHeight = 12;
            this.loglist.Location = new System.Drawing.Point(0, 39);
            this.loglist.Name = "loglist";
            this.loglist.Size = new System.Drawing.Size(584, 588);
            this.loglist.TabIndex = 2;
            this.loglist.SelectedIndexChanged += new System.EventHandler(this.loglist_SelectedIndexChanged_1);
            // 
            // frmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 627);
            this.ControlBox = false;
            this.Controls.Add(this.loglist);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmError";
            this.Text = "日志";
            this.Load += new System.EventHandler(this.frmError_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_dropall;
        private System.Windows.Forms.ToolStripButton btn_savetodatabase;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ListBox loglist;
    }
}
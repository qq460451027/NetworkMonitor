namespace monitor
{
    partial class frmServerMonitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_server = new System.Windows.Forms.DataGridView();
            this.server_contextmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.发送唤醒包ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_server)).BeginInit();
            this.server_contextmenustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_server
            // 
            this.dataGridView_server.AllowUserToAddRows = false;
            this.dataGridView_server.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView_server.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_server.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_server.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_server.ContextMenuStrip = this.server_contextmenustrip;
            this.dataGridView_server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_server.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_server.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_server.Name = "dataGridView_server";
            this.dataGridView_server.RowTemplate.Height = 23;
            this.dataGridView_server.Size = new System.Drawing.Size(784, 561);
            this.dataGridView_server.TabIndex = 0;
            this.dataGridView_server.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_server_CellContentClick_1);
            this.dataGridView_server.DoubleClick += new System.EventHandler(this.dataGridView_server_DoubleClick);
            // 
            // server_contextmenustrip
            // 
            this.server_contextmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发送唤醒包ToolStripMenuItem});
            this.server_contextmenustrip.Name = "server_contextmenustrip";
            this.server_contextmenustrip.Size = new System.Drawing.Size(137, 26);
            // 
            // 发送唤醒包ToolStripMenuItem
            // 
            this.发送唤醒包ToolStripMenuItem.Name = "发送唤醒包ToolStripMenuItem";
            this.发送唤醒包ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.发送唤醒包ToolStripMenuItem.Text = "发送唤醒包";
            this.发送唤醒包ToolStripMenuItem.Click += new System.EventHandler(this.发送唤醒包ToolStripMenuItem_Click);
            // 
            // frmServerMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView_server);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServerMonitor";
            this.Text = "服务器监控";
            this.Load += new System.EventHandler(this.frmServerMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_server)).EndInit();
            this.server_contextmenustrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_server;
        private System.Windows.Forms.ContextMenuStrip server_contextmenustrip;
        private System.Windows.Forms.ToolStripMenuItem 发送唤醒包ToolStripMenuItem;
    }
}
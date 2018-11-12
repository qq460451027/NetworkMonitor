namespace monitor
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接到存储数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.监控点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加监控点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除监控点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.停止监控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始监控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高级协议ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sNMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.如何开启WindowsSNMP服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.control1 = new System.Windows.Forms.Control();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库ToolStripMenuItem,
            this.监控点ToolStripMenuItem,
            this.高级协议ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1220, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 数据库ToolStripMenuItem
            // 
            this.数据库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接到存储数据库ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripSeparator1,
            this.toolStripMenuItem6,
            this.toolStripSeparator5,
            this.导出ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.退出ToolStripMenuItem});
            this.数据库ToolStripMenuItem.Name = "数据库ToolStripMenuItem";
            this.数据库ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.数据库ToolStripMenuItem.Text = "数据库";
            // 
            // 连接到存储数据库ToolStripMenuItem
            // 
            this.连接到存储数据库ToolStripMenuItem.Image = global::monitor.Properties.Resources.icons8_数据配置_64;
            this.连接到存储数据库ToolStripMenuItem.Name = "连接到存储数据库ToolStripMenuItem";
            this.连接到存储数据库ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.连接到存储数据库ToolStripMenuItem.Text = "连接到存储数据库";
            this.连接到存储数据库ToolStripMenuItem.Click += new System.EventHandler(this.连接到存储数据库ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "断开连接";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "显示所有监控点";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("导出ToolStripMenuItem.Image")));
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.导出ToolStripMenuItem.Text = "导出";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 监控点ToolStripMenuItem
            // 
            this.监控点ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加监控点ToolStripMenuItem,
            this.删除监控点ToolStripMenuItem,
            this.toolStripSeparator4,
            this.停止监控ToolStripMenuItem,
            this.开始监控ToolStripMenuItem});
            this.监控点ToolStripMenuItem.Name = "监控点ToolStripMenuItem";
            this.监控点ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.监控点ToolStripMenuItem.Text = "监控点";
            // 
            // 增加监控点ToolStripMenuItem
            // 
            this.增加监控点ToolStripMenuItem.Name = "增加监控点ToolStripMenuItem";
            this.增加监控点ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.增加监控点ToolStripMenuItem.Text = "增加监控点";
            this.增加监控点ToolStripMenuItem.Click += new System.EventHandler(this.增加监控点ToolStripMenuItem_Click);
            // 
            // 删除监控点ToolStripMenuItem
            // 
            this.删除监控点ToolStripMenuItem.Name = "删除监控点ToolStripMenuItem";
            this.删除监控点ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除监控点ToolStripMenuItem.Text = "删除监控点";
            this.删除监控点ToolStripMenuItem.Click += new System.EventHandler(this.删除监控点ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(133, 6);
            // 
            // 停止监控ToolStripMenuItem
            // 
            this.停止监控ToolStripMenuItem.Name = "停止监控ToolStripMenuItem";
            this.停止监控ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.停止监控ToolStripMenuItem.Text = "停止监控";
            this.停止监控ToolStripMenuItem.Click += new System.EventHandler(this.停止监控ToolStripMenuItem_Click);
            // 
            // 开始监控ToolStripMenuItem
            // 
            this.开始监控ToolStripMenuItem.Name = "开始监控ToolStripMenuItem";
            this.开始监控ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.开始监控ToolStripMenuItem.Text = "开始监控";
            this.开始监控ToolStripMenuItem.Click += new System.EventHandler(this.开始监控ToolStripMenuItem_Click);
            // 
            // 高级协议ToolStripMenuItem
            // 
            this.高级协议ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sNMPToolStripMenuItem,
            this.toolStripMenuItem8,
            this.系统设置ToolStripMenuItem});
            this.高级协议ToolStripMenuItem.Name = "高级协议ToolStripMenuItem";
            this.高级协议ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.高级协议ToolStripMenuItem.Text = "设置";
            this.高级协议ToolStripMenuItem.Click += new System.EventHandler(this.高级协议ToolStripMenuItem_Click);
            // 
            // sNMPToolStripMenuItem
            // 
            this.sNMPToolStripMenuItem.Name = "sNMPToolStripMenuItem";
            this.sNMPToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sNMPToolStripMenuItem.Text = "SNMP相关设置";
            this.sNMPToolStripMenuItem.Click += new System.EventHandler(this.sNMPToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(157, 6);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            this.系统设置ToolStripMenuItem.Click += new System.EventHandler(this.系统设置ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.如何开启WindowsSNMP服务ToolStripMenuItem,
            this.toolStripSeparator2,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 如何开启WindowsSNMP服务ToolStripMenuItem
            // 
            this.如何开启WindowsSNMP服务ToolStripMenuItem.Name = "如何开启WindowsSNMP服务ToolStripMenuItem";
            this.如何开启WindowsSNMP服务ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.如何开启WindowsSNMP服务ToolStripMenuItem.Text = "如何开启SNMP服务";
            this.如何开启WindowsSNMP服务ToolStripMenuItem.Click += new System.EventHandler(this.如何开启WindowsSNMP服务ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1220, 760);
            this.splitContainer1.SplitterDistance = 854;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel1.SizeChanged += new System.EventHandler(this.splitContainer2_Panel1_SizeChanged);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(854, 760);
            this.splitContainer2.SplitterDistance = 233;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoving += new System.Windows.Forms.SplitterCancelEventHandler(this.splitContainer2_SplitterMoving);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel1_Paint);
            this.splitContainer3.Size = new System.Drawing.Size(854, 523);
            this.splitContainer3.SplitterDistance = 256;
            this.splitContainer3.TabIndex = 0;
            this.splitContainer3.SplitterMoving += new System.Windows.Forms.SplitterCancelEventHandler(this.splitContainer3_SplitterMoving);
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(0, 0);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(0, 0);
            this.control1.TabIndex = 0;
            this.control1.Text = "control1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 785);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "网络设备监控";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接到存储数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 监控点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加监控点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除监控点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高级协议ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sNMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 如何开启WindowsSNMP服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 停止监控ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Control control1;
        private System.Windows.Forms.ToolStripMenuItem 开始监控ToolStripMenuItem;
    }
}


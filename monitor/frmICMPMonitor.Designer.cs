namespace monitor
{
    partial class frmICMPMonitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_device = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_device)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_device
            // 
            this.dataGridView_device.AllowUserToAddRows = false;
            this.dataGridView_device.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_device.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_device.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_device.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_device.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_device.Name = "dataGridView_device";
            this.dataGridView_device.RowTemplate.Height = 23;
            this.dataGridView_device.Size = new System.Drawing.Size(784, 561);
            this.dataGridView_device.TabIndex = 0;
            this.dataGridView_device.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_device_CellContentClick);
            // 
            // frmICMPMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView_device);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmICMPMonitor";
            this.Text = "设备监控";
            this.Load += new System.EventHandler(this.frmICMPMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_device)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_device;
    }
}
namespace monitor
{
    partial class frmPrinterMonitor
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
            this.dataGridView_printer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_printer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_printer
            // 
            this.dataGridView_printer.AllowUserToAddRows = false;
            this.dataGridView_printer.AllowUserToDeleteRows = false;
            this.dataGridView_printer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_printer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_printer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_printer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_printer.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_printer.Name = "dataGridView_printer";
            this.dataGridView_printer.RowTemplate.Height = 23;
            this.dataGridView_printer.Size = new System.Drawing.Size(784, 561);
            this.dataGridView_printer.TabIndex = 0;
            this.dataGridView_printer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_printer_CellContentClick);
            // 
            // frmPrinterMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView_printer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrinterMonitor";
            this.Text = "打印机监控";
            this.Load += new System.EventHandler(this.frmPrinterMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_printer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_printer;
    }
}
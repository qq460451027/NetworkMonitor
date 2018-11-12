namespace monitor
{
    partial class frmCheckSNMPDetails
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
            this.list_items = new System.Windows.Forms.ListBox();
            this.txt_details = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // list_items
            // 
            this.list_items.FormattingEnabled = true;
            this.list_items.ItemHeight = 12;
            this.list_items.Location = new System.Drawing.Point(23, 24);
            this.list_items.Name = "list_items";
            this.list_items.Size = new System.Drawing.Size(268, 664);
            this.list_items.TabIndex = 0;
            this.list_items.SelectedIndexChanged += new System.EventHandler(this.list_items_SelectedIndexChanged);
            // 
            // txt_details
            // 
            this.txt_details.Location = new System.Drawing.Point(298, 24);
            this.txt_details.Name = "txt_details";
            this.txt_details.Size = new System.Drawing.Size(692, 664);
            this.txt_details.TabIndex = 1;
            this.txt_details.Text = "";
            // 
            // frmCheckSNMPDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.txt_details);
            this.Controls.Add(this.list_items);
            this.Name = "frmCheckSNMPDetails";
            this.Text = "frmCheckSNMPDetails";
            this.Load += new System.EventHandler(this.frmCheckSNMPDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_items;
        private System.Windows.Forms.RichTextBox txt_details;
    }
}
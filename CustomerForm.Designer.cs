
namespace C969_Performance_Assessment
{
    partial class CustomerForm
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
            this.customerDGV = new System.Windows.Forms.DataGridView();
            this.addCustButton = new System.Windows.Forms.Button();
            this.updateCustButton = new System.Windows.Forms.Button();
            this.delCustButton = new System.Windows.Forms.Button();
            this.currentUserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDGV
            // 
            this.customerDGV.AllowUserToAddRows = false;
            this.customerDGV.AllowUserToResizeRows = false;
            this.customerDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDGV.Location = new System.Drawing.Point(133, 21);
            this.customerDGV.Margin = new System.Windows.Forms.Padding(2);
            this.customerDGV.MultiSelect = false;
            this.customerDGV.Name = "customerDGV";
            this.customerDGV.ReadOnly = true;
            this.customerDGV.RowHeadersVisible = false;
            this.customerDGV.RowHeadersWidth = 51;
            this.customerDGV.RowTemplate.Height = 24;
            this.customerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDGV.Size = new System.Drawing.Size(997, 426);
            this.customerDGV.TabIndex = 3;
            // 
            // addCustButton
            // 
            this.addCustButton.Location = new System.Drawing.Point(20, 21);
            this.addCustButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCustButton.Name = "addCustButton";
            this.addCustButton.Size = new System.Drawing.Size(97, 28);
            this.addCustButton.TabIndex = 0;
            this.addCustButton.Text = "Add";
            this.addCustButton.UseVisualStyleBackColor = true;
            this.addCustButton.Click += new System.EventHandler(this.addCustButton_Click);
            // 
            // updateCustButton
            // 
            this.updateCustButton.Location = new System.Drawing.Point(20, 53);
            this.updateCustButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateCustButton.Name = "updateCustButton";
            this.updateCustButton.Size = new System.Drawing.Size(97, 28);
            this.updateCustButton.TabIndex = 1;
            this.updateCustButton.Text = "Update";
            this.updateCustButton.UseVisualStyleBackColor = true;
            this.updateCustButton.Click += new System.EventHandler(this.updateCustButton_Click);
            // 
            // delCustButton
            // 
            this.delCustButton.Location = new System.Drawing.Point(20, 85);
            this.delCustButton.Margin = new System.Windows.Forms.Padding(2);
            this.delCustButton.Name = "delCustButton";
            this.delCustButton.Size = new System.Drawing.Size(98, 28);
            this.delCustButton.TabIndex = 2;
            this.delCustButton.Text = "Delete";
            this.delCustButton.UseVisualStyleBackColor = true;
            this.delCustButton.Click += new System.EventHandler(this.delCustButton_Click);
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(23, 23);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1141, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(148, 17);
            this.toolStripStatusLabel1.Text = "Logged In As: Current User";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(19, 118);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(98, 28);
            this.BackBtn.TabIndex = 8;
            this.BackBtn.Text = "<- Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 469);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.delCustButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.addCustButton);
            this.Controls.Add(this.updateCustButton);
            this.Controls.Add(this.customerDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(618, 341);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDGV;
        private System.Windows.Forms.Button addCustButton;
        private System.Windows.Forms.Button updateCustButton;
        private System.Windows.Forms.Button delCustButton;
        private System.Windows.Forms.ToolStripStatusLabel currentUserLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button BackBtn;
    }
}
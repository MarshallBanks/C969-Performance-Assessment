
namespace C969_Performance_Assessment
{
    partial class ReportingForm
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
            this.typeCountByMonth = new System.Windows.Forms.RadioButton();
            this.appointmentsByConsultant = new System.Windows.Forms.RadioButton();
            this.appointmentByCustomer = new System.Windows.Forms.RadioButton();
            this.backButton = new System.Windows.Forms.Button();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // typeCountByMonth
            // 
            this.typeCountByMonth.AutoSize = true;
            this.typeCountByMonth.Location = new System.Drawing.Point(12, 12);
            this.typeCountByMonth.Name = "typeCountByMonth";
            this.typeCountByMonth.Size = new System.Drawing.Size(128, 17);
            this.typeCountByMonth.TabIndex = 1;
            this.typeCountByMonth.TabStop = true;
            this.typeCountByMonth.Text = "Type Count By Month";
            this.typeCountByMonth.UseVisualStyleBackColor = true;
            this.typeCountByMonth.CheckedChanged += new System.EventHandler(this.typeCountByMonth_CheckedChanged);
            // 
            // appointmentsByConsultant
            // 
            this.appointmentsByConsultant.AutoSize = true;
            this.appointmentsByConsultant.Location = new System.Drawing.Point(12, 35);
            this.appointmentsByConsultant.Name = "appointmentsByConsultant";
            this.appointmentsByConsultant.Size = new System.Drawing.Size(157, 17);
            this.appointmentsByConsultant.TabIndex = 2;
            this.appointmentsByConsultant.TabStop = true;
            this.appointmentsByConsultant.Text = "Appointments By Consultant";
            this.appointmentsByConsultant.UseVisualStyleBackColor = true;
            this.appointmentsByConsultant.CheckedChanged += new System.EventHandler(this.appointmentsByConsultant_CheckedChanged);
            // 
            // appointmentByCustomer
            // 
            this.appointmentByCustomer.AutoSize = true;
            this.appointmentByCustomer.Location = new System.Drawing.Point(12, 58);
            this.appointmentByCustomer.Name = "appointmentByCustomer";
            this.appointmentByCustomer.Size = new System.Drawing.Size(146, 17);
            this.appointmentByCustomer.TabIndex = 3;
            this.appointmentByCustomer.TabStop = true;
            this.appointmentByCustomer.Text = "Appointment By Customer";
            this.appointmentByCustomer.UseVisualStyleBackColor = true;
            this.appointmentByCustomer.CheckedChanged += new System.EventHandler(this.appointmentByCustomer_CheckedChanged);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 81);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(98, 32);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "<- Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.AllowUserToAddRows = false;
            this.reportDataGridView.AllowUserToResizeRows = false;
            this.reportDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Location = new System.Drawing.Point(251, 12);
            this.reportDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.reportDataGridView.MultiSelect = false;
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.ReadOnly = true;
            this.reportDataGridView.RowHeadersVisible = false;
            this.reportDataGridView.RowHeadersWidth = 51;
            this.reportDataGridView.RowTemplate.Height = 24;
            this.reportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportDataGridView.Size = new System.Drawing.Size(879, 426);
            this.reportDataGridView.TabIndex = 7;
            // 
            // ReportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 469);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.appointmentByCustomer);
            this.Controls.Add(this.appointmentsByConsultant);
            this.Controls.Add(this.typeCountByMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportingForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton typeCountByMonth;
        private System.Windows.Forms.RadioButton appointmentsByConsultant;
        private System.Windows.Forms.RadioButton appointmentByCustomer;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView reportDataGridView;
    }
}
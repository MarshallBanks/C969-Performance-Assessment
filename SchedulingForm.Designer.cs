
namespace C969_Performance_Assessment
{
    partial class SchedulingForm
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
            this.monthlyButton = new System.Windows.Forms.RadioButton();
            this.weeklyButton = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.appointmentDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // monthlyButton
            // 
            this.monthlyButton.AutoSize = true;
            this.monthlyButton.Location = new System.Drawing.Point(24, 131);
            this.monthlyButton.Margin = new System.Windows.Forms.Padding(4);
            this.monthlyButton.Name = "monthlyButton";
            this.monthlyButton.Size = new System.Drawing.Size(104, 20);
            this.monthlyButton.TabIndex = 1;
            this.monthlyButton.TabStop = true;
            this.monthlyButton.Text = "Monthly View";
            this.monthlyButton.UseVisualStyleBackColor = true;
            // 
            // weeklyButton
            // 
            this.weeklyButton.AutoSize = true;
            this.weeklyButton.Location = new System.Drawing.Point(25, 159);
            this.weeklyButton.Margin = new System.Windows.Forms.Padding(4);
            this.weeklyButton.Name = "weeklyButton";
            this.weeklyButton.Size = new System.Drawing.Size(104, 20);
            this.weeklyButton.TabIndex = 2;
            this.weeklyButton.TabStop = true;
            this.weeklyButton.Text = "Weekly View";
            this.weeklyButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(41, 13);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 28);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(41, 49);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 28);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(41, 84);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // appointmentDGV
            // 
            this.appointmentDGV.AllowUserToAddRows = false;
            this.appointmentDGV.AllowUserToResizeRows = false;
            this.appointmentDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDGV.Location = new System.Drawing.Point(193, 11);
            this.appointmentDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentDGV.MultiSelect = false;
            this.appointmentDGV.Name = "appointmentDGV";
            this.appointmentDGV.ReadOnly = true;
            this.appointmentDGV.RowHeadersVisible = false;
            this.appointmentDGV.RowHeadersWidth = 51;
            this.appointmentDGV.RowTemplate.Height = 24;
            this.appointmentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentDGV.Size = new System.Drawing.Size(900, 532);
            this.appointmentDGV.TabIndex = 6;
            // 
            // SchedulingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 554);
            this.Controls.Add(this.appointmentDGV);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.weeklyButton);
            this.Controls.Add(this.monthlyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SchedulingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduling Appointment Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SchedulingForm_FormClosed);
            this.Load += new System.EventHandler(this.SchedulingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton monthlyButton;
        private System.Windows.Forms.RadioButton weeklyButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView appointmentDGV;
    }
}

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
            this.components = new System.ComponentModel.Container();
            this.currentMonthButton = new System.Windows.Forms.RadioButton();
            this.currentWeekButton = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.appointmentDGV = new System.Windows.Forms.DataGridView();
            this.customerEditorBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.noFilterButton = new System.Windows.Forms.RadioButton();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.selectedMonthButton = new System.Windows.Forms.RadioButton();
            this.selectedWeekButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reportsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentMonthButton
            // 
            this.currentMonthButton.AutoSize = true;
            this.currentMonthButton.Location = new System.Drawing.Point(11, 204);
            this.currentMonthButton.Name = "currentMonthButton";
            this.currentMonthButton.Size = new System.Drawing.Size(92, 17);
            this.currentMonthButton.TabIndex = 1;
            this.currentMonthButton.Text = "Current Month";
            this.currentMonthButton.UseVisualStyleBackColor = true;
            this.currentMonthButton.Click += new System.EventHandler(this.currentMonthButton_Click);
            // 
            // currentWeekButton
            // 
            this.currentWeekButton.AutoSize = true;
            this.currentWeekButton.Location = new System.Drawing.Point(11, 227);
            this.currentWeekButton.Name = "currentWeekButton";
            this.currentWeekButton.Size = new System.Drawing.Size(91, 17);
            this.currentWeekButton.TabIndex = 2;
            this.currentWeekButton.Text = "Current Week";
            this.currentWeekButton.UseVisualStyleBackColor = true;
            this.currentWeekButton.Click += new System.EventHandler(this.currentWeekButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(37, 273);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(170, 28);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(37, 307);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(170, 28);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(37, 341);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(170, 28);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // appointmentDGV
            // 
            this.appointmentDGV.AllowUserToAddRows = false;
            this.appointmentDGV.AllowUserToResizeRows = false;
            this.appointmentDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDGV.Location = new System.Drawing.Point(250, 12);
            this.appointmentDGV.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentDGV.MultiSelect = false;
            this.appointmentDGV.Name = "appointmentDGV";
            this.appointmentDGV.ReadOnly = true;
            this.appointmentDGV.RowHeadersVisible = false;
            this.appointmentDGV.RowHeadersWidth = 51;
            this.appointmentDGV.RowTemplate.Height = 24;
            this.appointmentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentDGV.Size = new System.Drawing.Size(879, 426);
            this.appointmentDGV.TabIndex = 6;
            // 
            // customerEditorBtn
            // 
            this.customerEditorBtn.Location = new System.Drawing.Point(37, 375);
            this.customerEditorBtn.Name = "customerEditorBtn";
            this.customerEditorBtn.Size = new System.Drawing.Size(170, 28);
            this.customerEditorBtn.TabIndex = 7;
            this.customerEditorBtn.Text = "Customer Editor";
            this.customerEditorBtn.UseVisualStyleBackColor = true;
            this.customerEditorBtn.Click += new System.EventHandler(this.customerEditorBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1141, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(148, 17);
            this.toolStripStatusLabel1.Text = "Logged In As: Current User";
            // 
            // noFilterButton
            // 
            this.noFilterButton.AutoSize = true;
            this.noFilterButton.Checked = true;
            this.noFilterButton.Location = new System.Drawing.Point(11, 250);
            this.noFilterButton.Name = "noFilterButton";
            this.noFilterButton.Size = new System.Drawing.Size(64, 17);
            this.noFilterButton.TabIndex = 9;
            this.noFilterButton.TabStop = true;
            this.noFilterButton.Text = "No Filter";
            this.noFilterButton.UseVisualStyleBackColor = true;
            this.noFilterButton.Click += new System.EventHandler(this.noFilterButton_Click);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(10, 30);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 10;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            // 
            // selectedMonthButton
            // 
            this.selectedMonthButton.AutoSize = true;
            this.selectedMonthButton.Location = new System.Drawing.Point(108, 204);
            this.selectedMonthButton.Name = "selectedMonthButton";
            this.selectedMonthButton.Size = new System.Drawing.Size(100, 17);
            this.selectedMonthButton.TabIndex = 11;
            this.selectedMonthButton.Text = "Selected Month";
            this.selectedMonthButton.UseVisualStyleBackColor = true;
            this.selectedMonthButton.Click += new System.EventHandler(this.selectedMonthButton_Click);
            // 
            // selectedWeekButton
            // 
            this.selectedWeekButton.AutoSize = true;
            this.selectedWeekButton.Location = new System.Drawing.Point(108, 227);
            this.selectedWeekButton.Name = "selectedWeekButton";
            this.selectedWeekButton.Size = new System.Drawing.Size(99, 17);
            this.selectedWeekButton.TabIndex = 12;
            this.selectedWeekButton.Text = "Selected Week";
            this.selectedWeekButton.UseVisualStyleBackColor = true;
            this.selectedWeekButton.Click += new System.EventHandler(this.selectedWeekButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Appointment Filter";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reportsButton
            // 
            this.reportsButton.Location = new System.Drawing.Point(37, 409);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(170, 28);
            this.reportsButton.TabIndex = 14;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // SchedulingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 469);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedWeekButton);
            this.Controls.Add(this.selectedMonthButton);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.noFilterButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.customerEditorBtn);
            this.Controls.Add(this.appointmentDGV);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.currentWeekButton);
            this.Controls.Add(this.currentMonthButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SchedulingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduling Appointment Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SchedulingForm_FormClosed);
            this.Load += new System.EventHandler(this.SchedulingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton currentMonthButton;
        private System.Windows.Forms.RadioButton currentWeekButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView appointmentDGV;
        private System.Windows.Forms.Button customerEditorBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RadioButton noFilterButton;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.RadioButton selectedMonthButton;
        private System.Windows.Forms.RadioButton selectedWeekButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button reportsButton;
    }
}
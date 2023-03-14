
namespace C969_Performance_Assessment
{
    partial class UpdateCustForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.postalCodeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.address2Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inactiveButton = new System.Windows.Forms.RadioButton();
            this.activeButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Postal Code*";
            // 
            // postalCodeBox
            // 
            this.postalCodeBox.Location = new System.Drawing.Point(110, 180);
            this.postalCodeBox.Margin = new System.Windows.Forms.Padding(4);
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.Size = new System.Drawing.Size(111, 20);
            this.postalCodeBox.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "City*";
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "New York",
            "Los Angeles",
            "Toronto",
            "Vancouver",
            "Oslo"});
            this.cityComboBox.Location = new System.Drawing.Point(9, 179);
            this.cityComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(92, 21);
            this.cityComboBox.TabIndex = 32;
            // 
            // address2Box
            // 
            this.address2Box.Location = new System.Drawing.Point(9, 141);
            this.address2Box.Margin = new System.Windows.Forms.Padding(4);
            this.address2Box.Name = "address2Box";
            this.address2Box.Size = new System.Drawing.Size(212, 20);
            this.address2Box.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Address Line 2";
            // 
            // fullNameBox
            // 
            this.fullNameBox.Location = new System.Drawing.Point(9, 41);
            this.fullNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(212, 20);
            this.fullNameBox.TabIndex = 20;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(171, 271);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(80, 26);
            this.updateButton.TabIndex = 23;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(81, 271);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 26);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Phone Number*";
            // 
            // inactiveButton
            // 
            this.inactiveButton.AutoSize = true;
            this.inactiveButton.Location = new System.Drawing.Point(251, 113);
            this.inactiveButton.Margin = new System.Windows.Forms.Padding(2);
            this.inactiveButton.Name = "inactiveButton";
            this.inactiveButton.Size = new System.Drawing.Size(63, 17);
            this.inactiveButton.TabIndex = 26;
            this.inactiveButton.TabStop = true;
            this.inactiveButton.Text = "Inactive";
            this.inactiveButton.UseVisualStyleBackColor = true;
            // 
            // activeButton
            // 
            this.activeButton.AutoSize = true;
            this.activeButton.Checked = true;
            this.activeButton.Location = new System.Drawing.Point(251, 72);
            this.activeButton.Margin = new System.Windows.Forms.Padding(2);
            this.activeButton.Name = "activeButton";
            this.activeButton.Size = new System.Drawing.Size(55, 17);
            this.activeButton.TabIndex = 25;
            this.activeButton.TabStop = true;
            this.activeButton.Text = "Active";
            this.activeButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Address Line 1*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Full Name*";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(9, 93);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(212, 20);
            this.addressBox.TabIndex = 21;
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(9, 229);
            this.phoneNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(212, 20);
            this.phoneNumberBox.TabIndex = 22;
            this.phoneNumberBox.TextChanged += new System.EventHandler(this.phoneNumberBox_TextChanged);
            // 
            // UpdateCustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 324);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.postalCodeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.address2Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inactiveButton);
            this.Controls.Add(this.activeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.phoneNumberBox);
            this.Name = "UpdateCustForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox postalCodeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton inactiveButton;
        private System.Windows.Forms.RadioButton activeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox phoneNumberBox;
    }
}
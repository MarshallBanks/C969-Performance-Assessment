
namespace C969_Performance_Assessment
{
    partial class AddCustForm
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
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activeButton = new System.Windows.Forms.RadioButton();
            this.inactiveButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.address2Box = new System.Windows.Forms.TextBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.postalCodeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(12, 282);
            this.phoneNumberBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(281, 22);
            this.phoneNumberBox.TabIndex = 3;
            this.phoneNumberBox.TextChanged += new System.EventHandler(this.phoneNumberBox_TextChanged);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(12, 114);
            this.addressBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(281, 22);
            this.addressBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Full Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Address Line 1*";
            // 
            // activeButton
            // 
            this.activeButton.AutoSize = true;
            this.activeButton.Checked = true;
            this.activeButton.Location = new System.Drawing.Point(335, 89);
            this.activeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activeButton.Name = "activeButton";
            this.activeButton.Size = new System.Drawing.Size(63, 20);
            this.activeButton.TabIndex = 6;
            this.activeButton.TabStop = true;
            this.activeButton.Text = "Active";
            this.activeButton.UseVisualStyleBackColor = true;
            // 
            // inactiveButton
            // 
            this.inactiveButton.AutoSize = true;
            this.inactiveButton.Location = new System.Drawing.Point(335, 139);
            this.inactiveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inactiveButton.Name = "inactiveButton";
            this.inactiveButton.Size = new System.Drawing.Size(72, 20);
            this.inactiveButton.TabIndex = 7;
            this.inactiveButton.TabStop = true;
            this.inactiveButton.Text = "Inactive";
            this.inactiveButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Phone Number*";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(108, 334);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 32);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(228, 334);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 32);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // fullNameBox
            // 
            this.fullNameBox.Location = new System.Drawing.Point(12, 50);
            this.fullNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(281, 22);
            this.fullNameBox.TabIndex = 0;
            this.nameToolTip.SetToolTip(this.fullNameBox, "Full name should contain only letters and spaces.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Address Line 2";
            // 
            // address2Box
            // 
            this.address2Box.Location = new System.Drawing.Point(12, 174);
            this.address2Box.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.address2Box.Name = "address2Box";
            this.address2Box.Size = new System.Drawing.Size(281, 22);
            this.address2Box.TabIndex = 15;
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
            this.cityComboBox.Location = new System.Drawing.Point(12, 220);
            this.cityComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 24);
            this.cityComboBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "City*";
            // 
            // postalCodeBox
            // 
            this.postalCodeBox.Location = new System.Drawing.Point(147, 222);
            this.postalCodeBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.postalCodeBox.Name = "postalCodeBox";
            this.postalCodeBox.Size = new System.Drawing.Size(147, 22);
            this.postalCodeBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Postal Code*";
            // 
            // nameToolTip
            // 
            this.nameToolTip.ToolTipTitle = "Invalid Input";
            // 
            // AddCustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 399);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.postalCodeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.address2Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inactiveButton);
            this.Controls.Add(this.activeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.phoneNumberBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCustForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.AddCustForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton activeButton;
        private System.Windows.Forms.RadioButton inactiveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox postalCodeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip nameToolTip;
    }
}
namespace TrendCustromControls
{
    partial class PhoneUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPhoneLastFour = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPhoneFirstThree = new System.Windows.Forms.MaskedTextBox();
            this.textboxAreaCode = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.cmbboxPhoneType = new System.Windows.Forms.ComboBox();
            this.lblPhoneType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPhoneLastFour);
            this.groupBox1.Controls.Add(this.textBoxPhoneFirstThree);
            this.groupBox1.Controls.Add(this.textboxAreaCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxExtension);
            this.groupBox1.Controls.Add(this.lblExtension);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.cmbboxPhoneType);
            this.groupBox1.Controls.Add(this.lblPhoneType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phone Number";
            // 
            // textBoxPhoneLastFour
            // 
            this.textBoxPhoneLastFour.Location = new System.Drawing.Point(173, 48);
            this.textBoxPhoneLastFour.Mask = "0000";
            this.textBoxPhoneLastFour.Name = "textBoxPhoneLastFour";
            this.textBoxPhoneLastFour.PromptChar = ' ';
            this.textBoxPhoneLastFour.Size = new System.Drawing.Size(68, 20);
            this.textBoxPhoneLastFour.TabIndex = 15;
            this.textBoxPhoneLastFour.Enter += new System.EventHandler(this.ueTxtAny_Enter);
            // 
            // textBoxPhoneFirstThree
            // 
            this.textBoxPhoneFirstThree.Location = new System.Drawing.Point(110, 48);
            this.textBoxPhoneFirstThree.Mask = "000";
            this.textBoxPhoneFirstThree.Name = "textBoxPhoneFirstThree";
            this.textBoxPhoneFirstThree.PromptChar = ' ';
            this.textBoxPhoneFirstThree.Size = new System.Drawing.Size(40, 20);
            this.textBoxPhoneFirstThree.TabIndex = 14;
            this.textBoxPhoneFirstThree.Enter += new System.EventHandler(this.ueTxtAny_Enter);
            // 
            // textboxAreaCode
            // 
            this.textboxAreaCode.Location = new System.Drawing.Point(58, 48);
            this.textboxAreaCode.Mask = "000";
            this.textboxAreaCode.Name = "textboxAreaCode";
            this.textboxAreaCode.PromptChar = ' ';
            this.textboxAreaCode.Size = new System.Drawing.Size(40, 20);
            this.textboxAreaCode.TabIndex = 13;
            this.textboxAreaCode.Enter += new System.EventHandler(this.ueTxtAny_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(281, 48);
            this.textBoxExtension.MaxLength = 7;
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(46, 20);
            this.textBoxExtension.TabIndex = 16;
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(255, 52);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(25, 13);
            this.lblExtension.TabIndex = 6;
            this.lblExtension.Text = "Ext.";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(5, 52);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(44, 13);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Number";
            // 
            // cmbboxPhoneType
            // 
            this.cmbboxPhoneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxPhoneType.FormattingEnabled = true;
            this.cmbboxPhoneType.Location = new System.Drawing.Point(57, 19);
            this.cmbboxPhoneType.Name = "cmbboxPhoneType";
            this.cmbboxPhoneType.Size = new System.Drawing.Size(222, 21);
            this.cmbboxPhoneType.TabIndex = 12;
            // 
            // lblPhoneType
            // 
            this.lblPhoneType.AutoSize = true;
            this.lblPhoneType.Location = new System.Drawing.Point(5, 19);
            this.lblPhoneType.Name = "lblPhoneType";
            this.lblPhoneType.Size = new System.Drawing.Size(31, 13);
            this.lblPhoneType.TabIndex = 0;
            this.lblPhoneType.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "(";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = ")";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "-";
            // 
            // PhoneUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PhoneUserControl";
            this.Size = new System.Drawing.Size(352, 88);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbboxPhoneType;
        private System.Windows.Forms.Label lblPhoneType;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox textBoxPhoneLastFour;
        private System.Windows.Forms.MaskedTextBox textBoxPhoneFirstThree;
        private System.Windows.Forms.MaskedTextBox textboxAreaCode;
    }
}

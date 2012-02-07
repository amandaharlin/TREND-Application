namespace TrendWinForm
{
    partial class CustomerandCaseInformation
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
            this.txtInitialsMidCon = new System.Windows.Forms.TextBox();
            this.Label67 = new System.Windows.Forms.Label();
            this.dtpMidCon = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime_NeedsChange = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtMatter = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.cmbboxRequester = new System.Windows.Forms.ComboBox();
            this.cmbboxExaminer = new System.Windows.Forms.ComboBox();
            this.cmbboxFirm = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.txtItemNum = new System.Windows.Forms.TextBox();
            this.txtCaseNum = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInitialsMidCon
            // 
            this.txtInitialsMidCon.Location = new System.Drawing.Point(666, 77);
            this.txtInitialsMidCon.Name = "txtInitialsMidCon";
            this.txtInitialsMidCon.Size = new System.Drawing.Size(32, 20);
            this.txtInitialsMidCon.TabIndex = 41;
            this.txtInitialsMidCon.TextChanged += new System.EventHandler(this.txtInitialsMidCon_TextChanged);
            // 
            // Label67
            // 
            this.Label67.AutoSize = true;
            this.Label67.ForeColor = System.Drawing.Color.IndianRed;
            this.Label67.Location = new System.Drawing.Point(373, 66);
            this.Label67.Name = "Label67";
            this.Label67.Size = new System.Drawing.Size(198, 39);
            this.Label67.TabIndex = 40;
            this.Label67.Text = "* Please record the date that the bar-\r\ncode submission to MidCon was verified;\r\n" +
    "please record your initials in the box:";
            // 
            // dtpMidCon
            // 
            this.dtpMidCon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMidCon.Location = new System.Drawing.Point(577, 77);
            this.dtpMidCon.Name = "dtpMidCon";
            this.dtpMidCon.Size = new System.Drawing.Size(83, 20);
            this.dtpMidCon.TabIndex = 39;
            this.dtpMidCon.ValueChanged += new System.EventHandler(this.dtpMidCon_ValueChanged);
            // 
            // dtpStartTime_NeedsChange
            // 
            this.dtpStartTime_NeedsChange.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime_NeedsChange.Location = new System.Drawing.Point(578, 177);
            this.dtpStartTime_NeedsChange.Name = "dtpStartTime_NeedsChange";
            this.dtpStartTime_NeedsChange.Size = new System.Drawing.Size(120, 20);
            this.dtpStartTime_NeedsChange.TabIndex = 38;
            this.dtpStartTime_NeedsChange.ValueChanged += new System.EventHandler(this.dtpStartTime_NeedsChange_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(347, 179);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(121, 20);
            this.dtpStartDate.TabIndex = 37;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.ForeColor = System.Drawing.Color.IndianRed;
            this.Label11.Location = new System.Drawing.Point(517, 185);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(55, 13);
            this.Label11.TabIndex = 36;
            this.Label11.Text = "Start Time";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.Color.IndianRed;
            this.Label10.Location = new System.Drawing.Point(286, 185);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(55, 13);
            this.Label10.TabIndex = 35;
            this.Label10.Text = "Start Date";
            // 
            // txtMatter
            // 
            this.txtMatter.BackColor = System.Drawing.Color.LightYellow;
            this.txtMatter.Location = new System.Drawing.Point(63, 132);
            this.txtMatter.Name = "txtMatter";
            this.txtMatter.Size = new System.Drawing.Size(121, 20);
            this.txtMatter.TabIndex = 34;
            this.txtMatter.TextChanged += new System.EventHandler(this.txtMatter_TextChanged);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.Color.IndianRed;
            this.Label9.Location = new System.Drawing.Point(20, 138);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(37, 13);
            this.Label9.TabIndex = 33;
            this.Label9.Text = "Matter";
            // 
            // cmbboxRequester
            // 
            this.cmbboxRequester.BackColor = System.Drawing.Color.LightYellow;
            this.cmbboxRequester.FormattingEnabled = true;
            this.cmbboxRequester.Location = new System.Drawing.Point(577, 130);
            this.cmbboxRequester.Name = "cmbboxRequester";
            this.cmbboxRequester.Size = new System.Drawing.Size(121, 21);
            this.cmbboxRequester.TabIndex = 32;
            this.cmbboxRequester.SelectedIndexChanged += new System.EventHandler(this.cmbboxRequester_SelectedIndexChanged);
            // 
            // cmbboxExaminer
            // 
            this.cmbboxExaminer.BackColor = System.Drawing.Color.LightYellow;
            this.cmbboxExaminer.FormattingEnabled = true;
            this.cmbboxExaminer.Items.AddRange(new object[] {
            "Patrick",
            "Dee",
            "Gary",
            "Mike",
            "Neil",
            "Dennis",
            "Calvin"});
            this.cmbboxExaminer.Location = new System.Drawing.Point(347, 130);
            this.cmbboxExaminer.Name = "cmbboxExaminer";
            this.cmbboxExaminer.Size = new System.Drawing.Size(121, 21);
            this.cmbboxExaminer.TabIndex = 31;
            this.cmbboxExaminer.SelectedIndexChanged += new System.EventHandler(this.cmbboxExaminer_SelectedIndexChanged);
            // 
            // cmbboxFirm
            // 
            this.cmbboxFirm.BackColor = System.Drawing.Color.LightYellow;
            this.cmbboxFirm.FormattingEnabled = true;
            this.cmbboxFirm.Location = new System.Drawing.Point(63, 75);
            this.cmbboxFirm.Name = "cmbboxFirm";
            this.cmbboxFirm.Size = new System.Drawing.Size(121, 21);
            this.cmbboxFirm.TabIndex = 30;
            this.cmbboxFirm.SelectedIndexChanged += new System.EventHandler(this.cmbboxFirm_SelectedIndexChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.Color.IndianRed;
            this.Label8.Location = new System.Drawing.Point(515, 138);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(56, 13);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "Requester";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.Color.IndianRed;
            this.Label7.Location = new System.Drawing.Point(291, 138);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(50, 13);
            this.Label7.TabIndex = 28;
            this.Label7.Text = "Examiner";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.IndianRed;
            this.Label6.Location = new System.Drawing.Point(31, 83);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(26, 13);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "Firm";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BackColor = System.Drawing.Color.LightYellow;
            this.txtBarCode.Location = new System.Drawing.Point(578, 26);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(120, 20);
            this.txtBarCode.TabIndex = 26;
            this.txtBarCode.TextChanged += new System.EventHandler(this.txtBarCode_TextChanged);
            // 
            // txtItemNum
            // 
            this.txtItemNum.BackColor = System.Drawing.Color.LightYellow;
            this.txtItemNum.Location = new System.Drawing.Point(347, 26);
            this.txtItemNum.Name = "txtItemNum";
            this.txtItemNum.Size = new System.Drawing.Size(121, 20);
            this.txtItemNum.TabIndex = 25;
            this.txtItemNum.TextChanged += new System.EventHandler(this.txtItemNum_TextChanged);
            // 
            // txtCaseNum
            // 
            this.txtCaseNum.BackColor = System.Drawing.Color.LightYellow;
            this.txtCaseNum.Location = new System.Drawing.Point(63, 26);
            this.txtCaseNum.Name = "txtCaseNum";
            this.txtCaseNum.Size = new System.Drawing.Size(121, 20);
            this.txtCaseNum.TabIndex = 24;
            this.txtCaseNum.TextChanged += new System.EventHandler(this.txtCaseNum_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.Color.IndianRed;
            this.Label5.Location = new System.Drawing.Point(522, 32);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(50, 13);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Bar code";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.Color.IndianRed;
            this.Label4.Location = new System.Drawing.Point(304, 32);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(37, 13);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Item #";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.IndianRed;
            this.Label3.Location = new System.Drawing.Point(16, 32);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 13);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Case #";
            // 
            // CustomerandCaseInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 239);
            this.Controls.Add(this.txtInitialsMidCon);
            this.Controls.Add(this.Label67);
            this.Controls.Add(this.dtpMidCon);
            this.Controls.Add(this.dtpStartTime_NeedsChange);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtMatter);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.cmbboxRequester);
            this.Controls.Add(this.cmbboxExaminer);
            this.Controls.Add(this.cmbboxFirm);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.txtItemNum);
            this.Controls.Add(this.txtCaseNum);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Name = "CustomerandCaseInformation";
            this.Text = "CustomerandCaseInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtInitialsMidCon;
        internal System.Windows.Forms.Label Label67;
        internal System.Windows.Forms.DateTimePicker dtpMidCon;
        internal System.Windows.Forms.DateTimePicker dtpStartTime_NeedsChange;
        internal System.Windows.Forms.DateTimePicker dtpStartDate;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtMatter;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox cmbboxRequester;
        internal System.Windows.Forms.ComboBox cmbboxExaminer;
        internal System.Windows.Forms.ComboBox cmbboxFirm;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtBarCode;
        internal System.Windows.Forms.TextBox txtItemNum;
        internal System.Windows.Forms.TextBox txtCaseNum;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
    }
}
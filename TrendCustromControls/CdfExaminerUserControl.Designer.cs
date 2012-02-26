namespace TrendCustromControls
{
    partial class CdfExaminerUserControl
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbboxTechExaminar = new System.Windows.Forms.ComboBox();
            this.Label43 = new System.Windows.Forms.Label();
            this.dtpFinishDateTime = new System.Windows.Forms.DateTimePicker();
            this.Label48 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbboxTechExaminar);
            this.groupBox5.Controls.Add(this.Label43);
            this.groupBox5.Controls.Add(this.dtpFinishDateTime);
            this.groupBox5.Controls.Add(this.Label48);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(532, 46);
            this.groupBox5.TabIndex = 142;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CDF Info";
            // 
            // cmbboxTechExaminar
            // 
            this.cmbboxTechExaminar.BackColor = System.Drawing.Color.White;
            this.cmbboxTechExaminar.FormattingEnabled = true;
            this.cmbboxTechExaminar.Items.AddRange(new object[] {
            "Patrick",
            "Dee",
            "Gary",
            "Mike",
            "Neil",
            "Dennis",
            "Calvin"});
            this.cmbboxTechExaminar.Location = new System.Drawing.Point(114, 18);
            this.cmbboxTechExaminar.Name = "cmbboxTechExaminar";
            this.cmbboxTechExaminar.Size = new System.Drawing.Size(153, 21);
            this.cmbboxTechExaminar.TabIndex = 77;
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.ForeColor = System.Drawing.Color.IndianRed;
            this.Label43.Location = new System.Drawing.Point(12, 22);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(85, 13);
            this.Label43.TabIndex = 76;
            this.Label43.Text = "Tech/examinar: ";
            // 
            // dtpFinishDateTime
            // 
            this.dtpFinishDateTime.CustomFormat = "MM/dd/yyyy; hh:mm:ss";
            this.dtpFinishDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinishDateTime.Location = new System.Drawing.Point(370, 18);
            this.dtpFinishDateTime.Name = "dtpFinishDateTime";
            this.dtpFinishDateTime.Size = new System.Drawing.Size(153, 20);
            this.dtpFinishDateTime.TabIndex = 79;
            // 
            // Label48
            // 
            this.Label48.AutoSize = true;
            this.Label48.ForeColor = System.Drawing.Color.IndianRed;
            this.Label48.Location = new System.Drawing.Point(279, 22);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(85, 13);
            this.Label48.TabIndex = 78;
            this.Label48.Text = "Finish date/time:";
            // 
            // CdfExaminerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Name = "CdfExaminerUserControl";
            this.Size = new System.Drawing.Size(546, 58);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.ComboBox cmbboxTechExaminar;
        internal System.Windows.Forms.Label Label43;
        internal System.Windows.Forms.DateTimePicker dtpFinishDateTime;
        internal System.Windows.Forms.Label Label48;



    }
}

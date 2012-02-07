namespace TrendWinForm
{
    partial class NotesandConclusions
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
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbboxTechExaminar = new System.Windows.Forms.ComboBox();
            this.Label43 = new System.Windows.Forms.Label();
            this.dtpFinishDateTime = new System.Windows.Forms.DateTimePicker();
            this.Label48 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.Color.LightYellow;
            this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox2.Location = new System.Drawing.Point(25, 140);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(665, 127);
            this.TextBox2.TabIndex = 15;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.Color.IndianRed;
            this.Label2.Location = new System.Drawing.Point(12, 124);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Notes: ";
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.LightYellow;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Location = new System.Drawing.Point(25, 25);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(666, 78);
            this.TextBox1.TabIndex = 13;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.IndianRed;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 13);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Active user files: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbboxTechExaminar);
            this.groupBox5.Controls.Add(this.Label43);
            this.groupBox5.Controls.Add(this.dtpFinishDateTime);
            this.groupBox5.Controls.Add(this.Label48);
            this.groupBox5.Location = new System.Drawing.Point(25, 302);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(543, 64);
            this.groupBox5.TabIndex = 132;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CDF Info";
            // 
            // cmbboxTechExaminar
            // 
            this.cmbboxTechExaminar.BackColor = System.Drawing.Color.LightYellow;
            this.cmbboxTechExaminar.FormattingEnabled = true;
            this.cmbboxTechExaminar.Items.AddRange(new object[] {
            "Patrick",
            "Dee",
            "Gary",
            "Mike",
            "Neil",
            "Dennis",
            "Calvin"});
            this.cmbboxTechExaminar.Location = new System.Drawing.Point(114, 25);
            this.cmbboxTechExaminar.Name = "cmbboxTechExaminar";
            this.cmbboxTechExaminar.Size = new System.Drawing.Size(153, 21);
            this.cmbboxTechExaminar.TabIndex = 77;
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.ForeColor = System.Drawing.Color.IndianRed;
            this.Label43.Location = new System.Drawing.Point(12, 31);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(85, 13);
            this.Label43.TabIndex = 76;
            this.Label43.Text = "Tech/examinar: ";
            // 
            // dtpFinishDateTime
            // 
            this.dtpFinishDateTime.CustomFormat = "MM/dd/yyyy; hh:mm:ss";
            this.dtpFinishDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinishDateTime.Location = new System.Drawing.Point(370, 31);
            this.dtpFinishDateTime.Name = "dtpFinishDateTime";
            this.dtpFinishDateTime.Size = new System.Drawing.Size(153, 20);
            this.dtpFinishDateTime.TabIndex = 79;
            // 
            // Label48
            // 
            this.Label48.AutoSize = true;
            this.Label48.ForeColor = System.Drawing.Color.IndianRed;
            this.Label48.Location = new System.Drawing.Point(279, 31);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(85, 13);
            this.Label48.TabIndex = 78;
            this.Label48.Text = "Finish date/time:";
            // 
            // NotesandConclusions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 388);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Name = "NotesandConclusions";
            this.Text = "NotesandConclusions";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.ComboBox cmbboxTechExaminar;
        internal System.Windows.Forms.Label Label43;
        internal System.Windows.Forms.DateTimePicker dtpFinishDateTime;
        internal System.Windows.Forms.Label Label48;
    }
}
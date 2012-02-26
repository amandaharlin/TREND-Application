namespace TrendWinForm
{
    partial class Create_ActiveUserFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_ActiveUserFile));
            this.panel11 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAUFCPUUsage = new System.Windows.Forms.TextBox();
            this.labelAUFCPUUsage = new System.Windows.Forms.Label();
            this.comboBoxAUFReferenceComputer = new System.Windows.Forms.ComboBox();
            this.textBoxAUFMemoryUsage = new System.Windows.Forms.TextBox();
            this.labelAUFMemoryUsage = new System.Windows.Forms.Label();
            this.textBoxAUFDescription = new System.Windows.Forms.TextBox();
            this.labelAUFDescription = new System.Windows.Forms.Label();
            this.textBoxAUFFileName = new System.Windows.Forms.TextBox();
            this.labelAUFFileName = new System.Windows.Forms.Label();
            this.labelReferenceComputer = new System.Windows.Forms.Label();
            this.labelCreateActiveUserFile = new System.Windows.Forms.Label();
            this.trackBarMemoryUsage = new System.Windows.Forms.TrackBar();
            this.trackBarCpuUsage = new System.Windows.Forms.TrackBar();
            this.panel14 = new System.Windows.Forms.Panel();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.comboBoxCdfInfoTech = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCDFDate = new System.Windows.Forms.DateTimePicker();
            this.labelCDFFinishDateTime = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.labelCdfInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMemoryUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCpuUsage)).BeginInit();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.textBoxAUFCPUUsage);
            this.panel11.Controls.Add(this.labelAUFCPUUsage);
            this.panel11.Controls.Add(this.comboBoxAUFReferenceComputer);
            this.panel11.Controls.Add(this.textBoxAUFMemoryUsage);
            this.panel11.Controls.Add(this.labelAUFMemoryUsage);
            this.panel11.Controls.Add(this.textBoxAUFDescription);
            this.panel11.Controls.Add(this.labelAUFDescription);
            this.panel11.Controls.Add(this.textBoxAUFFileName);
            this.panel11.Controls.Add(this.labelAUFFileName);
            this.panel11.Controls.Add(this.labelReferenceComputer);
            this.panel11.Controls.Add(this.labelCreateActiveUserFile);
            this.panel11.Controls.Add(this.trackBarMemoryUsage);
            this.panel11.Controls.Add(this.trackBarCpuUsage);
            this.panel11.Location = new System.Drawing.Point(2, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(573, 193);
            this.panel11.TabIndex = 209;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 215;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 214;
            this.label1.Text = "%";
            // 
            // textBoxAUFCPUUsage
            // 
            this.textBoxAUFCPUUsage.Location = new System.Drawing.Point(498, 168);
            this.textBoxAUFCPUUsage.MaxLength = 4;
            this.textBoxAUFCPUUsage.Name = "textBoxAUFCPUUsage";
            this.textBoxAUFCPUUsage.Size = new System.Drawing.Size(34, 20);
            this.textBoxAUFCPUUsage.TabIndex = 213;
            this.textBoxAUFCPUUsage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAUFCPUUsage_KeyPress);
            // 
            // labelAUFCPUUsage
            // 
            this.labelAUFCPUUsage.AutoSize = true;
            this.labelAUFCPUUsage.Location = new System.Drawing.Point(319, 170);
            this.labelAUFCPUUsage.Name = "labelAUFCPUUsage";
            this.labelAUFCPUUsage.Size = new System.Drawing.Size(63, 13);
            this.labelAUFCPUUsage.TabIndex = 212;
            this.labelAUFCPUUsage.Text = "CPU Usage";
            // 
            // comboBoxAUFReferenceComputer
            // 
            this.comboBoxAUFReferenceComputer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAUFReferenceComputer.FormattingEnabled = true;
            this.comboBoxAUFReferenceComputer.Location = new System.Drawing.Point(116, 27);
            this.comboBoxAUFReferenceComputer.Name = "comboBoxAUFReferenceComputer";
            this.comboBoxAUFReferenceComputer.Size = new System.Drawing.Size(427, 21);
            this.comboBoxAUFReferenceComputer.TabIndex = 211;
            this.comboBoxAUFReferenceComputer.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxAUFReferenceComputer_Validating);
            // 
            // textBoxAUFMemoryUsage
            // 
            this.textBoxAUFMemoryUsage.Location = new System.Drawing.Point(213, 170);
            this.textBoxAUFMemoryUsage.MaxLength = 4;
            this.textBoxAUFMemoryUsage.Name = "textBoxAUFMemoryUsage";
            this.textBoxAUFMemoryUsage.Size = new System.Drawing.Size(39, 20);
            this.textBoxAUFMemoryUsage.TabIndex = 206;
            this.textBoxAUFMemoryUsage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAUFMemoryUsage_KeyPress);
            // 
            // labelAUFMemoryUsage
            // 
            this.labelAUFMemoryUsage.AutoSize = true;
            this.labelAUFMemoryUsage.Location = new System.Drawing.Point(8, 170);
            this.labelAUFMemoryUsage.Name = "labelAUFMemoryUsage";
            this.labelAUFMemoryUsage.Size = new System.Drawing.Size(78, 13);
            this.labelAUFMemoryUsage.TabIndex = 205;
            this.labelAUFMemoryUsage.Text = "Memory Usage";
            // 
            // textBoxAUFDescription
            // 
            this.textBoxAUFDescription.Location = new System.Drawing.Point(116, 78);
            this.textBoxAUFDescription.MaxLength = 9990;
            this.textBoxAUFDescription.Multiline = true;
            this.textBoxAUFDescription.Name = "textBoxAUFDescription";
            this.textBoxAUFDescription.Size = new System.Drawing.Size(427, 82);
            this.textBoxAUFDescription.TabIndex = 204;
            // 
            // labelAUFDescription
            // 
            this.labelAUFDescription.AutoSize = true;
            this.labelAUFDescription.Location = new System.Drawing.Point(8, 78);
            this.labelAUFDescription.Name = "labelAUFDescription";
            this.labelAUFDescription.Size = new System.Drawing.Size(60, 13);
            this.labelAUFDescription.TabIndex = 203;
            this.labelAUFDescription.Text = "Description";
            // 
            // textBoxAUFFileName
            // 
            this.textBoxAUFFileName.Location = new System.Drawing.Point(116, 53);
            this.textBoxAUFFileName.MaxLength = 250;
            this.textBoxAUFFileName.Name = "textBoxAUFFileName";
            this.textBoxAUFFileName.Size = new System.Drawing.Size(427, 20);
            this.textBoxAUFFileName.TabIndex = 202;
            this.textBoxAUFFileName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAUFFileName_Validating);
            // 
            // labelAUFFileName
            // 
            this.labelAUFFileName.AutoSize = true;
            this.labelAUFFileName.Location = new System.Drawing.Point(8, 57);
            this.labelAUFFileName.Name = "labelAUFFileName";
            this.labelAUFFileName.Size = new System.Drawing.Size(77, 13);
            this.labelAUFFileName.TabIndex = 201;
            this.labelAUFFileName.Text = "Program Name";
            // 
            // labelReferenceComputer
            // 
            this.labelReferenceComputer.AutoSize = true;
            this.labelReferenceComputer.Location = new System.Drawing.Point(8, 30);
            this.labelReferenceComputer.Name = "labelReferenceComputer";
            this.labelReferenceComputer.Size = new System.Drawing.Size(105, 13);
            this.labelReferenceComputer.TabIndex = 199;
            this.labelReferenceComputer.Text = "Reference Computer";
            // 
            // labelCreateActiveUserFile
            // 
            this.labelCreateActiveUserFile.AutoSize = true;
            this.labelCreateActiveUserFile.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateActiveUserFile.Location = new System.Drawing.Point(3, 4);
            this.labelCreateActiveUserFile.Name = "labelCreateActiveUserFile";
            this.labelCreateActiveUserFile.Size = new System.Drawing.Size(197, 24);
            this.labelCreateActiveUserFile.TabIndex = 198;
            this.labelCreateActiveUserFile.Text = "Create Active User File";
            // 
            // trackBarMemoryUsage
            // 
            this.trackBarMemoryUsage.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarMemoryUsage.Location = new System.Drawing.Point(101, 165);
            this.trackBarMemoryUsage.Maximum = 1000;
            this.trackBarMemoryUsage.Name = "trackBarMemoryUsage";
            this.trackBarMemoryUsage.Size = new System.Drawing.Size(106, 45);
            this.trackBarMemoryUsage.TabIndex = 216;
            this.trackBarMemoryUsage.ValueChanged += new System.EventHandler(this.trackBarMemoryUsage_ValueChanged);
            // 
            // trackBarCpuUsage
            // 
            this.trackBarCpuUsage.Location = new System.Drawing.Point(388, 165);
            this.trackBarCpuUsage.Maximum = 1000;
            this.trackBarCpuUsage.Name = "trackBarCpuUsage";
            this.trackBarCpuUsage.Size = new System.Drawing.Size(104, 45);
            this.trackBarCpuUsage.TabIndex = 217;
            this.trackBarCpuUsage.ValueChanged += new System.EventHandler(this.trackBarCpuUsage_ValueChanged);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.AddEmployee);
            this.panel14.Controls.Add(this.comboBoxCdfInfoTech);
            this.panel14.Controls.Add(this.dateTimePickerCDFDate);
            this.panel14.Controls.Add(this.labelCDFFinishDateTime);
            this.panel14.Controls.Add(this.label41);
            this.panel14.Controls.Add(this.labelCdfInfo);
            this.panel14.Location = new System.Drawing.Point(5, 203);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(570, 56);
            this.panel14.TabIndex = 211;
            // 
            // AddEmployee
            // 
            this.AddEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddEmployee.BackgroundImage")));
            this.AddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddEmployee.Location = new System.Drawing.Point(246, 30);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(24, 24);
            this.AddEmployee.TabIndex = 201;
            this.AddEmployee.UseVisualStyleBackColor = true;
            // 
            // comboBoxCdfInfoTech
            // 
            this.comboBoxCdfInfoTech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCdfInfoTech.FormattingEnabled = true;
            this.comboBoxCdfInfoTech.Location = new System.Drawing.Point(91, 32);
            this.comboBoxCdfInfoTech.Name = "comboBoxCdfInfoTech";
            this.comboBoxCdfInfoTech.Size = new System.Drawing.Size(152, 21);
            this.comboBoxCdfInfoTech.TabIndex = 200;
            // 
            // dateTimePickerCDFDate
            // 
            this.dateTimePickerCDFDate.Location = new System.Drawing.Point(369, 32);
            this.dateTimePickerCDFDate.Name = "dateTimePickerCDFDate";
            this.dateTimePickerCDFDate.Size = new System.Drawing.Size(198, 20);
            this.dateTimePickerCDFDate.TabIndex = 198;
            // 
            // labelCDFFinishDateTime
            // 
            this.labelCDFFinishDateTime.AutoSize = true;
            this.labelCDFFinishDateTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCDFFinishDateTime.Location = new System.Drawing.Point(278, 36);
            this.labelCDFFinishDateTime.Name = "labelCDFFinishDateTime";
            this.labelCDFFinishDateTime.Size = new System.Drawing.Size(88, 13);
            this.labelCDFFinishDateTime.TabIndex = 197;
            this.labelCDFFinishDateTime.Text = "Finish Date/Time";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label41.Location = new System.Drawing.Point(2, 36);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(83, 13);
            this.label41.TabIndex = 196;
            this.label41.Text = "Tech/ Examiner";
            // 
            // labelCdfInfo
            // 
            this.labelCdfInfo.AutoSize = true;
            this.labelCdfInfo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCdfInfo.Location = new System.Drawing.Point(3, 11);
            this.labelCdfInfo.Name = "labelCdfInfo";
            this.labelCdfInfo.Size = new System.Drawing.Size(76, 24);
            this.labelCdfInfo.TabIndex = 199;
            this.labelCdfInfo.Text = "Cdf Info";
            // 
            // Create_ActiveUserFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 301);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel11);
            this.Name = "Create_ActiveUserFile";
            this.Text = "Create_ActiveUserFile";
            this.Shown += new System.EventHandler(this.Create_ActiveUserFile_Shown);
            this.Controls.SetChildIndex(this.panel11, 0);
            this.Controls.SetChildIndex(this.panel14, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMemoryUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCpuUsage)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox comboBoxAUFReferenceComputer;
        private System.Windows.Forms.TextBox textBoxAUFMemoryUsage;
        private System.Windows.Forms.Label labelAUFMemoryUsage;
        private System.Windows.Forms.TextBox textBoxAUFDescription;
        private System.Windows.Forms.Label labelAUFDescription;
        private System.Windows.Forms.TextBox textBoxAUFFileName;
        private System.Windows.Forms.Label labelAUFFileName;
        private System.Windows.Forms.Label labelReferenceComputer;
        private System.Windows.Forms.Label labelCreateActiveUserFile;
        private System.Windows.Forms.TextBox textBoxAUFCPUUsage;
        private System.Windows.Forms.Label labelAUFCPUUsage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.ComboBox comboBoxCdfInfoTech;
        private System.Windows.Forms.DateTimePicker dateTimePickerCDFDate;
        internal System.Windows.Forms.Label labelCDFFinishDateTime;
        internal System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label labelCdfInfo;
        private System.Windows.Forms.TrackBar trackBarMemoryUsage;
        private System.Windows.Forms.TrackBar trackBarCpuUsage;

    }
}
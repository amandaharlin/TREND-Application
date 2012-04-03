namespace TrendWinForm
{
    partial class Create_Employee
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
            System.Windows.Forms.Label employeeNumberLabel;
            System.Windows.Forms.Label employeeTitleLabel;
            this.trendDataSet = new TrendWinForm.TrendDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new TrendWinForm.TrendDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new TrendWinForm.TrendDataSetTableAdapters.TableAdapterManager();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.employeeTitleTextBox = new System.Windows.Forms.TextBox();
            this.nameUserControl1 = new TrendCustromControls.NameUserControl();
            this.phoneUserControl1 = new TrendCustromControls.PhoneUserControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            employeeNumberLabel = new System.Windows.Forms.Label();
            employeeTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trendDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeNumberLabel
            // 
            employeeNumberLabel.AutoSize = true;
            employeeNumberLabel.Location = new System.Drawing.Point(7, 14);
            employeeNumberLabel.Name = "employeeNumberLabel";
            employeeNumberLabel.Size = new System.Drawing.Size(96, 13);
            employeeNumberLabel.TabIndex = 4;
            employeeNumberLabel.Text = "Employee Number:";
            // 
            // employeeTitleLabel
            // 
            employeeTitleLabel.AutoSize = true;
            employeeTitleLabel.Location = new System.Drawing.Point(7, 38);
            employeeTitleLabel.Name = "employeeTitleLabel";
            employeeTitleLabel.Size = new System.Drawing.Size(79, 13);
            employeeTitleLabel.TabIndex = 20;
            employeeTitleLabel.Text = "Employee Title:";
            // 
            // trendDataSet
            // 
            this.trendDataSet.DataSetName = "TrendDataSet";
            this.trendDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.trendDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CaseTableAdapter = null;
            this.tableAdapterManager.CdfInfoTableAdapter = null;
            this.tableAdapterManager.ComputerTableAdapter = null;
            this.tableAdapterManager.DestinationMediaTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.FirmContactTableAdapter = null;
            this.tableAdapterManager.FirmTableAdapter = null;
            this.tableAdapterManager.ForensicProcessTableAdapter = null;
            this.tableAdapterManager.HardDriveTableAdapter = null;
            this.tableAdapterManager.NotesAndConclusionTableAdapter = null;
            this.tableAdapterManager.RaidTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrendWinForm.TrendDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeNumber", true));
            this.employeeNumberTextBox.Location = new System.Drawing.Point(126, 11);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.ReadOnly = true;
            this.employeeNumberTextBox.Size = new System.Drawing.Size(444, 20);
            this.employeeNumberTextBox.TabIndex = 5;
            // 
            // employeeTitleTextBox
            // 
            this.employeeTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeTitle", true));
            this.employeeTitleTextBox.Location = new System.Drawing.Point(126, 35);
            this.employeeTitleTextBox.Name = "employeeTitleTextBox";
            this.employeeTitleTextBox.Size = new System.Drawing.Size(444, 20);
            this.employeeTitleTextBox.TabIndex = 6;
            // 
            // nameUserControl1
            // 
            this.nameUserControl1.FirstName = "";
            this.nameUserControl1.LastName = "";
            this.nameUserControl1.Location = new System.Drawing.Point(209, 61);
            this.nameUserControl1.MiddleNameorInitial = "";
            this.nameUserControl1.Name = "nameUserControl1";
            this.nameUserControl1.Size = new System.Drawing.Size(361, 119);
            this.nameUserControl1.TabIndex = 7;
            // 
            // phoneUserControl1
            // 
            this.phoneUserControl1.AreaCode = 0;
            this.phoneUserControl1.Extension = "";
            this.phoneUserControl1.Location = new System.Drawing.Point(212, 186);
            this.phoneUserControl1.Name = "phoneUserControl1";
            //this.phoneUserControl1.Number = 0;
            this.phoneUserControl1.Size = new System.Drawing.Size(358, 91);
            this.phoneUserControl1.TabIndex = 8;
            this.phoneUserControl1.Type = "Mobile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrendWinForm.Properties.Resources.anon_user;
            this.pictureBox1.Location = new System.Drawing.Point(13, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 202);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Create_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 318);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.phoneUserControl1);
            this.Controls.Add(this.nameUserControl1);
            this.Controls.Add(employeeNumberLabel);
            this.Controls.Add(this.employeeNumberTextBox);
            this.Controls.Add(employeeTitleLabel);
            this.Controls.Add(this.employeeTitleTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Create_Employee";
            this.Text = "Create_Employee";
            this.Load += new System.EventHandler(this.Create_Employee_Load);
            this.Controls.SetChildIndex(this.employeeTitleTextBox, 0);
            this.Controls.SetChildIndex(employeeTitleLabel, 0);
            this.Controls.SetChildIndex(this.employeeNumberTextBox, 0);
            this.Controls.SetChildIndex(employeeNumberLabel, 0);
            this.Controls.SetChildIndex(this.nameUserControl1, 0);
            this.Controls.SetChildIndex(this.phoneUserControl1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.trendDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrendDataSet trendDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private TrendDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private TrendDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private System.Windows.Forms.TextBox employeeTitleTextBox;
        private TrendCustromControls.NameUserControl nameUserControl1;
        private TrendCustromControls.PhoneUserControl phoneUserControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace TrendWinForm
{
    partial class Create_FirmContact
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
            System.Windows.Forms.Label firm_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_FirmContact));
            this.trendDataSet = new TrendWinForm.TrendDataSet();
            this.firmContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmContactTableAdapter = new TrendWinForm.TrendDataSetTableAdapters.FirmContactTableAdapter();
            this.tableAdapterManager = new TrendWinForm.TrendDataSetTableAdapters.TableAdapterManager();
            this.AddFirm = new System.Windows.Forms.Button();
            this.nameUserControl1 = new TrendCustromControls.NameUserControl();
            this.phoneUserControl1 = new TrendCustromControls.PhoneUserControl();
            this.groupBoxSelectedfirmDetails = new System.Windows.Forms.GroupBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet2 = new System.Windows.Forms.TextBox();
            this.textBoxStreet1 = new System.Windows.Forms.TextBox();
            this.notes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.positionTextbox = new System.Windows.Forms.TextBox();
            this.notesTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmTableAdapter = new TrendWinForm.TrendDataSetTableAdapters.FirmTableAdapter();
            this.firm_idComboBox = new System.Windows.Forms.ComboBox();
            firm_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmContactBindingSource)).BeginInit();
            this.groupBoxSelectedfirmDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firm_idLabel
            // 
            firm_idLabel.AutoSize = true;
            firm_idLabel.Location = new System.Drawing.Point(11, 20);
            firm_idLabel.Name = "firm_idLabel";
            firm_idLabel.Size = new System.Drawing.Size(26, 13);
            firm_idLabel.TabIndex = 4;
            firm_idLabel.Text = "Firm";
            // 
            // trendDataSet
            // 
            this.trendDataSet.DataSetName = "TrendDataSet";
            this.trendDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmContactBindingSource
            // 
            this.firmContactBindingSource.DataMember = "FirmContact";
            this.firmContactBindingSource.DataSource = this.trendDataSet;
            // 
            // firmContactTableAdapter
            // 
            this.firmContactTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CaseTableAdapter = null;
            this.tableAdapterManager.CdfInfoTableAdapter = null;
            this.tableAdapterManager.ComputerTableAdapter = null;
            this.tableAdapterManager.DestinationMediaTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FirmContactTableAdapter = this.firmContactTableAdapter;
            this.tableAdapterManager.FirmTableAdapter = null;
            this.tableAdapterManager.ForensicProcessTableAdapter = null;
            this.tableAdapterManager.HardDriveTableAdapter = null;
            this.tableAdapterManager.NotesAndConclusionTableAdapter = null;
            this.tableAdapterManager.RaidTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrendWinForm.TrendDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AddFirm
            // 
            this.AddFirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFirm.BackgroundImage")));
            this.AddFirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddFirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddFirm.Location = new System.Drawing.Point(552, 17);
            this.AddFirm.Name = "AddFirm";
            this.AddFirm.Size = new System.Drawing.Size(24, 24);
            this.AddFirm.TabIndex = 6;
            this.AddFirm.UseVisualStyleBackColor = true;
            this.AddFirm.Click += new System.EventHandler(this.AddFirm_Click);
            // 
            // nameUserControl1
            // 
            this.nameUserControl1.FirstName = "";
            this.nameUserControl1.LastName = "";
            this.nameUserControl1.Location = new System.Drawing.Point(215, 47);
            this.nameUserControl1.MiddleNameorInitial = "";
            this.nameUserControl1.Name = "nameUserControl1";
            this.nameUserControl1.Size = new System.Drawing.Size(361, 119);
            this.nameUserControl1.TabIndex = 8;
            // 
            // phoneUserControl1
            // 
            this.phoneUserControl1.AreaCode = 0;
            this.phoneUserControl1.Extension = "";
            this.phoneUserControl1.Location = new System.Drawing.Point(221, 172);
            this.phoneUserControl1.Name = "phoneUserControl1";
            //this.phoneUserControl1.Number = 0;
            this.phoneUserControl1.Size = new System.Drawing.Size(358, 91);
            this.phoneUserControl1.TabIndex = 9;
            this.phoneUserControl1.Type = "Mobile";
            // 
            // groupBoxSelectedfirmDetails
            // 
            this.groupBoxSelectedfirmDetails.Controls.Add(this.textBoxNotes);
            this.groupBoxSelectedfirmDetails.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxSelectedfirmDetails.Controls.Add(this.textBoxZipCode);
            this.groupBoxSelectedfirmDetails.Controls.Add(this.textBoxState);
            this.groupBoxSelectedfirmDetails.Controls.Add(this.textBoxCity);
            this.groupBoxSelectedfirmDetails.Controls.Add(this.textBoxStreet2);
            this.groupBoxSelectedfirmDetails.Controls.Add(this.textBoxStreet1);
            this.groupBoxSelectedfirmDetails.Controls.Add(this.notes);
            this.groupBoxSelectedfirmDetails.Location = new System.Drawing.Point(13, 52);
            this.groupBoxSelectedfirmDetails.Name = "groupBoxSelectedfirmDetails";
            this.groupBoxSelectedfirmDetails.Size = new System.Drawing.Size(196, 211);
            this.groupBoxSelectedfirmDetails.TabIndex = 33;
            this.groupBoxSelectedfirmDetails.TabStop = false;
            this.groupBoxSelectedfirmDetails.Text = "Firm Details";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxNotes.Location = new System.Drawing.Point(6, 156);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ReadOnly = true;
            this.textBoxNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNotes.Size = new System.Drawing.Size(178, 49);
            this.textBoxNotes.TabIndex = 13;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(5, 117);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.ReadOnly = true;
            this.textBoxPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 12;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxZipCode.Location = new System.Drawing.Point(149, 91);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.ReadOnly = true;
            this.textBoxZipCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxZipCode.Size = new System.Drawing.Size(47, 20);
            this.textBoxZipCode.TabIndex = 11;
            // 
            // textBoxState
            // 
            this.textBoxState.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxState.Location = new System.Drawing.Point(6, 91);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ReadOnly = true;
            this.textBoxState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxState.Size = new System.Drawing.Size(137, 20);
            this.textBoxState.TabIndex = 10;
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxCity.Location = new System.Drawing.Point(6, 71);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.ReadOnly = true;
            this.textBoxCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCity.Size = new System.Drawing.Size(137, 20);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxStreet2
            // 
            this.textBoxStreet2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxStreet2.Location = new System.Drawing.Point(6, 51);
            this.textBoxStreet2.Name = "textBoxStreet2";
            this.textBoxStreet2.ReadOnly = true;
            this.textBoxStreet2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxStreet2.Size = new System.Drawing.Size(184, 20);
            this.textBoxStreet2.TabIndex = 8;
            // 
            // textBoxStreet1
            // 
            this.textBoxStreet1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxStreet1.Location = new System.Drawing.Point(6, 31);
            this.textBoxStreet1.Name = "textBoxStreet1";
            this.textBoxStreet1.ReadOnly = true;
            this.textBoxStreet1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxStreet1.Size = new System.Drawing.Size(184, 20);
            this.textBoxStreet1.TabIndex = 7;
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Location = new System.Drawing.Point(9, 140);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(33, 13);
            this.notes.TabIndex = 6;
            this.notes.Text = "notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Position at Firm";
            // 
            // positionTextbox
            // 
            this.positionTextbox.Location = new System.Drawing.Point(109, 277);
            this.positionTextbox.Name = "positionTextbox";
            this.positionTextbox.Size = new System.Drawing.Size(483, 20);
            this.positionTextbox.TabIndex = 10;
            // 
            // notesTextbox
            // 
            this.notesTextbox.Location = new System.Drawing.Point(94, 307);
            this.notesTextbox.Multiline = true;
            this.notesTextbox.Name = "notesTextbox";
            this.notesTextbox.Size = new System.Drawing.Size(485, 89);
            this.notesTextbox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Notes";
            // 
            // firmBindingSource
            // 
            this.firmBindingSource.DataMember = "Firm";
            this.firmBindingSource.DataSource = this.trendDataSet;
            // 
            // firmTableAdapter
            // 
            this.firmTableAdapter.ClearBeforeFill = true;
            // 
            // firm_idComboBox
            // 
            this.firm_idComboBox.CausesValidation = false;
            this.firm_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmContactBindingSource, "Firm_id", true));
            this.firm_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firm_idComboBox.FormattingEnabled = true;
            this.firm_idComboBox.Location = new System.Drawing.Point(43, 19);
            this.firm_idComboBox.Name = "firm_idComboBox";
            this.firm_idComboBox.Size = new System.Drawing.Size(503, 21);
            this.firm_idComboBox.TabIndex = 5;
            this.firm_idComboBox.SelectionChangeCommitted += new System.EventHandler(this.firm_idComboBox_SelectionChangeCommitted);
            // 
            // Create_FirmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notesTextbox);
            this.Controls.Add(this.positionTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxSelectedfirmDetails);
            this.Controls.Add(this.phoneUserControl1);
            this.Controls.Add(this.nameUserControl1);
            this.Controls.Add(this.AddFirm);
            this.Controls.Add(firm_idLabel);
            this.Controls.Add(this.firm_idComboBox);
            this.Name = "Create_FirmContact";
            this.Text = "Create_FirmContact";
            this.Load += new System.EventHandler(this.Create_FirmContact_Load);
            this.Shown += new System.EventHandler(this.Create_FirmContact_Shown);
            this.Controls.SetChildIndex(this.firm_idComboBox, 0);
            this.Controls.SetChildIndex(firm_idLabel, 0);
            this.Controls.SetChildIndex(this.AddFirm, 0);
            this.Controls.SetChildIndex(this.nameUserControl1, 0);
            this.Controls.SetChildIndex(this.phoneUserControl1, 0);
            this.Controls.SetChildIndex(this.groupBoxSelectedfirmDetails, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.positionTextbox, 0);
            this.Controls.SetChildIndex(this.notesTextbox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmContactBindingSource)).EndInit();
            this.groupBoxSelectedfirmDetails.ResumeLayout(false);
            this.groupBoxSelectedfirmDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrendDataSet trendDataSet;
        private System.Windows.Forms.BindingSource firmContactBindingSource;
        private TrendDataSetTableAdapters.FirmContactTableAdapter firmContactTableAdapter;
        private TrendDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button AddFirm;
        private TrendCustromControls.NameUserControl nameUserControl1;
        private TrendCustromControls.PhoneUserControl phoneUserControl1;
        private System.Windows.Forms.GroupBox groupBoxSelectedfirmDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox positionTextbox;
        private System.Windows.Forms.TextBox notesTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource firmBindingSource;
        private TrendDataSetTableAdapters.FirmTableAdapter firmTableAdapter;
        private System.Windows.Forms.Label notes;
        private System.Windows.Forms.ComboBox firm_idComboBox;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet2;
        private System.Windows.Forms.TextBox textBoxStreet1;
    }
}
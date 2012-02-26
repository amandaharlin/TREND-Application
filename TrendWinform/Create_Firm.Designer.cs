namespace TrendWinForm
{
    partial class Create_Firm
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
            System.Windows.Forms.Label firmNameLabel;
            System.Windows.Forms.Label firmDescriptionLabel;
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trendDataSet = new TrendWinForm.TrendDataSet();
            this.firmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmTableAdapter = new TrendWinForm.TrendDataSetTableAdapters.FirmTableAdapter();
            this.tableAdapterManager = new TrendWinForm.TrendDataSetTableAdapters.TableAdapterManager();
            this.firmNameTextBox = new System.Windows.Forms.TextBox();
            this.firmDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addressUserControlFirm = new TrendCustromControls.AddressUserControl();
            this.phoneUserControlFirm = new TrendCustromControls.PhoneUserControl();
            this.firmContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmContactTableAdapter = new TrendWinForm.TrendDataSetTableAdapters.FirmContactTableAdapter();
            firmNameLabel = new System.Windows.Forms.Label();
            firmDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trendDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmContactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firmNameLabel
            // 
            firmNameLabel.AutoSize = true;
            firmNameLabel.Location = new System.Drawing.Point(9, 18);
            firmNameLabel.Name = "firmNameLabel";
            firmNameLabel.Size = new System.Drawing.Size(60, 13);
            firmNameLabel.TabIndex = 4;
            firmNameLabel.Text = "Firm Name:";
            // 
            // firmDescriptionLabel
            // 
            firmDescriptionLabel.AutoSize = true;
            firmDescriptionLabel.Location = new System.Drawing.Point(363, 184);
            firmDescriptionLabel.Name = "firmDescriptionLabel";
            firmDescriptionLabel.Size = new System.Drawing.Size(85, 13);
            firmDescriptionLabel.TabIndex = 24;
            firmDescriptionLabel.Text = "Firm Description:";
            // 
            // trendDataSet
            // 
            this.trendDataSet.DataSetName = "TrendDataSet";
            this.trendDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CaseTableAdapter = null;
            this.tableAdapterManager.CdfInfoTableAdapter = null;
            this.tableAdapterManager.ComputerTableAdapter = null;
            this.tableAdapterManager.DestinationMediaTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FirmContactTableAdapter = null;
            this.tableAdapterManager.FirmTableAdapter = this.firmTableAdapter;
            this.tableAdapterManager.ForensicProcessTableAdapter = null;
            this.tableAdapterManager.HardDriveTableAdapter = null;
            this.tableAdapterManager.NotesAndConclusionTableAdapter = null;
            this.tableAdapterManager.RaidTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrendWinForm.TrendDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // firmNameTextBox
            // 
            this.firmNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmBindingSource, "FirmName", true));
            this.firmNameTextBox.Location = new System.Drawing.Point(74, 15);
            this.firmNameTextBox.Name = "firmNameTextBox";
            this.firmNameTextBox.Size = new System.Drawing.Size(470, 20);
            this.firmNameTextBox.TabIndex = 5;
            // 
            // firmDescriptionRichTextBox
            // 
            this.firmDescriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firmBindingSource, "FirmDescription", true));
            this.firmDescriptionRichTextBox.Location = new System.Drawing.Point(358, 200);
            this.firmDescriptionRichTextBox.Name = "firmDescriptionRichTextBox";
            this.firmDescriptionRichTextBox.Size = new System.Drawing.Size(186, 64);
            this.firmDescriptionRichTextBox.TabIndex = 8;
            this.firmDescriptionRichTextBox.Text = "";
            // 
            // addressUserControlFirm
            // 
            this.addressUserControlFirm.City = "";
            this.addressUserControlFirm.Location = new System.Drawing.Point(19, 41);
            this.addressUserControlFirm.Name = "addressUserControlFirm";
            this.addressUserControlFirm.Size = new System.Drawing.Size(537, 139);
            this.addressUserControlFirm.State = "AL";
            this.addressUserControlFirm.StreetLine1 = "";
            this.addressUserControlFirm.StreetLine2 = "";
            this.addressUserControlFirm.TabIndex = 6;
            this.addressUserControlFirm.ZipCode = "";
            // 
            // phoneUserControlFirm
            // 
            this.phoneUserControlFirm.AreaCode = 0;
            this.phoneUserControlFirm.Extension = "";
            this.phoneUserControlFirm.Location = new System.Drawing.Point(5, 184);
            this.phoneUserControlFirm.Name = "phoneUserControlFirm";
           // this.phoneUserControlFirm.Number = 0;
            this.phoneUserControlFirm.Size = new System.Drawing.Size(358, 91);
            this.phoneUserControlFirm.TabIndex = 7;
            this.phoneUserControlFirm.Type = "Mobile";
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
            // Create_Firm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 321);
            this.Controls.Add(this.addressUserControlFirm);
            this.Controls.Add(firmNameLabel);
            this.Controls.Add(this.firmNameTextBox);
            this.Controls.Add(firmDescriptionLabel);
            this.Controls.Add(this.firmDescriptionRichTextBox);
            this.Controls.Add(this.phoneUserControlFirm);
            this.Name = "Create_Firm";
            this.Text = "Create_Firm";
            this.Load += new System.EventHandler(this.Create_Firm_Load);
            this.Controls.SetChildIndex(this.phoneUserControlFirm, 0);
            this.Controls.SetChildIndex(this.firmDescriptionRichTextBox, 0);
            this.Controls.SetChildIndex(firmDescriptionLabel, 0);
            this.Controls.SetChildIndex(this.firmNameTextBox, 0);
            this.Controls.SetChildIndex(firmNameLabel, 0);
            this.Controls.SetChildIndex(this.addressUserControlFirm, 0);
            ((System.ComponentModel.ISupportInitialize)(this.trendDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmContactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TrendDataSet trendDataSet;
        private System.Windows.Forms.BindingSource firmBindingSource;
        private TrendDataSetTableAdapters.FirmTableAdapter firmTableAdapter;
        private TrendDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox firmNameTextBox;
        private System.Windows.Forms.RichTextBox firmDescriptionRichTextBox;
        private TrendCustromControls.AddressUserControl addressUserControl;
        private TrendCustromControls.AddressUserControl addressUserControlFirm;
        private TrendCustromControls.PhoneUserControl phoneUserControlFirm;
        private System.Windows.Forms.BindingSource firmContactBindingSource;
        private TrendDataSetTableAdapters.FirmContactTableAdapter firmContactTableAdapter;
    }
}
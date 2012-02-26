namespace TrendWinForm
{
    partial class Create_Case
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
            System.Windows.Forms.Label itemNumberLabel;
            System.Windows.Forms.Label matterLabel;
            System.Windows.Forms.Label caseNumberLabel;
            System.Windows.Forms.Label barcodeDateVerifiedLabel;
            System.Windows.Forms.Label barcodeLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label firm_idLabel;
            System.Windows.Forms.Label requester_idLabel;
            System.Windows.Forms.Label examiner_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Case));
            this.caseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trendDataSet = new TrendWinForm.TrendDataSet();
            this.caseTableAdapter = new TrendWinForm.TrendDataSetTableAdapters.CaseTableAdapter();
            this.tableAdapterManager = new TrendWinForm.TrendDataSetTableAdapters.TableAdapterManager();
            this.itemNumberTextBox = new System.Windows.Forms.TextBox();
            this.matterTextBox = new System.Windows.Forms.TextBox();
            this.caseNumberTextBox = new System.Windows.Forms.TextBox();
            this.barcodeDateVerifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViewEmployee = new System.Windows.Forms.Button();
            this.ViewFirmContact = new System.Windows.Forms.Button();
            this.ViewFirm = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.AddFirmContact = new System.Windows.Forms.Button();
            this.AddFirm = new System.Windows.Forms.Button();
            this.examiner_idComboBox = new System.Windows.Forms.ComboBox();
            this.requester_idComboBox = new System.Windows.Forms.ComboBox();
            this.firm_idComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonViewDetailsComputerListView = new System.Windows.Forms.Button();
            this.buttonViewTileComputerListView = new System.Windows.Forms.Button();
            this.groupBoxHardDriveDetails = new System.Windows.Forms.GroupBox();
            this.listViewComputerAssociatedHardDrives = new System.Windows.Forms.ListView();
            this.groupBoxComputerDetails = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinishDateTime = new System.Windows.Forms.TextBox();
            this.txtTechExaminer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.txtHostedSystem = new System.Windows.Forms.TextBox();
            this.txtVirtualMachine = new System.Windows.Forms.TextBox();
            this.txtWasItAServer = new System.Windows.Forms.TextBox();
            this.txtServerType = new System.Windows.Forms.TextBox();
            this.Label40 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label38 = new System.Windows.Forms.Label();
            this.Label39 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.txtWasItPoweredOn = new System.Windows.Forms.TextBox();
            this.txtShutDownBy = new System.Windows.Forms.TextBox();
            this.txtAppsRunning = new System.Windows.Forms.TextBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.txtSystemRunning = new System.Windows.Forms.TextBox();
            this.txtPulledPlug = new System.Windows.Forms.TextBox();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtWasCMOSChanged = new System.Windows.Forms.TextBox();
            this.txtSetupKeystroke = new System.Windows.Forms.TextBox();
            this.txtTimeProvidedBy = new System.Windows.Forms.TextBox();
            this.txtActualTime = new System.Windows.Forms.TextBox();
            this.txtActualDate = new System.Windows.Forms.TextBox();
            this.txtCMOSTime = new System.Windows.Forms.TextBox();
            this.txtCMOSDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.txtCMOSChangesMade = new System.Windows.Forms.TextBox();
            this.Label32 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewAssociatedRaids = new System.Windows.Forms.ListView();
            this.labelComputerRaid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelType = new System.Windows.Forms.Label();
            this.txtTypeOutput = new System.Windows.Forms.TextBox();
            this.labelComputerInfo = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.txtSvcTag = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.txtSerialNum = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtModelOutput = new System.Windows.Forms.TextBox();
            this.txtMakeOutput = new System.Windows.Forms.TextBox();
            this.buttonDeleteComputer = new System.Windows.Forms.Button();
            this.buttonEditComputer = new System.Windows.Forms.Button();
            this.buttonViewComputer = new System.Windows.Forms.Button();
            this.buttonAddComputer = new System.Windows.Forms.Button();
            this.labelComputerList = new System.Windows.Forms.Label();
            this.listViewAssociatedComputerList = new System.Windows.Forms.ListView();
            this.groupBoxDriveDetails = new System.Windows.Forms.GroupBox();
            this.textBoxHDDetails_Interface = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBoxHDDetails_Serial = new System.Windows.Forms.TextBox();
            this.textBoxHDDetails_Model = new System.Windows.Forms.TextBox();
            this.textBoxHDDetails_Make = new System.Windows.Forms.TextBox();
            this.labelHDMake = new System.Windows.Forms.Label();
            this.labelHDModel = new System.Windows.Forms.Label();
            this.labelHDSerial = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxRelatedComputer = new System.Windows.Forms.GroupBox();
            this.pictureBoxRelatedComputer = new System.Windows.Forms.PictureBox();
            this.panelRelatedComputerGeneralInfo = new System.Windows.Forms.Panel();
            this.labelHDCompType = new System.Windows.Forms.Label();
            this.textBoxHDRelatedComputerType = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.labelHDCompSvcTage = new System.Windows.Forms.Label();
            this.textBoxHDRelatedComputerSvcTag = new System.Windows.Forms.TextBox();
            this.labelHDCompSerialNum = new System.Windows.Forms.Label();
            this.textBoxHDRelatedComputerSerialNum = new System.Windows.Forms.TextBox();
            this.labelHDCompModel = new System.Windows.Forms.Label();
            this.labelHDCompMake = new System.Windows.Forms.Label();
            this.textBoxHDRelatedComputerModel = new System.Windows.Forms.TextBox();
            this.textBoxHDRelatedComputerMake = new System.Windows.Forms.TextBox();
            this.panelRelatedComputerSystemInformation = new System.Windows.Forms.Panel();
            this.textBoxHDRelatedCompSysInfoHostname = new System.Windows.Forms.TextBox();
            this.textBoxHDRelatedCompSysInfoHostedSystem = new System.Windows.Forms.TextBox();
            this.textBoxHDRelatedCompSysInfoVirtualMachine = new System.Windows.Forms.TextBox();
            this.textBoxHDRelatedCompSysInfoServer = new System.Windows.Forms.TextBox();
            this.textBoxHDRelatedCompSysInfoServerType = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.textBoxHDRelatedCompSysInfoPoweredOn = new System.Windows.Forms.TextBox();
            this.textBoxHDRelatedCompSysInfoShutDownBy = new System.Windows.Forms.TextBox();
            this.textBoxHDRelatedCompSysInfoAppsRunning = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.textBoxHDRelatedCompSysInfoSystemRunning = new System.Windows.Forms.TextBox();
            this.textBoxHDRelatedCompSysInfoPulledPlug = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.panelRaid = new System.Windows.Forms.Panel();
            this.label65 = new System.Windows.Forms.Label();
            this.panelRelatedRaidInformation = new System.Windows.Forms.Panel();
            this.label66 = new System.Windows.Forms.Label();
            this.listViewRelatedRaidonHDPage = new System.Windows.Forms.ListView();
            this.textBoxHDRaidLevel = new System.Windows.Forms.TextBox();
            this.textBoxHDRaidHardwareOrSoftware = new System.Windows.Forms.TextBox();
            this.textBoxHDRaidType = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxHDFinishDateTimeOutput = new System.Windows.Forms.TextBox();
            this.textBoxHDTechExaminerOutput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxHDJumperSettingsOutput = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlJumperDiagram = new System.Windows.Forms.Panel();
            this.jumperPosition9 = new System.Windows.Forms.Button();
            this.jumperPosition8 = new System.Windows.Forms.Button();
            this.jumperPosition7 = new System.Windows.Forms.Button();
            this.jumperPosition6 = new System.Windows.Forms.Button();
            this.jumperPosition5 = new System.Windows.Forms.Button();
            this.jumperPosition4 = new System.Windows.Forms.Button();
            this.jumperPosition3 = new System.Windows.Forms.Button();
            this.jumperPosition2 = new System.Windows.Forms.Button();
            this.jumperPosition1 = new System.Windows.Forms.Button();
            this.jumperPosition0 = new System.Windows.Forms.Button();
            this.labelJumperDiagram = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelJumperDetails = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxHDTypeOutput = new System.Windows.Forms.TextBox();
            this.textBoxHDDrivePositionOutput = new System.Windows.Forms.TextBox();
            this.labelDrivePositionAsInstalled = new System.Windows.Forms.Label();
            this.textBoxHDDriveInterfaceOutput = new System.Windows.Forms.TextBox();
            this.labelDriveInteface = new System.Windows.Forms.Label();
            this.lblHardDriveInformation = new System.Windows.Forms.Label();
            this.lblHardDriveSize = new System.Windows.Forms.Label();
            this.textBoxHDSizeOutput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxHDSerialNumOutput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxHDModelOutput = new System.Windows.Forms.TextBox();
            this.textBoxHDMakeOutput = new System.Windows.Forms.TextBox();
            this.buttonViewDetailsHardDriveListView = new System.Windows.Forms.Button();
            this.buttonViewTileHardDriveListView = new System.Windows.Forms.Button();
            this.lblListOfHardDrives = new System.Windows.Forms.Label();
            this.buttonDeleteHardDrives = new System.Windows.Forms.Button();
            this.buttonEditHardDrives = new System.Windows.Forms.Button();
            this.buttonViewHardDrives = new System.Windows.Forms.Button();
            this.buttonAddHardDrives = new System.Windows.Forms.Button();
            this.listViewHardDrivesOnHardDrivePage = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listViewForensicProcesses = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelAssociatedHardDrives = new System.Windows.Forms.Label();
            this.labelAssociatedcomputers = new System.Windows.Forms.Label();
            this.labelDestinationMediaInfo = new System.Windows.Forms.Label();
            this.listViewFPAssociatedHardDrives = new System.Windows.Forms.ListView();
            this.listViewFPAssociatedComputers = new System.Windows.Forms.ListView();
            this.listViewFPDestinationMediae = new System.Windows.Forms.ListView();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxFPCDFTechExaminer = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxFPFinishDateTime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBoxFPImagesVerifiedBy = new System.Windows.Forms.TextBox();
            this.labelImagesVerifiedBy = new System.Windows.Forms.Label();
            this.textBoxFPImagesMade = new System.Windows.Forms.TextBox();
            this.labelImagesMade = new System.Windows.Forms.Label();
            this.labelImageInforamtion = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBoxFPSoftware = new System.Windows.Forms.TextBox();
            this.labelSoftware = new System.Windows.Forms.Label();
            this.textBoxFPDeviceUsed = new System.Windows.Forms.TextBox();
            this.labelForensicDeviceUsed = new System.Windows.Forms.Label();
            this.textBoxFPProcessPerformed = new System.Windows.Forms.TextBox();
            this.labelProcessingPerformed = new System.Windows.Forms.Label();
            this.labelProcessingInformation = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBoxFPHardDriveOnly = new System.Windows.Forms.TextBox();
            this.textBoxFPImageOnly = new System.Windows.Forms.TextBox();
            this.textBoxFPPhotosTaken = new System.Windows.Forms.TextBox();
            this.labelHardDriveOnly = new System.Windows.Forms.Label();
            this.labelImageOnly = new System.Windows.Forms.Label();
            this.labelPhotosTaken = new System.Windows.Forms.Label();
            this.textBoxFPCustodianOrUser = new System.Windows.Forms.TextBox();
            this.textBoxFPRoomNumber = new System.Windows.Forms.TextBox();
            this.labelCustodainOrUser = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.textBoxFPCollectionLocationOutput = new System.Windows.Forms.TextBox();
            this.label4CollectionLocation = new System.Windows.Forms.Label();
            this.label4CollectionInformation = new System.Windows.Forms.Label();
            this.buttonViewSmallIconForensicProcessListView = new System.Windows.Forms.Button();
            this.buttonViewTileForensicProcessListView = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonDeleteForensicProcess = new System.Windows.Forms.Button();
            this.buttonEditForensicProcess = new System.Windows.Forms.Button();
            this.buttonViewForensicProcess = new System.Windows.Forms.Button();
            this.buttonAddForensicProcess = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonRemoveActiveUserFile = new System.Windows.Forms.Button();
            this.buttonEditActiveUserFile = new System.Windows.Forms.Button();
            this.buttonViewActiveUserFile = new System.Windows.Forms.Button();
            this.buttonAddActiveUserFiles = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.listViewAUFActiveUserFiles = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelConclusionLabel = new System.Windows.Forms.Label();
            this.textBoxConclusion = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.AddEmployee2 = new System.Windows.Forms.Button();
            this.comboBoxCdfInfoTech = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCDFDate = new System.Windows.Forms.DateTimePicker();
            this.labelCDFFinishDateTime = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.labelCdfInfo = new System.Windows.Forms.Label();
            this.labelNotesLabel = new System.Windows.Forms.Label();
            this.textBoxNACNotes = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            itemNumberLabel = new System.Windows.Forms.Label();
            matterLabel = new System.Windows.Forms.Label();
            caseNumberLabel = new System.Windows.Forms.Label();
            barcodeDateVerifiedLabel = new System.Windows.Forms.Label();
            barcodeLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            firm_idLabel = new System.Windows.Forms.Label();
            requester_idLabel = new System.Windows.Forms.Label();
            examiner_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxHardDriveDetails.SuspendLayout();
            this.groupBoxComputerDetails.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxDriveDetails.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxRelatedComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRelatedComputer)).BeginInit();
            this.panelRelatedComputerGeneralInfo.SuspendLayout();
            this.panelRelatedComputerSystemInformation.SuspendLayout();
            this.panelRaid.SuspendLayout();
            this.panelRelatedRaidInformation.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlJumperDiagram.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNumberLabel
            // 
            itemNumberLabel.AutoSize = true;
            itemNumberLabel.Location = new System.Drawing.Point(8, 82);
            itemNumberLabel.Name = "itemNumberLabel";
            itemNumberLabel.Size = new System.Drawing.Size(70, 13);
            itemNumberLabel.TabIndex = 18;
            itemNumberLabel.Text = "Item Number:";
            // 
            // matterLabel
            // 
            matterLabel.AutoSize = true;
            matterLabel.Location = new System.Drawing.Point(8, 53);
            matterLabel.Name = "matterLabel";
            matterLabel.Size = new System.Drawing.Size(40, 13);
            matterLabel.TabIndex = 16;
            matterLabel.Text = "Matter:";
            // 
            // caseNumberLabel
            // 
            caseNumberLabel.AutoSize = true;
            caseNumberLabel.Location = new System.Drawing.Point(8, 23);
            caseNumberLabel.Name = "caseNumberLabel";
            caseNumberLabel.Size = new System.Drawing.Size(74, 13);
            caseNumberLabel.TabIndex = 14;
            caseNumberLabel.Text = "Case Number:";
            // 
            // barcodeDateVerifiedLabel
            // 
            barcodeDateVerifiedLabel.AutoSize = true;
            barcodeDateVerifiedLabel.Location = new System.Drawing.Point(247, 82);
            barcodeDateVerifiedLabel.Name = "barcodeDateVerifiedLabel";
            barcodeDateVerifiedLabel.Size = new System.Drawing.Size(114, 13);
            barcodeDateVerifiedLabel.TabIndex = 6;
            barcodeDateVerifiedLabel.Text = "Barcode Date Verified:";
            // 
            // barcodeLabel
            // 
            barcodeLabel.AutoSize = true;
            barcodeLabel.Location = new System.Drawing.Point(247, 53);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(50, 13);
            barcodeLabel.TabIndex = 4;
            barcodeLabel.Text = "Barcode:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(247, 23);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(58, 13);
            startDateLabel.TabIndex = 2;
            startDateLabel.Text = "Start Date:";
            // 
            // firm_idLabel
            // 
            firm_idLabel.AutoSize = true;
            firm_idLabel.Location = new System.Drawing.Point(577, 23);
            firm_idLabel.Name = "firm_idLabel";
            firm_idLabel.Size = new System.Drawing.Size(29, 13);
            firm_idLabel.TabIndex = 19;
            firm_idLabel.Text = "Firm:";
            // 
            // requester_idLabel
            // 
            requester_idLabel.AutoSize = true;
            requester_idLabel.Location = new System.Drawing.Point(577, 53);
            requester_idLabel.Name = "requester_idLabel";
            requester_idLabel.Size = new System.Drawing.Size(59, 13);
            requester_idLabel.TabIndex = 20;
            requester_idLabel.Text = "Requester:";
            // 
            // examiner_idLabel
            // 
            examiner_idLabel.AutoSize = true;
            examiner_idLabel.Location = new System.Drawing.Point(577, 82);
            examiner_idLabel.Name = "examiner_idLabel";
            examiner_idLabel.Size = new System.Drawing.Size(53, 13);
            examiner_idLabel.TabIndex = 21;
            examiner_idLabel.Text = "Examiner:";
            // 
            // caseBindingSource
            // 
            this.caseBindingSource.DataMember = "Case";
            this.caseBindingSource.DataSource = this.trendDataSet;
            // 
            // trendDataSet
            // 
            this.trendDataSet.DataSetName = "TrendDataSet";
            this.trendDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // caseTableAdapter
            // 
            this.caseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CaseTableAdapter = this.caseTableAdapter;
            this.tableAdapterManager.CdfInfoTableAdapter = null;
            this.tableAdapterManager.ComputerTableAdapter = null;
            this.tableAdapterManager.DestinationMediaTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FirmContactTableAdapter = null;
            this.tableAdapterManager.FirmTableAdapter = null;
            this.tableAdapterManager.ForensicProcessTableAdapter = null;
            this.tableAdapterManager.HardDriveTableAdapter = null;
            this.tableAdapterManager.NotesAndConclusionTableAdapter = null;
            this.tableAdapterManager.RaidTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TrendWinForm.TrendDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemNumberTextBox
            // 
            this.itemNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "ItemNumber", true));
            this.itemNumberTextBox.Location = new System.Drawing.Point(84, 78);
            this.itemNumberTextBox.Name = "itemNumberTextBox";
            this.itemNumberTextBox.Size = new System.Drawing.Size(138, 20);
            this.itemNumberTextBox.TabIndex = 19;
            this.itemNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.itemNumberTextBox_Validating);
            // 
            // matterTextBox
            // 
            this.matterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "Matter", true));
            this.matterTextBox.Location = new System.Drawing.Point(84, 49);
            this.matterTextBox.Name = "matterTextBox";
            this.matterTextBox.Size = new System.Drawing.Size(138, 20);
            this.matterTextBox.TabIndex = 17;
            this.matterTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.matterTextBox_Validating);
            // 
            // caseNumberTextBox
            // 
            this.caseNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CaseNumber", true));
            this.caseNumberTextBox.Location = new System.Drawing.Point(84, 19);
            this.caseNumberTextBox.Name = "caseNumberTextBox";
            this.caseNumberTextBox.Size = new System.Drawing.Size(138, 20);
            this.caseNumberTextBox.TabIndex = 15;
            this.caseNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.caseNumberTextBox_Validating);
            // 
            // barcodeDateVerifiedDateTimePicker
            // 
            this.barcodeDateVerifiedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.caseBindingSource, "BarcodeDateVerified", true));
            this.barcodeDateVerifiedDateTimePicker.Location = new System.Drawing.Point(362, 78);
            this.barcodeDateVerifiedDateTimePicker.Name = "barcodeDateVerifiedDateTimePicker";
            this.barcodeDateVerifiedDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.barcodeDateVerifiedDateTimePicker.TabIndex = 7;
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "Barcode", true));
            this.barcodeTextBox.Location = new System.Drawing.Point(362, 49);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(203, 20);
            this.barcodeTextBox.TabIndex = 5;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.caseBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(362, 19);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.startDateDateTimePicker.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.ViewEmployee);
            this.groupBox1.Controls.Add(this.ViewFirmContact);
            this.groupBox1.Controls.Add(this.ViewFirm);
            this.groupBox1.Controls.Add(this.AddEmployee);
            this.groupBox1.Controls.Add(this.AddFirmContact);
            this.groupBox1.Controls.Add(this.AddFirm);
            this.groupBox1.Controls.Add(examiner_idLabel);
            this.groupBox1.Controls.Add(this.examiner_idComboBox);
            this.groupBox1.Controls.Add(requester_idLabel);
            this.groupBox1.Controls.Add(this.requester_idComboBox);
            this.groupBox1.Controls.Add(firm_idLabel);
            this.groupBox1.Controls.Add(this.firm_idComboBox);
            this.groupBox1.Controls.Add(startDateLabel);
            this.groupBox1.Controls.Add(this.startDateDateTimePicker);
            this.groupBox1.Controls.Add(barcodeLabel);
            this.groupBox1.Controls.Add(this.barcodeTextBox);
            this.groupBox1.Controls.Add(barcodeDateVerifiedLabel);
            this.groupBox1.Controls.Add(this.barcodeDateVerifiedDateTimePicker);
            this.groupBox1.Controls.Add(caseNumberLabel);
            this.groupBox1.Controls.Add(this.caseNumberTextBox);
            this.groupBox1.Controls.Add(matterLabel);
            this.groupBox1.Controls.Add(this.matterTextBox);
            this.groupBox1.Controls.Add(itemNumberLabel);
            this.groupBox1.Controls.Add(this.itemNumberTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Case Information";
            // 
            // ViewEmployee
            // 
            this.ViewEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewEmployee.BackgroundImage")));
            this.ViewEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ViewEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewEmployee.Location = new System.Drawing.Point(866, 76);
            this.ViewEmployee.Name = "ViewEmployee";
            this.ViewEmployee.Size = new System.Drawing.Size(24, 24);
            this.ViewEmployee.TabIndex = 28;
            this.ViewEmployee.UseVisualStyleBackColor = true;
            this.ViewEmployee.Click += new System.EventHandler(this.ViewEmployee_Click);
            // 
            // ViewFirmContact
            // 
            this.ViewFirmContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewFirmContact.BackgroundImage")));
            this.ViewFirmContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ViewFirmContact.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewFirmContact.Location = new System.Drawing.Point(866, 47);
            this.ViewFirmContact.Name = "ViewFirmContact";
            this.ViewFirmContact.Size = new System.Drawing.Size(24, 24);
            this.ViewFirmContact.TabIndex = 27;
            this.ViewFirmContact.UseVisualStyleBackColor = true;
            this.ViewFirmContact.Click += new System.EventHandler(this.ViewFirmContact_Click);
            // 
            // ViewFirm
            // 
            this.ViewFirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewFirm.BackgroundImage")));
            this.ViewFirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ViewFirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewFirm.Location = new System.Drawing.Point(866, 17);
            this.ViewFirm.Name = "ViewFirm";
            this.ViewFirm.Size = new System.Drawing.Size(24, 24);
            this.ViewFirm.TabIndex = 26;
            this.ViewFirm.UseVisualStyleBackColor = true;
            this.ViewFirm.Click += new System.EventHandler(this.ViewFirm_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddEmployee.BackgroundImage")));
            this.AddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddEmployee.Location = new System.Drawing.Point(837, 76);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(24, 24);
            this.AddEmployee.TabIndex = 25;
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // AddFirmContact
            // 
            this.AddFirmContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFirmContact.BackgroundImage")));
            this.AddFirmContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddFirmContact.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddFirmContact.Location = new System.Drawing.Point(837, 47);
            this.AddFirmContact.Name = "AddFirmContact";
            this.AddFirmContact.Size = new System.Drawing.Size(24, 24);
            this.AddFirmContact.TabIndex = 24;
            this.AddFirmContact.UseVisualStyleBackColor = true;
            this.AddFirmContact.Click += new System.EventHandler(this.AddFirmContact_Click);
            // 
            // AddFirm
            // 
            this.AddFirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFirm.BackgroundImage")));
            this.AddFirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddFirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddFirm.Location = new System.Drawing.Point(837, 17);
            this.AddFirm.Name = "AddFirm";
            this.AddFirm.Size = new System.Drawing.Size(24, 24);
            this.AddFirm.TabIndex = 23;
            this.AddFirm.UseVisualStyleBackColor = true;
            this.AddFirm.Click += new System.EventHandler(this.AddFirm_Click);
            // 
            // examiner_idComboBox
            // 
            this.examiner_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "Examiner_id", true));
            this.examiner_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examiner_idComboBox.FormattingEnabled = true;
            this.examiner_idComboBox.Location = new System.Drawing.Point(639, 78);
            this.examiner_idComboBox.Name = "examiner_idComboBox";
            this.examiner_idComboBox.Size = new System.Drawing.Size(192, 21);
            this.examiner_idComboBox.TabIndex = 22;
            // 
            // requester_idComboBox
            // 
            this.requester_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "Requester_id", true));
            this.requester_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requester_idComboBox.FormattingEnabled = true;
            this.requester_idComboBox.Location = new System.Drawing.Point(639, 49);
            this.requester_idComboBox.Name = "requester_idComboBox";
            this.requester_idComboBox.Size = new System.Drawing.Size(192, 21);
            this.requester_idComboBox.TabIndex = 21;
            // 
            // firm_idComboBox
            // 
            this.firm_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "Firm_id", true));
            this.firm_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firm_idComboBox.FormattingEnabled = true;
            this.firm_idComboBox.Location = new System.Drawing.Point(639, 19);
            this.firm_idComboBox.Name = "firm_idComboBox";
            this.firm_idComboBox.Size = new System.Drawing.Size(192, 21);
            this.firm_idComboBox.TabIndex = 20;
            this.firm_idComboBox.SelectionChangeCommitted += new System.EventHandler(this.firm_idComboBox_SelectionChangeCommitted);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton.CausesValidation = false;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(6, 683);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(441, 31);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveButton.Location = new System.Drawing.Point(469, 683);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(441, 31);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(6, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 554);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.buttonViewDetailsComputerListView);
            this.tabPage1.Controls.Add(this.buttonViewTileComputerListView);
            this.tabPage1.Controls.Add(this.groupBoxHardDriveDetails);
            this.tabPage1.Controls.Add(this.groupBoxComputerDetails);
            this.tabPage1.Controls.Add(this.buttonDeleteComputer);
            this.tabPage1.Controls.Add(this.buttonEditComputer);
            this.tabPage1.Controls.Add(this.buttonViewComputer);
            this.tabPage1.Controls.Add(this.buttonAddComputer);
            this.tabPage1.Controls.Add(this.labelComputerList);
            this.tabPage1.Controls.Add(this.listViewAssociatedComputerList);
            this.tabPage1.Controls.Add(this.groupBoxDriveDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Computer";
            // 
            // buttonViewDetailsComputerListView
            // 
            this.buttonViewDetailsComputerListView.BackgroundImage = global::TrendWinForm.Properties.Resources.view_details;
            this.buttonViewDetailsComputerListView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonViewDetailsComputerListView.Location = new System.Drawing.Point(40, 28);
            this.buttonViewDetailsComputerListView.Name = "buttonViewDetailsComputerListView";
            this.buttonViewDetailsComputerListView.Size = new System.Drawing.Size(24, 24);
            this.buttonViewDetailsComputerListView.TabIndex = 37;
            this.buttonViewDetailsComputerListView.UseVisualStyleBackColor = true;
            this.buttonViewDetailsComputerListView.Click += new System.EventHandler(this.buttonViewDetailsComputerListView_Click);
            // 
            // buttonViewTileComputerListView
            // 
            this.buttonViewTileComputerListView.BackgroundImage = global::TrendWinForm.Properties.Resources.application_tile_horizontal;
            this.buttonViewTileComputerListView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonViewTileComputerListView.Location = new System.Drawing.Point(8, 28);
            this.buttonViewTileComputerListView.Name = "buttonViewTileComputerListView";
            this.buttonViewTileComputerListView.Size = new System.Drawing.Size(24, 24);
            this.buttonViewTileComputerListView.TabIndex = 36;
            this.buttonViewTileComputerListView.UseVisualStyleBackColor = true;
            this.buttonViewTileComputerListView.Click += new System.EventHandler(this.buttonViewTileComputerListView_Click);
            // 
            // groupBoxHardDriveDetails
            // 
            this.groupBoxHardDriveDetails.Controls.Add(this.listViewComputerAssociatedHardDrives);
            this.groupBoxHardDriveDetails.Location = new System.Drawing.Point(160, 398);
            this.groupBoxHardDriveDetails.Name = "groupBoxHardDriveDetails";
            this.groupBoxHardDriveDetails.Size = new System.Drawing.Size(386, 120);
            this.groupBoxHardDriveDetails.TabIndex = 34;
            this.groupBoxHardDriveDetails.TabStop = false;
            this.groupBoxHardDriveDetails.Text = "Hard Drives";
            // 
            // listViewComputerAssociatedHardDrives
            // 
            this.listViewComputerAssociatedHardDrives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewComputerAssociatedHardDrives.Location = new System.Drawing.Point(3, 16);
            this.listViewComputerAssociatedHardDrives.MultiSelect = false;
            this.listViewComputerAssociatedHardDrives.Name = "listViewComputerAssociatedHardDrives";
            this.listViewComputerAssociatedHardDrives.Size = new System.Drawing.Size(380, 101);
            this.listViewComputerAssociatedHardDrives.TabIndex = 0;
            this.listViewComputerAssociatedHardDrives.UseCompatibleStateImageBehavior = false;
            this.listViewComputerAssociatedHardDrives.SelectedIndexChanged += new System.EventHandler(this.listViewComputerAssociatedHardDrives_SelectedIndexChanged);
            // 
            // groupBoxComputerDetails
            // 
            this.groupBoxComputerDetails.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxComputerDetails.Controls.Add(this.label6);
            this.groupBoxComputerDetails.Controls.Add(this.label5);
            this.groupBoxComputerDetails.Controls.Add(this.txtFinishDateTime);
            this.groupBoxComputerDetails.Controls.Add(this.txtTechExaminer);
            this.groupBoxComputerDetails.Controls.Add(this.label4);
            this.groupBoxComputerDetails.Controls.Add(this.panel4);
            this.groupBoxComputerDetails.Controls.Add(this.panel3);
            this.groupBoxComputerDetails.Controls.Add(this.panel2);
            this.groupBoxComputerDetails.Controls.Add(this.panel1);
            this.groupBoxComputerDetails.Location = new System.Drawing.Point(160, 12);
            this.groupBoxComputerDetails.Name = "groupBoxComputerDetails";
            this.groupBoxComputerDetails.Size = new System.Drawing.Size(727, 386);
            this.groupBoxComputerDetails.TabIndex = 33;
            this.groupBoxComputerDetails.TabStop = false;
            this.groupBoxComputerDetails.Text = "Computer Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 184;
            this.label6.Text = "CDF Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(516, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 186;
            this.label5.Text = "Finsih Date/Time";
            // 
            // txtFinishDateTime
            // 
            this.txtFinishDateTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFinishDateTime.Enabled = false;
            this.txtFinishDateTime.Location = new System.Drawing.Point(612, 360);
            this.txtFinishDateTime.Name = "txtFinishDateTime";
            this.txtFinishDateTime.ReadOnly = true;
            this.txtFinishDateTime.Size = new System.Drawing.Size(101, 20);
            this.txtFinishDateTime.TabIndex = 185;
            // 
            // txtTechExaminer
            // 
            this.txtTechExaminer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTechExaminer.Enabled = false;
            this.txtTechExaminer.Location = new System.Drawing.Point(393, 360);
            this.txtTechExaminer.Name = "txtTechExaminer";
            this.txtTechExaminer.ReadOnly = true;
            this.txtTechExaminer.Size = new System.Drawing.Size(112, 20);
            this.txtTechExaminer.TabIndex = 184;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(316, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 184;
            this.label4.Text = "Texh/Examiner";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.txtHostname);
            this.panel4.Controls.Add(this.txtHostedSystem);
            this.panel4.Controls.Add(this.txtVirtualMachine);
            this.panel4.Controls.Add(this.txtWasItAServer);
            this.panel4.Controls.Add(this.txtServerType);
            this.panel4.Controls.Add(this.Label40);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Label38);
            this.panel4.Controls.Add(this.Label39);
            this.panel4.Controls.Add(this.Label29);
            this.panel4.Controls.Add(this.txtWasItPoweredOn);
            this.panel4.Controls.Add(this.txtShutDownBy);
            this.panel4.Controls.Add(this.txtAppsRunning);
            this.panel4.Controls.Add(this.Label37);
            this.panel4.Controls.Add(this.txtSystemRunning);
            this.panel4.Controls.Add(this.txtPulledPlug);
            this.panel4.Controls.Add(this.Label35);
            this.panel4.Controls.Add(this.Label36);
            this.panel4.Controls.Add(this.Label34);
            this.panel4.Controls.Add(this.Label33);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(308, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 161);
            this.panel4.TabIndex = 175;
            // 
            // txtHostname
            // 
            this.txtHostname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHostname.Enabled = false;
            this.txtHostname.Location = new System.Drawing.Point(297, 128);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.ReadOnly = true;
            this.txtHostname.Size = new System.Drawing.Size(107, 20);
            this.txtHostname.TabIndex = 176;
            // 
            // txtHostedSystem
            // 
            this.txtHostedSystem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHostedSystem.Enabled = false;
            this.txtHostedSystem.Location = new System.Drawing.Point(297, 102);
            this.txtHostedSystem.Name = "txtHostedSystem";
            this.txtHostedSystem.ReadOnly = true;
            this.txtHostedSystem.Size = new System.Drawing.Size(107, 20);
            this.txtHostedSystem.TabIndex = 175;
            // 
            // txtVirtualMachine
            // 
            this.txtVirtualMachine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtVirtualMachine.Enabled = false;
            this.txtVirtualMachine.Location = new System.Drawing.Point(298, 75);
            this.txtVirtualMachine.Name = "txtVirtualMachine";
            this.txtVirtualMachine.ReadOnly = true;
            this.txtVirtualMachine.Size = new System.Drawing.Size(107, 20);
            this.txtVirtualMachine.TabIndex = 174;
            // 
            // txtWasItAServer
            // 
            this.txtWasItAServer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWasItAServer.Enabled = false;
            this.txtWasItAServer.Location = new System.Drawing.Point(297, 25);
            this.txtWasItAServer.Name = "txtWasItAServer";
            this.txtWasItAServer.ReadOnly = true;
            this.txtWasItAServer.Size = new System.Drawing.Size(108, 20);
            this.txtWasItAServer.TabIndex = 172;
            // 
            // txtServerType
            // 
            this.txtServerType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtServerType.Enabled = false;
            this.txtServerType.Location = new System.Drawing.Point(298, 49);
            this.txtServerType.Name = "txtServerType";
            this.txtServerType.ReadOnly = true;
            this.txtServerType.Size = new System.Drawing.Size(107, 20);
            this.txtServerType.TabIndex = 173;
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label40.Location = new System.Drawing.Point(208, 132);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(61, 13);
            this.Label40.TabIndex = 176;
            this.Label40.Text = "-Hostname-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(208, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 178;
            this.label3.Text = "Server Type? ";
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label38.Location = new System.Drawing.Point(208, 79);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(85, 13);
            this.Label38.TabIndex = 175;
            this.Label38.Text = "Virtual machine?";
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label39.Location = new System.Drawing.Point(208, 106);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(82, 13);
            this.Label39.TabIndex = 177;
            this.Label39.Text = "Hosted system?";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label29.Location = new System.Drawing.Point(208, 29);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(47, 13);
            this.Label29.TabIndex = 174;
            this.Label29.Text = "Server? ";
            // 
            // txtWasItPoweredOn
            // 
            this.txtWasItPoweredOn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWasItPoweredOn.Enabled = false;
            this.txtWasItPoweredOn.Location = new System.Drawing.Point(95, 128);
            this.txtWasItPoweredOn.Name = "txtWasItPoweredOn";
            this.txtWasItPoweredOn.ReadOnly = true;
            this.txtWasItPoweredOn.Size = new System.Drawing.Size(101, 20);
            this.txtWasItPoweredOn.TabIndex = 172;
            // 
            // txtShutDownBy
            // 
            this.txtShutDownBy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtShutDownBy.Enabled = false;
            this.txtShutDownBy.Location = new System.Drawing.Point(95, 102);
            this.txtShutDownBy.Name = "txtShutDownBy";
            this.txtShutDownBy.ReadOnly = true;
            this.txtShutDownBy.Size = new System.Drawing.Size(101, 20);
            this.txtShutDownBy.TabIndex = 170;
            // 
            // txtAppsRunning
            // 
            this.txtAppsRunning.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAppsRunning.Enabled = false;
            this.txtAppsRunning.Location = new System.Drawing.Point(96, 75);
            this.txtAppsRunning.Name = "txtAppsRunning";
            this.txtAppsRunning.ReadOnly = true;
            this.txtAppsRunning.Size = new System.Drawing.Size(101, 20);
            this.txtAppsRunning.TabIndex = 169;
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label37.Location = new System.Drawing.Point(8, 132);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(70, 13);
            this.Label37.TabIndex = 171;
            this.Label37.Text = "Powered on?";
            // 
            // txtSystemRunning
            // 
            this.txtSystemRunning.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSystemRunning.Enabled = false;
            this.txtSystemRunning.Location = new System.Drawing.Point(95, 25);
            this.txtSystemRunning.Name = "txtSystemRunning";
            this.txtSystemRunning.ReadOnly = true;
            this.txtSystemRunning.Size = new System.Drawing.Size(102, 20);
            this.txtSystemRunning.TabIndex = 167;
            // 
            // txtPulledPlug
            // 
            this.txtPulledPlug.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPulledPlug.Enabled = false;
            this.txtPulledPlug.Location = new System.Drawing.Point(96, 49);
            this.txtPulledPlug.Name = "txtPulledPlug";
            this.txtPulledPlug.ReadOnly = true;
            this.txtPulledPlug.Size = new System.Drawing.Size(101, 20);
            this.txtPulledPlug.TabIndex = 168;
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label35.Location = new System.Drawing.Point(8, 79);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(78, 13);
            this.Label35.TabIndex = 168;
            this.Label35.Text = "Apps running? ";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label36.Location = new System.Drawing.Point(8, 106);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(78, 13);
            this.Label36.TabIndex = 170;
            this.Label36.Text = "Shut down by: ";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label34.Location = new System.Drawing.Point(8, 53);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(68, 13);
            this.Label34.TabIndex = 169;
            this.Label34.Text = "Pulled plug? ";
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label33.Location = new System.Drawing.Point(8, 29);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(88, 13);
            this.Label33.TabIndex = 167;
            this.Label33.Text = "System running? ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 166;
            this.label2.Text = "SysInfo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.txtWasCMOSChanged);
            this.panel3.Controls.Add(this.txtSetupKeystroke);
            this.panel3.Controls.Add(this.txtTimeProvidedBy);
            this.panel3.Controls.Add(this.txtActualTime);
            this.panel3.Controls.Add(this.txtActualDate);
            this.panel3.Controls.Add(this.txtCMOSTime);
            this.panel3.Controls.Add(this.txtCMOSDate);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Label24);
            this.panel3.Controls.Add(this.Label25);
            this.panel3.Controls.Add(this.Label26);
            this.panel3.Controls.Add(this.Label27);
            this.panel3.Controls.Add(this.Label28);
            this.panel3.Controls.Add(this.Label30);
            this.panel3.Controls.Add(this.Label31);
            this.panel3.Controls.Add(this.txtCMOSChangesMade);
            this.panel3.Controls.Add(this.Label32);
            this.panel3.Location = new System.Drawing.Point(308, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 156);
            this.panel3.TabIndex = 161;
            // 
            // txtWasCMOSChanged
            // 
            this.txtWasCMOSChanged.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWasCMOSChanged.Enabled = false;
            this.txtWasCMOSChanged.Location = new System.Drawing.Point(271, 50);
            this.txtWasCMOSChanged.Name = "txtWasCMOSChanged";
            this.txtWasCMOSChanged.ReadOnly = true;
            this.txtWasCMOSChanged.Size = new System.Drawing.Size(141, 20);
            this.txtWasCMOSChanged.TabIndex = 165;
            // 
            // txtSetupKeystroke
            // 
            this.txtSetupKeystroke.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSetupKeystroke.Enabled = false;
            this.txtSetupKeystroke.Location = new System.Drawing.Point(271, 26);
            this.txtSetupKeystroke.Name = "txtSetupKeystroke";
            this.txtSetupKeystroke.ReadOnly = true;
            this.txtSetupKeystroke.Size = new System.Drawing.Size(141, 20);
            this.txtSetupKeystroke.TabIndex = 164;
            // 
            // txtTimeProvidedBy
            // 
            this.txtTimeProvidedBy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTimeProvidedBy.Enabled = false;
            this.txtTimeProvidedBy.Location = new System.Drawing.Point(6, 132);
            this.txtTimeProvidedBy.Name = "txtTimeProvidedBy";
            this.txtTimeProvidedBy.ReadOnly = true;
            this.txtTimeProvidedBy.Size = new System.Drawing.Size(166, 20);
            this.txtTimeProvidedBy.TabIndex = 163;
            // 
            // txtActualTime
            // 
            this.txtActualTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtActualTime.Enabled = false;
            this.txtActualTime.Location = new System.Drawing.Point(69, 95);
            this.txtActualTime.Name = "txtActualTime";
            this.txtActualTime.ReadOnly = true;
            this.txtActualTime.Size = new System.Drawing.Size(103, 20);
            this.txtActualTime.TabIndex = 162;
            // 
            // txtActualDate
            // 
            this.txtActualDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtActualDate.Enabled = false;
            this.txtActualDate.Location = new System.Drawing.Point(69, 72);
            this.txtActualDate.Name = "txtActualDate";
            this.txtActualDate.ReadOnly = true;
            this.txtActualDate.Size = new System.Drawing.Size(103, 20);
            this.txtActualDate.TabIndex = 161;
            // 
            // txtCMOSTime
            // 
            this.txtCMOSTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCMOSTime.Enabled = false;
            this.txtCMOSTime.Location = new System.Drawing.Point(69, 50);
            this.txtCMOSTime.Name = "txtCMOSTime";
            this.txtCMOSTime.ReadOnly = true;
            this.txtCMOSTime.Size = new System.Drawing.Size(103, 20);
            this.txtCMOSTime.TabIndex = 160;
            // 
            // txtCMOSDate
            // 
            this.txtCMOSDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCMOSDate.Enabled = false;
            this.txtCMOSDate.Location = new System.Drawing.Point(69, 26);
            this.txtCMOSDate.Name = "txtCMOSDate";
            this.txtCMOSDate.ReadOnly = true;
            this.txtCMOSDate.Size = new System.Drawing.Size(103, 20);
            this.txtCMOSDate.TabIndex = 159;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 155;
            this.label1.Text = "CMOS Settings";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label24.Location = new System.Drawing.Point(4, 30);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(64, 13);
            this.Label24.TabIndex = 129;
            this.Label24.Text = "CMOS Date";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label25.Location = new System.Drawing.Point(4, 54);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(64, 13);
            this.Label25.TabIndex = 130;
            this.Label25.Text = "CMOS Time";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label26.Location = new System.Drawing.Point(4, 76);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(63, 13);
            this.Label26.TabIndex = 131;
            this.Label26.Text = "Actual Date";
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label27.Location = new System.Drawing.Point(4, 99);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(63, 13);
            this.Label27.TabIndex = 132;
            this.Label27.Text = "Actual Time";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label28.Location = new System.Drawing.Point(178, 54);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(93, 13);
            this.Label28.TabIndex = 133;
            this.Label28.Text = "CMOS Changed? ";
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label30.Location = new System.Drawing.Point(178, 30);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(85, 13);
            this.Label30.TabIndex = 139;
            this.Label30.Text = "Setup Keystroke";
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label31.Location = new System.Drawing.Point(4, 119);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(90, 13);
            this.Label31.TabIndex = 140;
            this.Label31.Text = "Time Provided By";
            // 
            // txtCMOSChangesMade
            // 
            this.txtCMOSChangesMade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCMOSChangesMade.Enabled = false;
            this.txtCMOSChangesMade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCMOSChangesMade.Location = new System.Drawing.Point(178, 91);
            this.txtCMOSChangesMade.Multiline = true;
            this.txtCMOSChangesMade.Name = "txtCMOSChangesMade";
            this.txtCMOSChangesMade.Size = new System.Drawing.Size(234, 62);
            this.txtCMOSChangesMade.TabIndex = 166;
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label32.Location = new System.Drawing.Point(177, 78);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(95, 13);
            this.Label32.TabIndex = 141;
            this.Label32.Text = "Changes to CMOS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewAssociatedRaids);
            this.panel2.Controls.Add(this.labelComputerRaid);
            this.panel2.Location = new System.Drawing.Point(6, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 206);
            this.panel2.TabIndex = 160;
            // 
            // listViewAssociatedRaids
            // 
            this.listViewAssociatedRaids.Location = new System.Drawing.Point(11, 29);
            this.listViewAssociatedRaids.MultiSelect = false;
            this.listViewAssociatedRaids.Name = "listViewAssociatedRaids";
            this.listViewAssociatedRaids.Size = new System.Drawing.Size(270, 174);
            this.listViewAssociatedRaids.TabIndex = 159;
            this.listViewAssociatedRaids.UseCompatibleStateImageBehavior = false;
            // 
            // labelComputerRaid
            // 
            this.labelComputerRaid.AutoSize = true;
            this.labelComputerRaid.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerRaid.Location = new System.Drawing.Point(3, 2);
            this.labelComputerRaid.Name = "labelComputerRaid";
            this.labelComputerRaid.Size = new System.Drawing.Size(151, 24);
            this.labelComputerRaid.TabIndex = 155;
            this.labelComputerRaid.Text = "Raid Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelType);
            this.panel1.Controls.Add(this.txtTypeOutput);
            this.panel1.Controls.Add(this.labelComputerInfo);
            this.panel1.Controls.Add(this.Label20);
            this.panel1.Controls.Add(this.txtSvcTag);
            this.panel1.Controls.Add(this.Label21);
            this.panel1.Controls.Add(this.txtSerialNum);
            this.panel1.Controls.Add(this.Label22);
            this.panel1.Controls.Add(this.Label23);
            this.panel1.Controls.Add(this.txtModelOutput);
            this.panel1.Controls.Add(this.txtMakeOutput);
            this.panel1.Location = new System.Drawing.Point(10, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 156);
            this.panel1.TabIndex = 159;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelType.Location = new System.Drawing.Point(3, 85);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 157;
            this.labelType.Text = "Type";
            // 
            // txtTypeOutput
            // 
            this.txtTypeOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTypeOutput.Location = new System.Drawing.Point(59, 81);
            this.txtTypeOutput.Name = "txtTypeOutput";
            this.txtTypeOutput.ReadOnly = true;
            this.txtTypeOutput.Size = new System.Drawing.Size(218, 20);
            this.txtTypeOutput.TabIndex = 138;
            // 
            // labelComputerInfo
            // 
            this.labelComputerInfo.AutoSize = true;
            this.labelComputerInfo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerInfo.Location = new System.Drawing.Point(3, 2);
            this.labelComputerInfo.Name = "labelComputerInfo";
            this.labelComputerInfo.Size = new System.Drawing.Size(180, 24);
            this.labelComputerInfo.TabIndex = 154;
            this.labelComputerInfo.Text = "General information";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label20.Location = new System.Drawing.Point(3, 135);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(48, 13);
            this.Label20.TabIndex = 130;
            this.Label20.Text = "Svc Tag";
            // 
            // txtSvcTag
            // 
            this.txtSvcTag.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSvcTag.Location = new System.Drawing.Point(59, 131);
            this.txtSvcTag.Name = "txtSvcTag";
            this.txtSvcTag.ReadOnly = true;
            this.txtSvcTag.Size = new System.Drawing.Size(218, 20);
            this.txtSvcTag.TabIndex = 140;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label21.Location = new System.Drawing.Point(3, 110);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(43, 13);
            this.Label21.TabIndex = 129;
            this.Label21.Text = "Serial #";
            // 
            // txtSerialNum
            // 
            this.txtSerialNum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSerialNum.Location = new System.Drawing.Point(58, 106);
            this.txtSerialNum.Name = "txtSerialNum";
            this.txtSerialNum.ReadOnly = true;
            this.txtSerialNum.Size = new System.Drawing.Size(219, 20);
            this.txtSerialNum.TabIndex = 139;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label22.Location = new System.Drawing.Point(3, 60);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(36, 13);
            this.Label22.TabIndex = 128;
            this.Label22.Text = "Model";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label23.Location = new System.Drawing.Point(3, 35);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(34, 13);
            this.Label23.TabIndex = 135;
            this.Label23.Text = "Make";
            // 
            // txtModelOutput
            // 
            this.txtModelOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtModelOutput.Location = new System.Drawing.Point(59, 56);
            this.txtModelOutput.Name = "txtModelOutput";
            this.txtModelOutput.ReadOnly = true;
            this.txtModelOutput.Size = new System.Drawing.Size(218, 20);
            this.txtModelOutput.TabIndex = 137;
            // 
            // txtMakeOutput
            // 
            this.txtMakeOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMakeOutput.Location = new System.Drawing.Point(58, 31);
            this.txtMakeOutput.Name = "txtMakeOutput";
            this.txtMakeOutput.ReadOnly = true;
            this.txtMakeOutput.Size = new System.Drawing.Size(219, 20);
            this.txtMakeOutput.TabIndex = 136;
            // 
            // buttonDeleteComputer
            // 
            this.buttonDeleteComputer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteComputer.BackgroundImage")));
            this.buttonDeleteComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeleteComputer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDeleteComputer.Location = new System.Drawing.Point(8, 496);
            this.buttonDeleteComputer.Name = "buttonDeleteComputer";
            this.buttonDeleteComputer.Size = new System.Drawing.Size(24, 24);
            this.buttonDeleteComputer.TabIndex = 32;
            this.buttonDeleteComputer.UseVisualStyleBackColor = true;
            this.buttonDeleteComputer.Click += new System.EventHandler(this.buttonDeleteComputer_Click);
            // 
            // buttonEditComputer
            // 
            this.buttonEditComputer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditComputer.BackgroundImage")));
            this.buttonEditComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditComputer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEditComputer.Location = new System.Drawing.Point(48, 496);
            this.buttonEditComputer.Name = "buttonEditComputer";
            this.buttonEditComputer.Size = new System.Drawing.Size(24, 24);
            this.buttonEditComputer.TabIndex = 31;
            this.buttonEditComputer.UseVisualStyleBackColor = true;
            this.buttonEditComputer.Click += new System.EventHandler(this.buttonEditComputer_Click);
            // 
            // buttonViewComputer
            // 
            this.buttonViewComputer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonViewComputer.BackgroundImage")));
            this.buttonViewComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonViewComputer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonViewComputer.Location = new System.Drawing.Point(88, 496);
            this.buttonViewComputer.Name = "buttonViewComputer";
            this.buttonViewComputer.Size = new System.Drawing.Size(24, 24);
            this.buttonViewComputer.TabIndex = 30;
            this.buttonViewComputer.UseVisualStyleBackColor = true;
            this.buttonViewComputer.Click += new System.EventHandler(this.buttonViewComputer_Click);
            // 
            // buttonAddComputer
            // 
            this.buttonAddComputer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddComputer.BackgroundImage")));
            this.buttonAddComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddComputer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddComputer.Location = new System.Drawing.Point(128, 496);
            this.buttonAddComputer.Name = "buttonAddComputer";
            this.buttonAddComputer.Size = new System.Drawing.Size(24, 24);
            this.buttonAddComputer.TabIndex = 26;
            this.buttonAddComputer.UseVisualStyleBackColor = true;
            this.buttonAddComputer.Click += new System.EventHandler(this.buttonAddComputer_Click);
            // 
            // labelComputerList
            // 
            this.labelComputerList.AutoSize = true;
            this.labelComputerList.Location = new System.Drawing.Point(8, 8);
            this.labelComputerList.Name = "labelComputerList";
            this.labelComputerList.Size = new System.Drawing.Size(57, 13);
            this.labelComputerList.TabIndex = 1;
            this.labelComputerList.Text = "Computers";
            // 
            // listViewAssociatedComputerList
            // 
            this.listViewAssociatedComputerList.FullRowSelect = true;
            this.listViewAssociatedComputerList.Location = new System.Drawing.Point(8, 58);
            this.listViewAssociatedComputerList.MultiSelect = false;
            this.listViewAssociatedComputerList.Name = "listViewAssociatedComputerList";
            this.listViewAssociatedComputerList.Size = new System.Drawing.Size(146, 434);
            this.listViewAssociatedComputerList.TabIndex = 0;
            this.listViewAssociatedComputerList.TileSize = new System.Drawing.Size(145, 48);
            this.listViewAssociatedComputerList.UseCompatibleStateImageBehavior = false;
            this.listViewAssociatedComputerList.View = System.Windows.Forms.View.Tile;
            this.listViewAssociatedComputerList.SelectedIndexChanged += new System.EventHandler(this.listViewAssociatedComputerList_SelectedIndexChanged);
            // 
            // groupBoxDriveDetails
            // 
            this.groupBoxDriveDetails.Controls.Add(this.textBoxHDDetails_Interface);
            this.groupBoxDriveDetails.Controls.Add(this.label42);
            this.groupBoxDriveDetails.Controls.Add(this.textBoxHDDetails_Serial);
            this.groupBoxDriveDetails.Controls.Add(this.textBoxHDDetails_Model);
            this.groupBoxDriveDetails.Controls.Add(this.textBoxHDDetails_Make);
            this.groupBoxDriveDetails.Controls.Add(this.labelHDMake);
            this.groupBoxDriveDetails.Controls.Add(this.labelHDModel);
            this.groupBoxDriveDetails.Controls.Add(this.labelHDSerial);
            this.groupBoxDriveDetails.Location = new System.Drawing.Point(553, 403);
            this.groupBoxDriveDetails.Name = "groupBoxDriveDetails";
            this.groupBoxDriveDetails.Size = new System.Drawing.Size(331, 112);
            this.groupBoxDriveDetails.TabIndex = 35;
            this.groupBoxDriveDetails.TabStop = false;
            this.groupBoxDriveDetails.Text = "Drive Details";
            // 
            // textBoxHDDetails_Interface
            // 
            this.textBoxHDDetails_Interface.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDDetails_Interface.Enabled = false;
            this.textBoxHDDetails_Interface.Location = new System.Drawing.Point(48, 83);
            this.textBoxHDDetails_Interface.Name = "textBoxHDDetails_Interface";
            this.textBoxHDDetails_Interface.ReadOnly = true;
            this.textBoxHDDetails_Interface.Size = new System.Drawing.Size(272, 20);
            this.textBoxHDDetails_Interface.TabIndex = 189;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label42.Location = new System.Drawing.Point(6, 89);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(28, 13);
            this.label42.TabIndex = 188;
            this.label42.Text = "Int  :";
            // 
            // textBoxHDDetails_Serial
            // 
            this.textBoxHDDetails_Serial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDDetails_Serial.Enabled = false;
            this.textBoxHDDetails_Serial.Location = new System.Drawing.Point(48, 60);
            this.textBoxHDDetails_Serial.Name = "textBoxHDDetails_Serial";
            this.textBoxHDDetails_Serial.ReadOnly = true;
            this.textBoxHDDetails_Serial.Size = new System.Drawing.Size(272, 20);
            this.textBoxHDDetails_Serial.TabIndex = 186;
            // 
            // textBoxHDDetails_Model
            // 
            this.textBoxHDDetails_Model.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDDetails_Model.Enabled = false;
            this.textBoxHDDetails_Model.Location = new System.Drawing.Point(48, 37);
            this.textBoxHDDetails_Model.Name = "textBoxHDDetails_Model";
            this.textBoxHDDetails_Model.ReadOnly = true;
            this.textBoxHDDetails_Model.Size = new System.Drawing.Size(272, 20);
            this.textBoxHDDetails_Model.TabIndex = 185;
            // 
            // textBoxHDDetails_Make
            // 
            this.textBoxHDDetails_Make.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDDetails_Make.Enabled = false;
            this.textBoxHDDetails_Make.Location = new System.Drawing.Point(48, 14);
            this.textBoxHDDetails_Make.Name = "textBoxHDDetails_Make";
            this.textBoxHDDetails_Make.ReadOnly = true;
            this.textBoxHDDetails_Make.Size = new System.Drawing.Size(272, 20);
            this.textBoxHDDetails_Make.TabIndex = 184;
            // 
            // labelHDMake
            // 
            this.labelHDMake.AutoSize = true;
            this.labelHDMake.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHDMake.Location = new System.Drawing.Point(6, 18);
            this.labelHDMake.Name = "labelHDMake";
            this.labelHDMake.Size = new System.Drawing.Size(40, 13);
            this.labelHDMake.TabIndex = 133;
            this.labelHDMake.Text = "Make: ";
            // 
            // labelHDModel
            // 
            this.labelHDModel.AutoSize = true;
            this.labelHDModel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHDModel.Location = new System.Drawing.Point(6, 41);
            this.labelHDModel.Name = "labelHDModel";
            this.labelHDModel.Size = new System.Drawing.Size(42, 13);
            this.labelHDModel.TabIndex = 134;
            this.labelHDModel.Text = "Model :";
            // 
            // labelHDSerial
            // 
            this.labelHDSerial.AutoSize = true;
            this.labelHDSerial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHDSerial.Location = new System.Drawing.Point(6, 64);
            this.labelHDSerial.Name = "labelHDSerial";
            this.labelHDSerial.Size = new System.Drawing.Size(39, 13);
            this.labelHDSerial.TabIndex = 135;
            this.labelHDSerial.Text = "Serial :";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.buttonViewDetailsHardDriveListView);
            this.tabPage2.Controls.Add(this.buttonViewTileHardDriveListView);
            this.tabPage2.Controls.Add(this.lblListOfHardDrives);
            this.tabPage2.Controls.Add(this.buttonDeleteHardDrives);
            this.tabPage2.Controls.Add(this.buttonEditHardDrives);
            this.tabPage2.Controls.Add(this.buttonViewHardDrives);
            this.tabPage2.Controls.Add(this.buttonAddHardDrives);
            this.tabPage2.Controls.Add(this.listViewHardDrivesOnHardDrivePage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hard Drive";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBoxRelatedComputer);
            this.groupBox2.Controls.Add(this.panelRaid);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Location = new System.Drawing.Point(160, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 509);
            this.groupBox2.TabIndex = 195;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hard Drive Details";
            // 
            // groupBoxRelatedComputer
            // 
            this.groupBoxRelatedComputer.Controls.Add(this.pictureBoxRelatedComputer);
            this.groupBoxRelatedComputer.Controls.Add(this.panelRelatedComputerGeneralInfo);
            this.groupBoxRelatedComputer.Controls.Add(this.panelRelatedComputerSystemInformation);
            this.groupBoxRelatedComputer.Location = new System.Drawing.Point(232, 12);
            this.groupBoxRelatedComputer.Name = "groupBoxRelatedComputer";
            this.groupBoxRelatedComputer.Size = new System.Drawing.Size(489, 341);
            this.groupBoxRelatedComputer.TabIndex = 194;
            this.groupBoxRelatedComputer.TabStop = false;
            this.groupBoxRelatedComputer.Text = "Related Computer";
            // 
            // pictureBoxRelatedComputer
            // 
            this.pictureBoxRelatedComputer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxRelatedComputer.Location = new System.Drawing.Point(340, 13);
            this.pictureBoxRelatedComputer.Name = "pictureBoxRelatedComputer";
            this.pictureBoxRelatedComputer.Size = new System.Drawing.Size(147, 154);
            this.pictureBoxRelatedComputer.TabIndex = 172;
            this.pictureBoxRelatedComputer.TabStop = false;
            // 
            // panelRelatedComputerGeneralInfo
            // 
            this.panelRelatedComputerGeneralInfo.Controls.Add(this.labelHDCompType);
            this.panelRelatedComputerGeneralInfo.Controls.Add(this.textBoxHDRelatedComputerType);
            this.panelRelatedComputerGeneralInfo.Controls.Add(this.label45);
            this.panelRelatedComputerGeneralInfo.Controls.Add(this.labelHDCompSvcTage);
            this.panelRelatedComputerGeneralInfo.Controls.Add(this.textBoxHDRelatedComputerSvcTag);
            this.panelRelatedComputerGeneralInfo.Controls.Add(this.labelHDCompSerialNum);
            this.panelRelatedComputerGeneralInfo.Controls.Add(this.textBoxHDRelatedComputerSerialNum);
            this.panelRelatedComputerGeneralInfo.Controls.Add(this.labelHDCompModel);
            this.panelRelatedComputerGeneralInfo.Controls.Add(this.labelHDCompMake);
            this.panelRelatedComputerGeneralInfo.Controls.Add(this.textBoxHDRelatedComputerModel);
            this.panelRelatedComputerGeneralInfo.Controls.Add(this.textBoxHDRelatedComputerMake);
            this.panelRelatedComputerGeneralInfo.Location = new System.Drawing.Point(6, 11);
            this.panelRelatedComputerGeneralInfo.Name = "panelRelatedComputerGeneralInfo";
            this.panelRelatedComputerGeneralInfo.Size = new System.Drawing.Size(323, 156);
            this.panelRelatedComputerGeneralInfo.TabIndex = 171;
            // 
            // labelHDCompType
            // 
            this.labelHDCompType.AutoSize = true;
            this.labelHDCompType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHDCompType.Location = new System.Drawing.Point(3, 85);
            this.labelHDCompType.Name = "labelHDCompType";
            this.labelHDCompType.Size = new System.Drawing.Size(31, 13);
            this.labelHDCompType.TabIndex = 157;
            this.labelHDCompType.Text = "Type";
            // 
            // textBoxHDRelatedComputerType
            // 
            this.textBoxHDRelatedComputerType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedComputerType.Location = new System.Drawing.Point(95, 81);
            this.textBoxHDRelatedComputerType.Name = "textBoxHDRelatedComputerType";
            this.textBoxHDRelatedComputerType.ReadOnly = true;
            this.textBoxHDRelatedComputerType.Size = new System.Drawing.Size(225, 20);
            this.textBoxHDRelatedComputerType.TabIndex = 158;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(3, 2);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(272, 24);
            this.label45.TabIndex = 154;
            this.label45.Text = "Related Computer General Info";
            // 
            // labelHDCompSvcTage
            // 
            this.labelHDCompSvcTage.AutoSize = true;
            this.labelHDCompSvcTage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHDCompSvcTage.Location = new System.Drawing.Point(3, 135);
            this.labelHDCompSvcTage.Name = "labelHDCompSvcTage";
            this.labelHDCompSvcTage.Size = new System.Drawing.Size(48, 13);
            this.labelHDCompSvcTage.TabIndex = 130;
            this.labelHDCompSvcTage.Text = "Svc Tag";
            // 
            // textBoxHDRelatedComputerSvcTag
            // 
            this.textBoxHDRelatedComputerSvcTag.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedComputerSvcTag.Location = new System.Drawing.Point(95, 131);
            this.textBoxHDRelatedComputerSvcTag.Name = "textBoxHDRelatedComputerSvcTag";
            this.textBoxHDRelatedComputerSvcTag.ReadOnly = true;
            this.textBoxHDRelatedComputerSvcTag.Size = new System.Drawing.Size(225, 20);
            this.textBoxHDRelatedComputerSvcTag.TabIndex = 134;
            // 
            // labelHDCompSerialNum
            // 
            this.labelHDCompSerialNum.AutoSize = true;
            this.labelHDCompSerialNum.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHDCompSerialNum.Location = new System.Drawing.Point(3, 110);
            this.labelHDCompSerialNum.Name = "labelHDCompSerialNum";
            this.labelHDCompSerialNum.Size = new System.Drawing.Size(43, 13);
            this.labelHDCompSerialNum.TabIndex = 129;
            this.labelHDCompSerialNum.Text = "Serial #";
            // 
            // textBoxHDRelatedComputerSerialNum
            // 
            this.textBoxHDRelatedComputerSerialNum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedComputerSerialNum.Location = new System.Drawing.Point(94, 106);
            this.textBoxHDRelatedComputerSerialNum.Name = "textBoxHDRelatedComputerSerialNum";
            this.textBoxHDRelatedComputerSerialNum.ReadOnly = true;
            this.textBoxHDRelatedComputerSerialNum.Size = new System.Drawing.Size(226, 20);
            this.textBoxHDRelatedComputerSerialNum.TabIndex = 133;
            // 
            // labelHDCompModel
            // 
            this.labelHDCompModel.AutoSize = true;
            this.labelHDCompModel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHDCompModel.Location = new System.Drawing.Point(3, 60);
            this.labelHDCompModel.Name = "labelHDCompModel";
            this.labelHDCompModel.Size = new System.Drawing.Size(36, 13);
            this.labelHDCompModel.TabIndex = 128;
            this.labelHDCompModel.Text = "Model";
            // 
            // labelHDCompMake
            // 
            this.labelHDCompMake.AutoSize = true;
            this.labelHDCompMake.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelHDCompMake.Location = new System.Drawing.Point(3, 35);
            this.labelHDCompMake.Name = "labelHDCompMake";
            this.labelHDCompMake.Size = new System.Drawing.Size(34, 13);
            this.labelHDCompMake.TabIndex = 135;
            this.labelHDCompMake.Text = "Make";
            // 
            // textBoxHDRelatedComputerModel
            // 
            this.textBoxHDRelatedComputerModel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedComputerModel.Location = new System.Drawing.Point(95, 56);
            this.textBoxHDRelatedComputerModel.Name = "textBoxHDRelatedComputerModel";
            this.textBoxHDRelatedComputerModel.ReadOnly = true;
            this.textBoxHDRelatedComputerModel.Size = new System.Drawing.Size(225, 20);
            this.textBoxHDRelatedComputerModel.TabIndex = 137;
            // 
            // textBoxHDRelatedComputerMake
            // 
            this.textBoxHDRelatedComputerMake.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedComputerMake.Location = new System.Drawing.Point(94, 31);
            this.textBoxHDRelatedComputerMake.Name = "textBoxHDRelatedComputerMake";
            this.textBoxHDRelatedComputerMake.ReadOnly = true;
            this.textBoxHDRelatedComputerMake.Size = new System.Drawing.Size(226, 20);
            this.textBoxHDRelatedComputerMake.TabIndex = 136;
            // 
            // panelRelatedComputerSystemInformation
            // 
            this.panelRelatedComputerSystemInformation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelRelatedComputerSystemInformation.Controls.Add(this.textBoxHDRelatedCompSysInfoHostname);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.textBoxHDRelatedCompSysInfoHostedSystem);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.textBoxHDRelatedCompSysInfoVirtualMachine);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.textBoxHDRelatedCompSysInfoServer);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.textBoxHDRelatedCompSysInfoServerType);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.label50);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.label51);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.label52);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.label53);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.label54);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.textBoxHDRelatedCompSysInfoPoweredOn);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.textBoxHDRelatedCompSysInfoShutDownBy);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.textBoxHDRelatedCompSysInfoAppsRunning);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.label55);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.textBoxHDRelatedCompSysInfoSystemRunning);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.textBoxHDRelatedCompSysInfoPulledPlug);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.label56);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.label57);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.label58);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.label59);
            this.panelRelatedComputerSystemInformation.Controls.Add(this.label60);
            this.panelRelatedComputerSystemInformation.Location = new System.Drawing.Point(6, 176);
            this.panelRelatedComputerSystemInformation.Name = "panelRelatedComputerSystemInformation";
            this.panelRelatedComputerSystemInformation.Size = new System.Drawing.Size(483, 152);
            this.panelRelatedComputerSystemInformation.TabIndex = 170;
            // 
            // textBoxHDRelatedCompSysInfoHostname
            // 
            this.textBoxHDRelatedCompSysInfoHostname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedCompSysInfoHostname.Enabled = false;
            this.textBoxHDRelatedCompSysInfoHostname.Location = new System.Drawing.Point(338, 128);
            this.textBoxHDRelatedCompSysInfoHostname.Name = "textBoxHDRelatedCompSysInfoHostname";
            this.textBoxHDRelatedCompSysInfoHostname.ReadOnly = true;
            this.textBoxHDRelatedCompSysInfoHostname.Size = new System.Drawing.Size(139, 20);
            this.textBoxHDRelatedCompSysInfoHostname.TabIndex = 182;
            // 
            // textBoxHDRelatedCompSysInfoHostedSystem
            // 
            this.textBoxHDRelatedCompSysInfoHostedSystem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedCompSysInfoHostedSystem.Enabled = false;
            this.textBoxHDRelatedCompSysInfoHostedSystem.Location = new System.Drawing.Point(338, 102);
            this.textBoxHDRelatedCompSysInfoHostedSystem.Name = "textBoxHDRelatedCompSysInfoHostedSystem";
            this.textBoxHDRelatedCompSysInfoHostedSystem.ReadOnly = true;
            this.textBoxHDRelatedCompSysInfoHostedSystem.Size = new System.Drawing.Size(139, 20);
            this.textBoxHDRelatedCompSysInfoHostedSystem.TabIndex = 183;
            // 
            // textBoxHDRelatedCompSysInfoVirtualMachine
            // 
            this.textBoxHDRelatedCompSysInfoVirtualMachine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedCompSysInfoVirtualMachine.Enabled = false;
            this.textBoxHDRelatedCompSysInfoVirtualMachine.Location = new System.Drawing.Point(339, 75);
            this.textBoxHDRelatedCompSysInfoVirtualMachine.Name = "textBoxHDRelatedCompSysInfoVirtualMachine";
            this.textBoxHDRelatedCompSysInfoVirtualMachine.ReadOnly = true;
            this.textBoxHDRelatedCompSysInfoVirtualMachine.Size = new System.Drawing.Size(139, 20);
            this.textBoxHDRelatedCompSysInfoVirtualMachine.TabIndex = 179;
            // 
            // textBoxHDRelatedCompSysInfoServer
            // 
            this.textBoxHDRelatedCompSysInfoServer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedCompSysInfoServer.Enabled = false;
            this.textBoxHDRelatedCompSysInfoServer.Location = new System.Drawing.Point(338, 25);
            this.textBoxHDRelatedCompSysInfoServer.Name = "textBoxHDRelatedCompSysInfoServer";
            this.textBoxHDRelatedCompSysInfoServer.ReadOnly = true;
            this.textBoxHDRelatedCompSysInfoServer.Size = new System.Drawing.Size(140, 20);
            this.textBoxHDRelatedCompSysInfoServer.TabIndex = 180;
            // 
            // textBoxHDRelatedCompSysInfoServerType
            // 
            this.textBoxHDRelatedCompSysInfoServerType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedCompSysInfoServerType.Enabled = false;
            this.textBoxHDRelatedCompSysInfoServerType.Location = new System.Drawing.Point(339, 49);
            this.textBoxHDRelatedCompSysInfoServerType.Name = "textBoxHDRelatedCompSysInfoServerType";
            this.textBoxHDRelatedCompSysInfoServerType.ReadOnly = true;
            this.textBoxHDRelatedCompSysInfoServerType.Size = new System.Drawing.Size(139, 20);
            this.textBoxHDRelatedCompSysInfoServerType.TabIndex = 181;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label50.Location = new System.Drawing.Point(249, 132);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(55, 13);
            this.label50.TabIndex = 176;
            this.label50.Text = "Hostname";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label51.Location = new System.Drawing.Point(249, 53);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(74, 13);
            this.label51.TabIndex = 178;
            this.label51.Text = "Server Type? ";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label52.Location = new System.Drawing.Point(249, 79);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(85, 13);
            this.label52.TabIndex = 175;
            this.label52.Text = "Virtual machine?";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label53.Location = new System.Drawing.Point(249, 106);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(82, 13);
            this.label53.TabIndex = 177;
            this.label53.Text = "Hosted system?";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label54.Location = new System.Drawing.Point(249, 29);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(47, 13);
            this.label54.TabIndex = 174;
            this.label54.Text = "Server? ";
            // 
            // textBoxHDRelatedCompSysInfoPoweredOn
            // 
            this.textBoxHDRelatedCompSysInfoPoweredOn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedCompSysInfoPoweredOn.Enabled = false;
            this.textBoxHDRelatedCompSysInfoPoweredOn.Location = new System.Drawing.Point(95, 128);
            this.textBoxHDRelatedCompSysInfoPoweredOn.Name = "textBoxHDRelatedCompSysInfoPoweredOn";
            this.textBoxHDRelatedCompSysInfoPoweredOn.ReadOnly = true;
            this.textBoxHDRelatedCompSysInfoPoweredOn.Size = new System.Drawing.Size(137, 20);
            this.textBoxHDRelatedCompSysInfoPoweredOn.TabIndex = 172;
            // 
            // textBoxHDRelatedCompSysInfoShutDownBy
            // 
            this.textBoxHDRelatedCompSysInfoShutDownBy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedCompSysInfoShutDownBy.Enabled = false;
            this.textBoxHDRelatedCompSysInfoShutDownBy.Location = new System.Drawing.Point(95, 102);
            this.textBoxHDRelatedCompSysInfoShutDownBy.Name = "textBoxHDRelatedCompSysInfoShutDownBy";
            this.textBoxHDRelatedCompSysInfoShutDownBy.ReadOnly = true;
            this.textBoxHDRelatedCompSysInfoShutDownBy.Size = new System.Drawing.Size(137, 20);
            this.textBoxHDRelatedCompSysInfoShutDownBy.TabIndex = 173;
            // 
            // textBoxHDRelatedCompSysInfoAppsRunning
            // 
            this.textBoxHDRelatedCompSysInfoAppsRunning.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedCompSysInfoAppsRunning.Enabled = false;
            this.textBoxHDRelatedCompSysInfoAppsRunning.Location = new System.Drawing.Point(96, 75);
            this.textBoxHDRelatedCompSysInfoAppsRunning.Name = "textBoxHDRelatedCompSysInfoAppsRunning";
            this.textBoxHDRelatedCompSysInfoAppsRunning.ReadOnly = true;
            this.textBoxHDRelatedCompSysInfoAppsRunning.Size = new System.Drawing.Size(137, 20);
            this.textBoxHDRelatedCompSysInfoAppsRunning.TabIndex = 159;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label55.Location = new System.Drawing.Point(8, 132);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(70, 13);
            this.label55.TabIndex = 171;
            this.label55.Text = "Powered on?";
            // 
            // textBoxHDRelatedCompSysInfoSystemRunning
            // 
            this.textBoxHDRelatedCompSysInfoSystemRunning.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedCompSysInfoSystemRunning.Enabled = false;
            this.textBoxHDRelatedCompSysInfoSystemRunning.Location = new System.Drawing.Point(95, 25);
            this.textBoxHDRelatedCompSysInfoSystemRunning.Name = "textBoxHDRelatedCompSysInfoSystemRunning";
            this.textBoxHDRelatedCompSysInfoSystemRunning.ReadOnly = true;
            this.textBoxHDRelatedCompSysInfoSystemRunning.Size = new System.Drawing.Size(138, 20);
            this.textBoxHDRelatedCompSysInfoSystemRunning.TabIndex = 160;
            // 
            // textBoxHDRelatedCompSysInfoPulledPlug
            // 
            this.textBoxHDRelatedCompSysInfoPulledPlug.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRelatedCompSysInfoPulledPlug.Enabled = false;
            this.textBoxHDRelatedCompSysInfoPulledPlug.Location = new System.Drawing.Point(96, 49);
            this.textBoxHDRelatedCompSysInfoPulledPlug.Name = "textBoxHDRelatedCompSysInfoPulledPlug";
            this.textBoxHDRelatedCompSysInfoPulledPlug.ReadOnly = true;
            this.textBoxHDRelatedCompSysInfoPulledPlug.Size = new System.Drawing.Size(137, 20);
            this.textBoxHDRelatedCompSysInfoPulledPlug.TabIndex = 161;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label56.Location = new System.Drawing.Point(8, 79);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(78, 13);
            this.label56.TabIndex = 168;
            this.label56.Text = "Apps running? ";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label57.Location = new System.Drawing.Point(8, 106);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(78, 13);
            this.label57.TabIndex = 170;
            this.label57.Text = "Shut down by: ";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label58.Location = new System.Drawing.Point(8, 53);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(68, 13);
            this.label58.TabIndex = 169;
            this.label58.Text = "Pulled plug? ";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label59.Location = new System.Drawing.Point(8, 29);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(88, 13);
            this.label59.TabIndex = 167;
            this.label59.Text = "System running? ";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(3, 2);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(331, 24);
            this.label60.TabIndex = 166;
            this.label60.Text = "Related Computer System Information";
            // 
            // panelRaid
            // 
            this.panelRaid.Controls.Add(this.label65);
            this.panelRaid.Controls.Add(this.panelRelatedRaidInformation);
            this.panelRaid.Location = new System.Drawing.Point(232, 359);
            this.panelRaid.Name = "panelRaid";
            this.panelRaid.Size = new System.Drawing.Size(489, 141);
            this.panelRaid.TabIndex = 0;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(2, 1);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(116, 24);
            this.label65.TabIndex = 173;
            this.label65.Text = "Related Raid";
            // 
            // panelRelatedRaidInformation
            // 
            this.panelRelatedRaidInformation.Controls.Add(this.label66);
            this.panelRelatedRaidInformation.Controls.Add(this.listViewRelatedRaidonHDPage);
            this.panelRelatedRaidInformation.Controls.Add(this.textBoxHDRaidLevel);
            this.panelRelatedRaidInformation.Controls.Add(this.textBoxHDRaidHardwareOrSoftware);
            this.panelRelatedRaidInformation.Controls.Add(this.textBoxHDRaidType);
            this.panelRelatedRaidInformation.Controls.Add(this.label62);
            this.panelRelatedRaidInformation.Controls.Add(this.label63);
            this.panelRelatedRaidInformation.Controls.Add(this.label64);
            this.panelRelatedRaidInformation.Location = new System.Drawing.Point(0, 0);
            this.panelRelatedRaidInformation.Name = "panelRelatedRaidInformation";
            this.panelRelatedRaidInformation.Size = new System.Drawing.Size(487, 141);
            this.panelRelatedRaidInformation.TabIndex = 0;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label66.Location = new System.Drawing.Point(120, 27);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(102, 13);
            this.label66.TabIndex = 186;
            this.label66.Text = "Other Drives in Raid";
            // 
            // listViewRelatedRaidonHDPage
            // 
            this.listViewRelatedRaidonHDPage.Location = new System.Drawing.Point(123, 41);
            this.listViewRelatedRaidonHDPage.Name = "listViewRelatedRaidonHDPage";
            this.listViewRelatedRaidonHDPage.Size = new System.Drawing.Size(357, 96);
            this.listViewRelatedRaidonHDPage.TabIndex = 185;
            this.listViewRelatedRaidonHDPage.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxHDRaidLevel
            // 
            this.textBoxHDRaidLevel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRaidLevel.Enabled = false;
            this.textBoxHDRaidLevel.Location = new System.Drawing.Point(7, 117);
            this.textBoxHDRaidLevel.Name = "textBoxHDRaidLevel";
            this.textBoxHDRaidLevel.ReadOnly = true;
            this.textBoxHDRaidLevel.Size = new System.Drawing.Size(107, 20);
            this.textBoxHDRaidLevel.TabIndex = 179;
            // 
            // textBoxHDRaidHardwareOrSoftware
            // 
            this.textBoxHDRaidHardwareOrSoftware.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRaidHardwareOrSoftware.Enabled = false;
            this.textBoxHDRaidHardwareOrSoftware.Location = new System.Drawing.Point(7, 41);
            this.textBoxHDRaidHardwareOrSoftware.Name = "textBoxHDRaidHardwareOrSoftware";
            this.textBoxHDRaidHardwareOrSoftware.ReadOnly = true;
            this.textBoxHDRaidHardwareOrSoftware.Size = new System.Drawing.Size(107, 20);
            this.textBoxHDRaidHardwareOrSoftware.TabIndex = 180;
            // 
            // textBoxHDRaidType
            // 
            this.textBoxHDRaidType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDRaidType.Enabled = false;
            this.textBoxHDRaidType.Location = new System.Drawing.Point(7, 78);
            this.textBoxHDRaidType.Name = "textBoxHDRaidType";
            this.textBoxHDRaidType.ReadOnly = true;
            this.textBoxHDRaidType.Size = new System.Drawing.Size(107, 20);
            this.textBoxHDRaidType.TabIndex = 181;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label62.Location = new System.Drawing.Point(3, 103);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(58, 13);
            this.label62.TabIndex = 183;
            this.label62.Text = "Raid Level";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label63.Location = new System.Drawing.Point(3, 64);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(31, 13);
            this.label63.TabIndex = 184;
            this.label63.Text = "Type";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label64.Location = new System.Drawing.Point(4, 27);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(110, 13);
            this.label64.TabIndex = 182;
            this.label64.Text = "Hardware or Software";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.textBoxHDFinishDateTimeOutput);
            this.panel8.Controls.Add(this.textBoxHDTechExaminerOutput);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Location = new System.Drawing.Point(10, 412);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(216, 88);
            this.panel8.TabIndex = 197;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 194;
            this.label8.Text = "CDF Info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(3, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 196;
            this.label12.Text = "Finsih Date/Time";
            // 
            // textBoxHDFinishDateTimeOutput
            // 
            this.textBoxHDFinishDateTimeOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDFinishDateTimeOutput.Enabled = false;
            this.textBoxHDFinishDateTimeOutput.Location = new System.Drawing.Point(94, 58);
            this.textBoxHDFinishDateTimeOutput.Name = "textBoxHDFinishDateTimeOutput";
            this.textBoxHDFinishDateTimeOutput.ReadOnly = true;
            this.textBoxHDFinishDateTimeOutput.Size = new System.Drawing.Size(114, 20);
            this.textBoxHDFinishDateTimeOutput.TabIndex = 195;
            // 
            // textBoxHDTechExaminerOutput
            // 
            this.textBoxHDTechExaminerOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDTechExaminerOutput.Enabled = false;
            this.textBoxHDTechExaminerOutput.Location = new System.Drawing.Point(94, 30);
            this.textBoxHDTechExaminerOutput.Name = "textBoxHDTechExaminerOutput";
            this.textBoxHDTechExaminerOutput.ReadOnly = true;
            this.textBoxHDTechExaminerOutput.Size = new System.Drawing.Size(114, 20);
            this.textBoxHDTechExaminerOutput.TabIndex = 193;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(1, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 192;
            this.label13.Text = "Texh/Examiner";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBoxHDJumperSettingsOutput);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.labelJumperDetails);
            this.panel6.Location = new System.Drawing.Point(10, 222);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(216, 184);
            this.panel6.TabIndex = 196;
            // 
            // textBoxHDJumperSettingsOutput
            // 
            this.textBoxHDJumperSettingsOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDJumperSettingsOutput.Location = new System.Drawing.Point(92, 26);
            this.textBoxHDJumperSettingsOutput.Name = "textBoxHDJumperSettingsOutput";
            this.textBoxHDJumperSettingsOutput.ReadOnly = true;
            this.textBoxHDJumperSettingsOutput.Size = new System.Drawing.Size(116, 20);
            this.textBoxHDJumperSettingsOutput.TabIndex = 173;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnlJumperDiagram);
            this.panel7.Controls.Add(this.labelJumperDiagram);
            this.panel7.Location = new System.Drawing.Point(5, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(206, 127);
            this.panel7.TabIndex = 179;
            // 
            // pnlJumperDiagram
            // 
            this.pnlJumperDiagram.BackColor = System.Drawing.Color.LightYellow;
            this.pnlJumperDiagram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJumperDiagram.Controls.Add(this.jumperPosition9);
            this.pnlJumperDiagram.Controls.Add(this.jumperPosition8);
            this.pnlJumperDiagram.Controls.Add(this.jumperPosition7);
            this.pnlJumperDiagram.Controls.Add(this.jumperPosition6);
            this.pnlJumperDiagram.Controls.Add(this.jumperPosition5);
            this.pnlJumperDiagram.Controls.Add(this.jumperPosition4);
            this.pnlJumperDiagram.Controls.Add(this.jumperPosition3);
            this.pnlJumperDiagram.Controls.Add(this.jumperPosition2);
            this.pnlJumperDiagram.Controls.Add(this.jumperPosition1);
            this.pnlJumperDiagram.Controls.Add(this.jumperPosition0);
            this.pnlJumperDiagram.Location = new System.Drawing.Point(11, 42);
            this.pnlJumperDiagram.Name = "pnlJumperDiagram";
            this.pnlJumperDiagram.Size = new System.Drawing.Size(185, 75);
            this.pnlJumperDiagram.TabIndex = 174;
            // 
            // jumperPosition9
            // 
            this.jumperPosition9.BackColor = System.Drawing.Color.Ivory;
            this.jumperPosition9.Enabled = false;
            this.jumperPosition9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jumperPosition9.Location = new System.Drawing.Point(148, 39);
            this.jumperPosition9.Name = "jumperPosition9";
            this.jumperPosition9.Size = new System.Drawing.Size(30, 30);
            this.jumperPosition9.TabIndex = 28;
            this.jumperPosition9.UseVisualStyleBackColor = false;
            // 
            // jumperPosition8
            // 
            this.jumperPosition8.BackColor = System.Drawing.Color.Ivory;
            this.jumperPosition8.Enabled = false;
            this.jumperPosition8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jumperPosition8.Location = new System.Drawing.Point(112, 39);
            this.jumperPosition8.Name = "jumperPosition8";
            this.jumperPosition8.Size = new System.Drawing.Size(30, 30);
            this.jumperPosition8.TabIndex = 28;
            this.jumperPosition8.UseVisualStyleBackColor = false;
            // 
            // jumperPosition7
            // 
            this.jumperPosition7.BackColor = System.Drawing.Color.Ivory;
            this.jumperPosition7.Enabled = false;
            this.jumperPosition7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jumperPosition7.Location = new System.Drawing.Point(75, 39);
            this.jumperPosition7.Name = "jumperPosition7";
            this.jumperPosition7.Size = new System.Drawing.Size(30, 30);
            this.jumperPosition7.TabIndex = 28;
            this.jumperPosition7.UseVisualStyleBackColor = false;
            // 
            // jumperPosition6
            // 
            this.jumperPosition6.BackColor = System.Drawing.Color.Ivory;
            this.jumperPosition6.Enabled = false;
            this.jumperPosition6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jumperPosition6.Location = new System.Drawing.Point(39, 39);
            this.jumperPosition6.Name = "jumperPosition6";
            this.jumperPosition6.Size = new System.Drawing.Size(30, 30);
            this.jumperPosition6.TabIndex = 28;
            this.jumperPosition6.UseVisualStyleBackColor = false;
            // 
            // jumperPosition5
            // 
            this.jumperPosition5.BackColor = System.Drawing.Color.Ivory;
            this.jumperPosition5.Enabled = false;
            this.jumperPosition5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jumperPosition5.Location = new System.Drawing.Point(4, 39);
            this.jumperPosition5.Name = "jumperPosition5";
            this.jumperPosition5.Size = new System.Drawing.Size(30, 30);
            this.jumperPosition5.TabIndex = 28;
            this.jumperPosition5.UseVisualStyleBackColor = false;
            // 
            // jumperPosition4
            // 
            this.jumperPosition4.BackColor = System.Drawing.Color.Ivory;
            this.jumperPosition4.Enabled = false;
            this.jumperPosition4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jumperPosition4.Location = new System.Drawing.Point(148, 4);
            this.jumperPosition4.Name = "jumperPosition4";
            this.jumperPosition4.Size = new System.Drawing.Size(30, 30);
            this.jumperPosition4.TabIndex = 27;
            this.jumperPosition4.UseVisualStyleBackColor = false;
            // 
            // jumperPosition3
            // 
            this.jumperPosition3.BackColor = System.Drawing.Color.Ivory;
            this.jumperPosition3.Enabled = false;
            this.jumperPosition3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jumperPosition3.Location = new System.Drawing.Point(112, 4);
            this.jumperPosition3.Name = "jumperPosition3";
            this.jumperPosition3.Size = new System.Drawing.Size(30, 30);
            this.jumperPosition3.TabIndex = 27;
            this.jumperPosition3.UseVisualStyleBackColor = false;
            // 
            // jumperPosition2
            // 
            this.jumperPosition2.BackColor = System.Drawing.Color.Ivory;
            this.jumperPosition2.Enabled = false;
            this.jumperPosition2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jumperPosition2.Location = new System.Drawing.Point(75, 4);
            this.jumperPosition2.Name = "jumperPosition2";
            this.jumperPosition2.Size = new System.Drawing.Size(30, 30);
            this.jumperPosition2.TabIndex = 27;
            this.jumperPosition2.UseVisualStyleBackColor = false;
            // 
            // jumperPosition1
            // 
            this.jumperPosition1.BackColor = System.Drawing.Color.Ivory;
            this.jumperPosition1.Enabled = false;
            this.jumperPosition1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jumperPosition1.Location = new System.Drawing.Point(39, 4);
            this.jumperPosition1.Name = "jumperPosition1";
            this.jumperPosition1.Size = new System.Drawing.Size(30, 30);
            this.jumperPosition1.TabIndex = 27;
            this.jumperPosition1.UseVisualStyleBackColor = false;
            // 
            // jumperPosition0
            // 
            this.jumperPosition0.BackColor = System.Drawing.Color.Ivory;
            this.jumperPosition0.Enabled = false;
            this.jumperPosition0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.jumperPosition0.Location = new System.Drawing.Point(4, 4);
            this.jumperPosition0.Name = "jumperPosition0";
            this.jumperPosition0.Size = new System.Drawing.Size(30, 30);
            this.jumperPosition0.TabIndex = 26;
            this.jumperPosition0.UseVisualStyleBackColor = false;
            // 
            // labelJumperDiagram
            // 
            this.labelJumperDiagram.AutoSize = true;
            this.labelJumperDiagram.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumperDiagram.Location = new System.Drawing.Point(32, 9);
            this.labelJumperDiagram.Name = "labelJumperDiagram";
            this.labelJumperDiagram.Size = new System.Drawing.Size(145, 24);
            this.labelJumperDiagram.TabIndex = 172;
            this.labelJumperDiagram.Text = "Jumper Diagram";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 172;
            this.label7.Text = "Jumper Settings";
            // 
            // labelJumperDetails
            // 
            this.labelJumperDetails.AutoSize = true;
            this.labelJumperDetails.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumperDetails.Location = new System.Drawing.Point(3, 2);
            this.labelJumperDetails.Name = "labelJumperDetails";
            this.labelJumperDetails.Size = new System.Drawing.Size(133, 24);
            this.labelJumperDetails.TabIndex = 171;
            this.labelJumperDetails.Text = "Jumper Details";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.textBoxHDTypeOutput);
            this.panel5.Controls.Add(this.textBoxHDDrivePositionOutput);
            this.panel5.Controls.Add(this.labelDrivePositionAsInstalled);
            this.panel5.Controls.Add(this.textBoxHDDriveInterfaceOutput);
            this.panel5.Controls.Add(this.labelDriveInteface);
            this.panel5.Controls.Add(this.lblHardDriveInformation);
            this.panel5.Controls.Add(this.lblHardDriveSize);
            this.panel5.Controls.Add(this.textBoxHDSizeOutput);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.textBoxHDSerialNumOutput);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.textBoxHDModelOutput);
            this.panel5.Controls.Add(this.textBoxHDMakeOutput);
            this.panel5.Location = new System.Drawing.Point(10, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 207);
            this.panel5.TabIndex = 193;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(4, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 175;
            this.label15.Text = "Type";
            // 
            // textBoxHDTypeOutput
            // 
            this.textBoxHDTypeOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDTypeOutput.Location = new System.Drawing.Point(58, 79);
            this.textBoxHDTypeOutput.Name = "textBoxHDTypeOutput";
            this.textBoxHDTypeOutput.ReadOnly = true;
            this.textBoxHDTypeOutput.Size = new System.Drawing.Size(150, 20);
            this.textBoxHDTypeOutput.TabIndex = 176;
            // 
            // textBoxHDDrivePositionOutput
            // 
            this.textBoxHDDrivePositionOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDDrivePositionOutput.Location = new System.Drawing.Point(85, 182);
            this.textBoxHDDrivePositionOutput.Name = "textBoxHDDrivePositionOutput";
            this.textBoxHDDrivePositionOutput.ReadOnly = true;
            this.textBoxHDDrivePositionOutput.Size = new System.Drawing.Size(123, 20);
            this.textBoxHDDrivePositionOutput.TabIndex = 174;
            // 
            // labelDrivePositionAsInstalled
            // 
            this.labelDrivePositionAsInstalled.AutoSize = true;
            this.labelDrivePositionAsInstalled.Location = new System.Drawing.Point(5, 182);
            this.labelDrivePositionAsInstalled.Name = "labelDrivePositionAsInstalled";
            this.labelDrivePositionAsInstalled.Size = new System.Drawing.Size(72, 13);
            this.labelDrivePositionAsInstalled.TabIndex = 173;
            this.labelDrivePositionAsInstalled.Text = "Drive Position";
            // 
            // textBoxHDDriveInterfaceOutput
            // 
            this.textBoxHDDriveInterfaceOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDDriveInterfaceOutput.Location = new System.Drawing.Point(85, 156);
            this.textBoxHDDriveInterfaceOutput.Name = "textBoxHDDriveInterfaceOutput";
            this.textBoxHDDriveInterfaceOutput.ReadOnly = true;
            this.textBoxHDDriveInterfaceOutput.Size = new System.Drawing.Size(123, 20);
            this.textBoxHDDriveInterfaceOutput.TabIndex = 172;
            // 
            // labelDriveInteface
            // 
            this.labelDriveInteface.AutoSize = true;
            this.labelDriveInteface.Location = new System.Drawing.Point(5, 159);
            this.labelDriveInteface.Name = "labelDriveInteface";
            this.labelDriveInteface.Size = new System.Drawing.Size(77, 13);
            this.labelDriveInteface.TabIndex = 171;
            this.labelDriveInteface.Text = "Drive Interface";
            // 
            // lblHardDriveInformation
            // 
            this.lblHardDriveInformation.AutoSize = true;
            this.lblHardDriveInformation.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardDriveInformation.Location = new System.Drawing.Point(3, 2);
            this.lblHardDriveInformation.Name = "lblHardDriveInformation";
            this.lblHardDriveInformation.Size = new System.Drawing.Size(202, 24);
            this.lblHardDriveInformation.TabIndex = 154;
            this.lblHardDriveInformation.Text = "Hard Drive information";
            // 
            // lblHardDriveSize
            // 
            this.lblHardDriveSize.AutoSize = true;
            this.lblHardDriveSize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHardDriveSize.Location = new System.Drawing.Point(4, 131);
            this.lblHardDriveSize.Name = "lblHardDriveSize";
            this.lblHardDriveSize.Size = new System.Drawing.Size(50, 13);
            this.lblHardDriveSize.TabIndex = 130;
            this.lblHardDriveSize.Text = "Size (Gb)";
            // 
            // textBoxHDSizeOutput
            // 
            this.textBoxHDSizeOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDSizeOutput.Location = new System.Drawing.Point(58, 127);
            this.textBoxHDSizeOutput.Name = "textBoxHDSizeOutput";
            this.textBoxHDSizeOutput.ReadOnly = true;
            this.textBoxHDSizeOutput.Size = new System.Drawing.Size(150, 20);
            this.textBoxHDSizeOutput.TabIndex = 134;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(4, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 129;
            this.label9.Text = "Serial #";
            // 
            // textBoxHDSerialNumOutput
            // 
            this.textBoxHDSerialNumOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDSerialNumOutput.Location = new System.Drawing.Point(58, 102);
            this.textBoxHDSerialNumOutput.Name = "textBoxHDSerialNumOutput";
            this.textBoxHDSerialNumOutput.ReadOnly = true;
            this.textBoxHDSerialNumOutput.Size = new System.Drawing.Size(150, 20);
            this.textBoxHDSerialNumOutput.TabIndex = 133;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(4, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 128;
            this.label10.Text = "Model";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(4, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 135;
            this.label11.Text = "Make";
            // 
            // textBoxHDModelOutput
            // 
            this.textBoxHDModelOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDModelOutput.Location = new System.Drawing.Point(58, 62);
            this.textBoxHDModelOutput.Name = "textBoxHDModelOutput";
            this.textBoxHDModelOutput.ReadOnly = true;
            this.textBoxHDModelOutput.Size = new System.Drawing.Size(150, 20);
            this.textBoxHDModelOutput.TabIndex = 137;
            // 
            // textBoxHDMakeOutput
            // 
            this.textBoxHDMakeOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxHDMakeOutput.Location = new System.Drawing.Point(58, 37);
            this.textBoxHDMakeOutput.Name = "textBoxHDMakeOutput";
            this.textBoxHDMakeOutput.ReadOnly = true;
            this.textBoxHDMakeOutput.Size = new System.Drawing.Size(150, 20);
            this.textBoxHDMakeOutput.TabIndex = 136;
            // 
            // buttonViewDetailsHardDriveListView
            // 
            this.buttonViewDetailsHardDriveListView.BackgroundImage = global::TrendWinForm.Properties.Resources.view_details;
            this.buttonViewDetailsHardDriveListView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonViewDetailsHardDriveListView.Location = new System.Drawing.Point(40, 28);
            this.buttonViewDetailsHardDriveListView.Name = "buttonViewDetailsHardDriveListView";
            this.buttonViewDetailsHardDriveListView.Size = new System.Drawing.Size(24, 24);
            this.buttonViewDetailsHardDriveListView.TabIndex = 194;
            this.buttonViewDetailsHardDriveListView.UseVisualStyleBackColor = true;
            this.buttonViewDetailsHardDriveListView.Click += new System.EventHandler(this.buttonViewDetailsHardDriveListView_Click);
            // 
            // buttonViewTileHardDriveListView
            // 
            this.buttonViewTileHardDriveListView.BackgroundImage = global::TrendWinForm.Properties.Resources.application_tile_horizontal;
            this.buttonViewTileHardDriveListView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonViewTileHardDriveListView.Location = new System.Drawing.Point(8, 28);
            this.buttonViewTileHardDriveListView.Name = "buttonViewTileHardDriveListView";
            this.buttonViewTileHardDriveListView.Size = new System.Drawing.Size(24, 24);
            this.buttonViewTileHardDriveListView.TabIndex = 193;
            this.buttonViewTileHardDriveListView.UseVisualStyleBackColor = true;
            this.buttonViewTileHardDriveListView.Click += new System.EventHandler(this.buttonViewTileHardDriveListView_Click);
            // 
            // lblListOfHardDrives
            // 
            this.lblListOfHardDrives.AutoSize = true;
            this.lblListOfHardDrives.Location = new System.Drawing.Point(8, 8);
            this.lblListOfHardDrives.Name = "lblListOfHardDrives";
            this.lblListOfHardDrives.Size = new System.Drawing.Size(63, 13);
            this.lblListOfHardDrives.TabIndex = 166;
            this.lblListOfHardDrives.Text = "Hard Drives";
            // 
            // buttonDeleteHardDrives
            // 
            this.buttonDeleteHardDrives.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteHardDrives.BackgroundImage")));
            this.buttonDeleteHardDrives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeleteHardDrives.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDeleteHardDrives.Location = new System.Drawing.Point(8, 496);
            this.buttonDeleteHardDrives.Name = "buttonDeleteHardDrives";
            this.buttonDeleteHardDrives.Size = new System.Drawing.Size(24, 24);
            this.buttonDeleteHardDrives.TabIndex = 165;
            this.buttonDeleteHardDrives.UseVisualStyleBackColor = true;
            // 
            // buttonEditHardDrives
            // 
            this.buttonEditHardDrives.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditHardDrives.BackgroundImage")));
            this.buttonEditHardDrives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditHardDrives.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEditHardDrives.Location = new System.Drawing.Point(48, 496);
            this.buttonEditHardDrives.Name = "buttonEditHardDrives";
            this.buttonEditHardDrives.Size = new System.Drawing.Size(24, 24);
            this.buttonEditHardDrives.TabIndex = 164;
            this.buttonEditHardDrives.UseVisualStyleBackColor = true;
            // 
            // buttonViewHardDrives
            // 
            this.buttonViewHardDrives.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonViewHardDrives.BackgroundImage")));
            this.buttonViewHardDrives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonViewHardDrives.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonViewHardDrives.Location = new System.Drawing.Point(88, 496);
            this.buttonViewHardDrives.Name = "buttonViewHardDrives";
            this.buttonViewHardDrives.Size = new System.Drawing.Size(24, 24);
            this.buttonViewHardDrives.TabIndex = 163;
            this.buttonViewHardDrives.UseVisualStyleBackColor = true;
            // 
            // buttonAddHardDrives
            // 
            this.buttonAddHardDrives.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddHardDrives.BackgroundImage")));
            this.buttonAddHardDrives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddHardDrives.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddHardDrives.Location = new System.Drawing.Point(128, 496);
            this.buttonAddHardDrives.Name = "buttonAddHardDrives";
            this.buttonAddHardDrives.Size = new System.Drawing.Size(24, 24);
            this.buttonAddHardDrives.TabIndex = 162;
            this.buttonAddHardDrives.UseVisualStyleBackColor = true;
            this.buttonAddHardDrives.Click += new System.EventHandler(this.buttonAddHardDrives_Click);
            // 
            // listViewHardDrivesOnHardDrivePage
            // 
            this.listViewHardDrivesOnHardDrivePage.FullRowSelect = true;
            this.listViewHardDrivesOnHardDrivePage.Location = new System.Drawing.Point(8, 58);
            this.listViewHardDrivesOnHardDrivePage.MultiSelect = false;
            this.listViewHardDrivesOnHardDrivePage.Name = "listViewHardDrivesOnHardDrivePage";
            this.listViewHardDrivesOnHardDrivePage.Size = new System.Drawing.Size(146, 434);
            this.listViewHardDrivesOnHardDrivePage.TabIndex = 161;
            this.listViewHardDrivesOnHardDrivePage.UseCompatibleStateImageBehavior = false;
            this.listViewHardDrivesOnHardDrivePage.View = System.Windows.Forms.View.Tile;
            this.listViewHardDrivesOnHardDrivePage.SelectedIndexChanged += new System.EventHandler(this.listViewHardDrivesOnHardDrivePage_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.listViewForensicProcesses);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.buttonViewSmallIconForensicProcessListView);
            this.tabPage3.Controls.Add(this.buttonViewTileForensicProcessListView);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.buttonDeleteForensicProcess);
            this.tabPage3.Controls.Add(this.buttonEditForensicProcess);
            this.tabPage3.Controls.Add(this.buttonViewForensicProcess);
            this.tabPage3.Controls.Add(this.buttonAddForensicProcess);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(896, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Forensics";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listViewForensicProcesses
            // 
            this.listViewForensicProcesses.Location = new System.Drawing.Point(8, 58);
            this.listViewForensicProcesses.MultiSelect = false;
            this.listViewForensicProcesses.Name = "listViewForensicProcesses";
            this.listViewForensicProcesses.Size = new System.Drawing.Size(146, 434);
            this.listViewForensicProcesses.TabIndex = 208;
            this.listViewForensicProcesses.TileSize = new System.Drawing.Size(145, 48);
            this.listViewForensicProcesses.UseCompatibleStateImageBehavior = false;
            this.listViewForensicProcesses.View = System.Windows.Forms.View.Tile;
            this.listViewForensicProcesses.SelectedIndexChanged += new System.EventHandler(this.listViewForensicProcesses_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelAssociatedHardDrives);
            this.groupBox4.Controls.Add(this.labelAssociatedcomputers);
            this.groupBox4.Controls.Add(this.labelDestinationMediaInfo);
            this.groupBox4.Controls.Add(this.listViewFPAssociatedHardDrives);
            this.groupBox4.Controls.Add(this.listViewFPAssociatedComputers);
            this.groupBox4.Controls.Add(this.listViewFPDestinationMediae);
            this.groupBox4.Controls.Add(this.panel13);
            this.groupBox4.Controls.Add(this.panel12);
            this.groupBox4.Controls.Add(this.panel10);
            this.groupBox4.Controls.Add(this.panel9);
            this.groupBox4.Location = new System.Drawing.Point(160, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(727, 509);
            this.groupBox4.TabIndex = 207;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Forensic Process Details";
            // 
            // labelAssociatedHardDrives
            // 
            this.labelAssociatedHardDrives.AutoSize = true;
            this.labelAssociatedHardDrives.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssociatedHardDrives.Location = new System.Drawing.Point(231, 352);
            this.labelAssociatedHardDrives.Name = "labelAssociatedHardDrives";
            this.labelAssociatedHardDrives.Size = new System.Drawing.Size(201, 24);
            this.labelAssociatedHardDrives.TabIndex = 217;
            this.labelAssociatedHardDrives.Text = "Associated Hard Drives";
            // 
            // labelAssociatedcomputers
            // 
            this.labelAssociatedcomputers.AutoSize = true;
            this.labelAssociatedcomputers.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssociatedcomputers.Location = new System.Drawing.Point(231, 182);
            this.labelAssociatedcomputers.Name = "labelAssociatedcomputers";
            this.labelAssociatedcomputers.Size = new System.Drawing.Size(197, 24);
            this.labelAssociatedcomputers.TabIndex = 215;
            this.labelAssociatedcomputers.Text = "Associated Computers";
            // 
            // labelDestinationMediaInfo
            // 
            this.labelDestinationMediaInfo.AutoSize = true;
            this.labelDestinationMediaInfo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestinationMediaInfo.Location = new System.Drawing.Point(231, 14);
            this.labelDestinationMediaInfo.Name = "labelDestinationMediaInfo";
            this.labelDestinationMediaInfo.Size = new System.Drawing.Size(173, 24);
            this.labelDestinationMediaInfo.TabIndex = 214;
            this.labelDestinationMediaInfo.Text = "Destination Mediae";
            // 
            // listViewFPAssociatedHardDrives
            // 
            this.listViewFPAssociatedHardDrives.FullRowSelect = true;
            this.listViewFPAssociatedHardDrives.Location = new System.Drawing.Point(233, 378);
            this.listViewFPAssociatedHardDrives.Name = "listViewFPAssociatedHardDrives";
            this.listViewFPAssociatedHardDrives.Size = new System.Drawing.Size(485, 128);
            this.listViewFPAssociatedHardDrives.TabIndex = 212;
            this.listViewFPAssociatedHardDrives.UseCompatibleStateImageBehavior = false;
            // 
            // listViewFPAssociatedComputers
            // 
            this.listViewFPAssociatedComputers.FullRowSelect = true;
            this.listViewFPAssociatedComputers.Location = new System.Drawing.Point(233, 209);
            this.listViewFPAssociatedComputers.Name = "listViewFPAssociatedComputers";
            this.listViewFPAssociatedComputers.Size = new System.Drawing.Size(485, 128);
            this.listViewFPAssociatedComputers.TabIndex = 211;
            this.listViewFPAssociatedComputers.UseCompatibleStateImageBehavior = false;
            // 
            // listViewFPDestinationMediae
            // 
            this.listViewFPDestinationMediae.FullRowSelect = true;
            this.listViewFPDestinationMediae.Location = new System.Drawing.Point(233, 40);
            this.listViewFPDestinationMediae.Name = "listViewFPDestinationMediae";
            this.listViewFPDestinationMediae.Size = new System.Drawing.Size(485, 128);
            this.listViewFPDestinationMediae.TabIndex = 210;
            this.listViewFPDestinationMediae.UseCompatibleStateImageBehavior = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label17);
            this.panel13.Controls.Add(this.textBoxFPCDFTechExaminer);
            this.panel13.Controls.Add(this.label19);
            this.panel13.Controls.Add(this.textBoxFPFinishDateTime);
            this.panel13.Controls.Add(this.label18);
            this.panel13.Location = new System.Drawing.Point(9, 425);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(217, 76);
            this.panel13.TabIndex = 209;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 24);
            this.label17.TabIndex = 194;
            this.label17.Text = "CDF Info";
            // 
            // textBoxFPCDFTechExaminer
            // 
            this.textBoxFPCDFTechExaminer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFPCDFTechExaminer.Enabled = false;
            this.textBoxFPCDFTechExaminer.Location = new System.Drawing.Point(106, 20);
            this.textBoxFPCDFTechExaminer.Name = "textBoxFPCDFTechExaminer";
            this.textBoxFPCDFTechExaminer.ReadOnly = true;
            this.textBoxFPCDFTechExaminer.Size = new System.Drawing.Size(105, 20);
            this.textBoxFPCDFTechExaminer.TabIndex = 193;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(8, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 13);
            this.label19.TabIndex = 192;
            this.label19.Text = "Texh/Examiner";
            // 
            // textBoxFPFinishDateTime
            // 
            this.textBoxFPFinishDateTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFPFinishDateTime.Enabled = false;
            this.textBoxFPFinishDateTime.Location = new System.Drawing.Point(106, 46);
            this.textBoxFPFinishDateTime.Name = "textBoxFPFinishDateTime";
            this.textBoxFPFinishDateTime.ReadOnly = true;
            this.textBoxFPFinishDateTime.Size = new System.Drawing.Size(107, 20);
            this.textBoxFPFinishDateTime.TabIndex = 195;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(8, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 13);
            this.label18.TabIndex = 196;
            this.label18.Text = "Finsih Date/Time";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.textBoxFPImagesVerifiedBy);
            this.panel12.Controls.Add(this.labelImagesVerifiedBy);
            this.panel12.Controls.Add(this.textBoxFPImagesMade);
            this.panel12.Controls.Add(this.labelImagesMade);
            this.panel12.Controls.Add(this.labelImageInforamtion);
            this.panel12.Location = new System.Drawing.Point(10, 328);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(217, 87);
            this.panel12.TabIndex = 208;
            // 
            // textBoxFPImagesVerifiedBy
            // 
            this.textBoxFPImagesVerifiedBy.Location = new System.Drawing.Point(109, 58);
            this.textBoxFPImagesVerifiedBy.Name = "textBoxFPImagesVerifiedBy";
            this.textBoxFPImagesVerifiedBy.ReadOnly = true;
            this.textBoxFPImagesVerifiedBy.Size = new System.Drawing.Size(95, 20);
            this.textBoxFPImagesVerifiedBy.TabIndex = 205;
            // 
            // labelImagesVerifiedBy
            // 
            this.labelImagesVerifiedBy.AutoSize = true;
            this.labelImagesVerifiedBy.Location = new System.Drawing.Point(5, 59);
            this.labelImagesVerifiedBy.Name = "labelImagesVerifiedBy";
            this.labelImagesVerifiedBy.Size = new System.Drawing.Size(94, 13);
            this.labelImagesVerifiedBy.TabIndex = 204;
            this.labelImagesVerifiedBy.Text = "Images Verified By";
            // 
            // textBoxFPImagesMade
            // 
            this.textBoxFPImagesMade.Location = new System.Drawing.Point(109, 29);
            this.textBoxFPImagesMade.Name = "textBoxFPImagesMade";
            this.textBoxFPImagesMade.ReadOnly = true;
            this.textBoxFPImagesMade.Size = new System.Drawing.Size(95, 20);
            this.textBoxFPImagesMade.TabIndex = 201;
            // 
            // labelImagesMade
            // 
            this.labelImagesMade.AutoSize = true;
            this.labelImagesMade.Location = new System.Drawing.Point(5, 33);
            this.labelImagesMade.Name = "labelImagesMade";
            this.labelImagesMade.Size = new System.Drawing.Size(71, 13);
            this.labelImagesMade.TabIndex = 200;
            this.labelImagesMade.Text = "Images Made";
            // 
            // labelImageInforamtion
            // 
            this.labelImageInforamtion.AutoSize = true;
            this.labelImageInforamtion.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImageInforamtion.Location = new System.Drawing.Point(3, 2);
            this.labelImageInforamtion.Name = "labelImageInforamtion";
            this.labelImageInforamtion.Size = new System.Drawing.Size(164, 24);
            this.labelImageInforamtion.TabIndex = 199;
            this.labelImageInforamtion.Text = "Image Information";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.textBoxFPSoftware);
            this.panel10.Controls.Add(this.labelSoftware);
            this.panel10.Controls.Add(this.textBoxFPDeviceUsed);
            this.panel10.Controls.Add(this.labelForensicDeviceUsed);
            this.panel10.Controls.Add(this.textBoxFPProcessPerformed);
            this.panel10.Controls.Add(this.labelProcessingPerformed);
            this.panel10.Controls.Add(this.labelProcessingInformation);
            this.panel10.Location = new System.Drawing.Point(10, 207);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(216, 111);
            this.panel10.TabIndex = 206;
            // 
            // textBoxFPSoftware
            // 
            this.textBoxFPSoftware.Location = new System.Drawing.Point(109, 83);
            this.textBoxFPSoftware.Name = "textBoxFPSoftware";
            this.textBoxFPSoftware.ReadOnly = true;
            this.textBoxFPSoftware.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPSoftware.TabIndex = 206;
            // 
            // labelSoftware
            // 
            this.labelSoftware.AutoSize = true;
            this.labelSoftware.Location = new System.Drawing.Point(7, 87);
            this.labelSoftware.Name = "labelSoftware";
            this.labelSoftware.Size = new System.Drawing.Size(49, 13);
            this.labelSoftware.TabIndex = 205;
            this.labelSoftware.Text = "Software";
            // 
            // textBoxFPDeviceUsed
            // 
            this.textBoxFPDeviceUsed.Location = new System.Drawing.Point(109, 55);
            this.textBoxFPDeviceUsed.Name = "textBoxFPDeviceUsed";
            this.textBoxFPDeviceUsed.ReadOnly = true;
            this.textBoxFPDeviceUsed.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPDeviceUsed.TabIndex = 204;
            // 
            // labelForensicDeviceUsed
            // 
            this.labelForensicDeviceUsed.AutoSize = true;
            this.labelForensicDeviceUsed.Location = new System.Drawing.Point(7, 59);
            this.labelForensicDeviceUsed.Name = "labelForensicDeviceUsed";
            this.labelForensicDeviceUsed.Size = new System.Drawing.Size(69, 13);
            this.labelForensicDeviceUsed.TabIndex = 203;
            this.labelForensicDeviceUsed.Text = "Device Used";
            // 
            // textBoxFPProcessPerformed
            // 
            this.textBoxFPProcessPerformed.Location = new System.Drawing.Point(109, 31);
            this.textBoxFPProcessPerformed.Name = "textBoxFPProcessPerformed";
            this.textBoxFPProcessPerformed.ReadOnly = true;
            this.textBoxFPProcessPerformed.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPProcessPerformed.TabIndex = 202;
            // 
            // labelProcessingPerformed
            // 
            this.labelProcessingPerformed.AutoSize = true;
            this.labelProcessingPerformed.Location = new System.Drawing.Point(7, 35);
            this.labelProcessingPerformed.Name = "labelProcessingPerformed";
            this.labelProcessingPerformed.Size = new System.Drawing.Size(96, 13);
            this.labelProcessingPerformed.TabIndex = 201;
            this.labelProcessingPerformed.Text = "Process Performed";
            // 
            // labelProcessingInformation
            // 
            this.labelProcessingInformation.AutoSize = true;
            this.labelProcessingInformation.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessingInformation.Location = new System.Drawing.Point(3, 2);
            this.labelProcessingInformation.Name = "labelProcessingInformation";
            this.labelProcessingInformation.Size = new System.Drawing.Size(201, 24);
            this.labelProcessingInformation.TabIndex = 200;
            this.labelProcessingInformation.Text = "Processing Information";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.textBoxFPHardDriveOnly);
            this.panel9.Controls.Add(this.textBoxFPImageOnly);
            this.panel9.Controls.Add(this.textBoxFPPhotosTaken);
            this.panel9.Controls.Add(this.labelHardDriveOnly);
            this.panel9.Controls.Add(this.labelImageOnly);
            this.panel9.Controls.Add(this.labelPhotosTaken);
            this.panel9.Controls.Add(this.textBoxFPCustodianOrUser);
            this.panel9.Controls.Add(this.textBoxFPRoomNumber);
            this.panel9.Controls.Add(this.labelCustodainOrUser);
            this.panel9.Controls.Add(this.labelRoomNumber);
            this.panel9.Controls.Add(this.textBoxFPCollectionLocationOutput);
            this.panel9.Controls.Add(this.label4CollectionLocation);
            this.panel9.Controls.Add(this.label4CollectionInformation);
            this.panel9.Location = new System.Drawing.Point(10, 14);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(216, 183);
            this.panel9.TabIndex = 205;
            // 
            // textBoxFPHardDriveOnly
            // 
            this.textBoxFPHardDriveOnly.Location = new System.Drawing.Point(107, 154);
            this.textBoxFPHardDriveOnly.Name = "textBoxFPHardDriveOnly";
            this.textBoxFPHardDriveOnly.ReadOnly = true;
            this.textBoxFPHardDriveOnly.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPHardDriveOnly.TabIndex = 209;
            // 
            // textBoxFPImageOnly
            // 
            this.textBoxFPImageOnly.Location = new System.Drawing.Point(107, 129);
            this.textBoxFPImageOnly.Name = "textBoxFPImageOnly";
            this.textBoxFPImageOnly.ReadOnly = true;
            this.textBoxFPImageOnly.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPImageOnly.TabIndex = 208;
            // 
            // textBoxFPPhotosTaken
            // 
            this.textBoxFPPhotosTaken.Location = new System.Drawing.Point(107, 104);
            this.textBoxFPPhotosTaken.Name = "textBoxFPPhotosTaken";
            this.textBoxFPPhotosTaken.ReadOnly = true;
            this.textBoxFPPhotosTaken.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPPhotosTaken.TabIndex = 207;
            // 
            // labelHardDriveOnly
            // 
            this.labelHardDriveOnly.AutoSize = true;
            this.labelHardDriveOnly.Location = new System.Drawing.Point(8, 158);
            this.labelHardDriveOnly.Name = "labelHardDriveOnly";
            this.labelHardDriveOnly.Size = new System.Drawing.Size(82, 13);
            this.labelHardDriveOnly.TabIndex = 206;
            this.labelHardDriveOnly.Text = "Hard Drive Only";
            // 
            // labelImageOnly
            // 
            this.labelImageOnly.AutoSize = true;
            this.labelImageOnly.Location = new System.Drawing.Point(8, 133);
            this.labelImageOnly.Name = "labelImageOnly";
            this.labelImageOnly.Size = new System.Drawing.Size(60, 13);
            this.labelImageOnly.TabIndex = 205;
            this.labelImageOnly.Text = "Image Only";
            // 
            // labelPhotosTaken
            // 
            this.labelPhotosTaken.AutoSize = true;
            this.labelPhotosTaken.Location = new System.Drawing.Point(8, 108);
            this.labelPhotosTaken.Name = "labelPhotosTaken";
            this.labelPhotosTaken.Size = new System.Drawing.Size(74, 13);
            this.labelPhotosTaken.TabIndex = 204;
            this.labelPhotosTaken.Text = "Photos Taken";
            // 
            // textBoxFPCustodianOrUser
            // 
            this.textBoxFPCustodianOrUser.Location = new System.Drawing.Point(107, 79);
            this.textBoxFPCustodianOrUser.Name = "textBoxFPCustodianOrUser";
            this.textBoxFPCustodianOrUser.ReadOnly = true;
            this.textBoxFPCustodianOrUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPCustodianOrUser.TabIndex = 203;
            // 
            // textBoxFPRoomNumber
            // 
            this.textBoxFPRoomNumber.Location = new System.Drawing.Point(107, 54);
            this.textBoxFPRoomNumber.Name = "textBoxFPRoomNumber";
            this.textBoxFPRoomNumber.ReadOnly = true;
            this.textBoxFPRoomNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPRoomNumber.TabIndex = 202;
            // 
            // labelCustodainOrUser
            // 
            this.labelCustodainOrUser.AutoSize = true;
            this.labelCustodainOrUser.Location = new System.Drawing.Point(8, 83);
            this.labelCustodainOrUser.Name = "labelCustodainOrUser";
            this.labelCustodainOrUser.Size = new System.Drawing.Size(81, 13);
            this.labelCustodainOrUser.TabIndex = 201;
            this.labelCustodainOrUser.Text = "Custodain/User";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Location = new System.Drawing.Point(8, 58);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(75, 13);
            this.labelRoomNumber.TabIndex = 200;
            this.labelRoomNumber.Text = "Room Number";
            // 
            // textBoxFPCollectionLocationOutput
            // 
            this.textBoxFPCollectionLocationOutput.AcceptsReturn = true;
            this.textBoxFPCollectionLocationOutput.Location = new System.Drawing.Point(107, 26);
            this.textBoxFPCollectionLocationOutput.Name = "textBoxFPCollectionLocationOutput";
            this.textBoxFPCollectionLocationOutput.ReadOnly = true;
            this.textBoxFPCollectionLocationOutput.Size = new System.Drawing.Size(100, 20);
            this.textBoxFPCollectionLocationOutput.TabIndex = 199;
            // 
            // label4CollectionLocation
            // 
            this.label4CollectionLocation.AutoSize = true;
            this.label4CollectionLocation.Location = new System.Drawing.Point(8, 30);
            this.label4CollectionLocation.Name = "label4CollectionLocation";
            this.label4CollectionLocation.Size = new System.Drawing.Size(97, 13);
            this.label4CollectionLocation.TabIndex = 198;
            this.label4CollectionLocation.Text = "Collection Location";
            // 
            // label4CollectionInformation
            // 
            this.label4CollectionInformation.AutoSize = true;
            this.label4CollectionInformation.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4CollectionInformation.Location = new System.Drawing.Point(3, 2);
            this.label4CollectionInformation.Name = "label4CollectionInformation";
            this.label4CollectionInformation.Size = new System.Drawing.Size(197, 24);
            this.label4CollectionInformation.TabIndex = 197;
            this.label4CollectionInformation.Text = "Collection Information";
            // 
            // buttonViewSmallIconForensicProcessListView
            // 
            this.buttonViewSmallIconForensicProcessListView.BackgroundImage = global::TrendWinForm.Properties.Resources.view_details;
            this.buttonViewSmallIconForensicProcessListView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonViewSmallIconForensicProcessListView.Location = new System.Drawing.Point(40, 28);
            this.buttonViewSmallIconForensicProcessListView.Name = "buttonViewSmallIconForensicProcessListView";
            this.buttonViewSmallIconForensicProcessListView.Size = new System.Drawing.Size(24, 24);
            this.buttonViewSmallIconForensicProcessListView.TabIndex = 206;
            this.buttonViewSmallIconForensicProcessListView.UseVisualStyleBackColor = true;
            this.buttonViewSmallIconForensicProcessListView.Click += new System.EventHandler(this.buttonViewSmallIconForensicProcessListView_Click);
            // 
            // buttonViewTileForensicProcessListView
            // 
            this.buttonViewTileForensicProcessListView.BackgroundImage = global::TrendWinForm.Properties.Resources.application_tile_horizontal;
            this.buttonViewTileForensicProcessListView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonViewTileForensicProcessListView.Location = new System.Drawing.Point(8, 28);
            this.buttonViewTileForensicProcessListView.Name = "buttonViewTileForensicProcessListView";
            this.buttonViewTileForensicProcessListView.Size = new System.Drawing.Size(24, 24);
            this.buttonViewTileForensicProcessListView.TabIndex = 205;
            this.buttonViewTileForensicProcessListView.UseVisualStyleBackColor = true;
            this.buttonViewTileForensicProcessListView.Click += new System.EventHandler(this.buttonViewTileForensicProcessListView_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 172;
            this.label14.Text = "Forensic Processes";
            // 
            // buttonDeleteForensicProcess
            // 
            this.buttonDeleteForensicProcess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteForensicProcess.BackgroundImage")));
            this.buttonDeleteForensicProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeleteForensicProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDeleteForensicProcess.Location = new System.Drawing.Point(8, 496);
            this.buttonDeleteForensicProcess.Name = "buttonDeleteForensicProcess";
            this.buttonDeleteForensicProcess.Size = new System.Drawing.Size(24, 24);
            this.buttonDeleteForensicProcess.TabIndex = 171;
            this.buttonDeleteForensicProcess.UseVisualStyleBackColor = true;
            // 
            // buttonEditForensicProcess
            // 
            this.buttonEditForensicProcess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditForensicProcess.BackgroundImage")));
            this.buttonEditForensicProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditForensicProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEditForensicProcess.Location = new System.Drawing.Point(48, 496);
            this.buttonEditForensicProcess.Name = "buttonEditForensicProcess";
            this.buttonEditForensicProcess.Size = new System.Drawing.Size(24, 24);
            this.buttonEditForensicProcess.TabIndex = 170;
            this.buttonEditForensicProcess.UseVisualStyleBackColor = true;
            // 
            // buttonViewForensicProcess
            // 
            this.buttonViewForensicProcess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonViewForensicProcess.BackgroundImage")));
            this.buttonViewForensicProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonViewForensicProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonViewForensicProcess.Location = new System.Drawing.Point(88, 496);
            this.buttonViewForensicProcess.Name = "buttonViewForensicProcess";
            this.buttonViewForensicProcess.Size = new System.Drawing.Size(24, 24);
            this.buttonViewForensicProcess.TabIndex = 169;
            this.buttonViewForensicProcess.UseVisualStyleBackColor = true;
            // 
            // buttonAddForensicProcess
            // 
            this.buttonAddForensicProcess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddForensicProcess.BackgroundImage")));
            this.buttonAddForensicProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddForensicProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddForensicProcess.Location = new System.Drawing.Point(128, 496);
            this.buttonAddForensicProcess.Name = "buttonAddForensicProcess";
            this.buttonAddForensicProcess.Size = new System.Drawing.Size(24, 24);
            this.buttonAddForensicProcess.TabIndex = 168;
            this.buttonAddForensicProcess.UseVisualStyleBackColor = true;
            this.buttonAddForensicProcess.Click += new System.EventHandler(this.buttonAddForensicProcess_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonRemoveActiveUserFile);
            this.tabPage5.Controls.Add(this.buttonEditActiveUserFile);
            this.tabPage5.Controls.Add(this.buttonViewActiveUserFile);
            this.tabPage5.Controls.Add(this.buttonAddActiveUserFiles);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.listViewAUFActiveUserFiles);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(896, 528);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Active User Files";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveActiveUserFile
            // 
            this.buttonRemoveActiveUserFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRemoveActiveUserFile.BackgroundImage")));
            this.buttonRemoveActiveUserFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRemoveActiveUserFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRemoveActiveUserFile.Location = new System.Drawing.Point(767, 8);
            this.buttonRemoveActiveUserFile.Name = "buttonRemoveActiveUserFile";
            this.buttonRemoveActiveUserFile.Size = new System.Drawing.Size(24, 24);
            this.buttonRemoveActiveUserFile.TabIndex = 220;
            this.buttonRemoveActiveUserFile.UseVisualStyleBackColor = true;
            this.buttonRemoveActiveUserFile.Click += new System.EventHandler(this.buttonRemoveActiveUserFile_Click);
            // 
            // buttonEditActiveUserFile
            // 
            this.buttonEditActiveUserFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditActiveUserFile.BackgroundImage")));
            this.buttonEditActiveUserFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditActiveUserFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEditActiveUserFile.Location = new System.Drawing.Point(799, 8);
            this.buttonEditActiveUserFile.Name = "buttonEditActiveUserFile";
            this.buttonEditActiveUserFile.Size = new System.Drawing.Size(24, 24);
            this.buttonEditActiveUserFile.TabIndex = 219;
            this.buttonEditActiveUserFile.UseVisualStyleBackColor = true;
            this.buttonEditActiveUserFile.Click += new System.EventHandler(this.buttonEditActiveUserFile_Click);
            // 
            // buttonViewActiveUserFile
            // 
            this.buttonViewActiveUserFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonViewActiveUserFile.BackgroundImage")));
            this.buttonViewActiveUserFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonViewActiveUserFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonViewActiveUserFile.Location = new System.Drawing.Point(831, 8);
            this.buttonViewActiveUserFile.Name = "buttonViewActiveUserFile";
            this.buttonViewActiveUserFile.Size = new System.Drawing.Size(24, 24);
            this.buttonViewActiveUserFile.TabIndex = 218;
            this.buttonViewActiveUserFile.UseVisualStyleBackColor = true;
            this.buttonViewActiveUserFile.Click += new System.EventHandler(this.buttonViewActiveUserFile_Click);
            // 
            // buttonAddActiveUserFiles
            // 
            this.buttonAddActiveUserFiles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddActiveUserFiles.BackgroundImage")));
            this.buttonAddActiveUserFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddActiveUserFiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddActiveUserFiles.Location = new System.Drawing.Point(863, 8);
            this.buttonAddActiveUserFiles.Name = "buttonAddActiveUserFiles";
            this.buttonAddActiveUserFiles.Size = new System.Drawing.Size(24, 24);
            this.buttonAddActiveUserFiles.TabIndex = 217;
            this.buttonAddActiveUserFiles.UseVisualStyleBackColor = true;
            this.buttonAddActiveUserFiles.Click += new System.EventHandler(this.buttonAddActiveUserFiles_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 24);
            this.label16.TabIndex = 216;
            this.label16.Text = "Active User Files";
            // 
            // listViewAUFActiveUserFiles
            // 
            this.listViewAUFActiveUserFiles.FullRowSelect = true;
            this.listViewAUFActiveUserFiles.Location = new System.Drawing.Point(9, 34);
            this.listViewAUFActiveUserFiles.Name = "listViewAUFActiveUserFiles";
            this.listViewAUFActiveUserFiles.Size = new System.Drawing.Size(879, 488);
            this.listViewAUFActiveUserFiles.TabIndex = 215;
            this.listViewAUFActiveUserFiles.UseCompatibleStateImageBehavior = false;
            this.listViewAUFActiveUserFiles.View = System.Windows.Forms.View.Details;
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage4.Controls.Add(this.labelConclusionLabel);
            this.tabPage4.Controls.Add(this.textBoxConclusion);
            this.tabPage4.Controls.Add(this.panel14);
            this.tabPage4.Controls.Add(this.labelNotesLabel);
            this.tabPage4.Controls.Add(this.textBoxNACNotes);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(896, 528);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Notes and Conclusion";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelConclusionLabel
            // 
            this.labelConclusionLabel.AutoSize = true;
            this.labelConclusionLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConclusionLabel.Location = new System.Drawing.Point(3, 190);
            this.labelConclusionLabel.Name = "labelConclusionLabel";
            this.labelConclusionLabel.Size = new System.Drawing.Size(102, 24);
            this.labelConclusionLabel.TabIndex = 212;
            this.labelConclusionLabel.Text = "Conclusion";
            // 
            // textBoxConclusion
            // 
            this.textBoxConclusion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxConclusion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConclusion.Location = new System.Drawing.Point(7, 216);
            this.textBoxConclusion.MaxLength = 100000;
            this.textBoxConclusion.Multiline = true;
            this.textBoxConclusion.Name = "textBoxConclusion";
            this.textBoxConclusion.Size = new System.Drawing.Size(879, 229);
            this.textBoxConclusion.TabIndex = 211;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.AddEmployee2);
            this.panel14.Controls.Add(this.comboBoxCdfInfoTech);
            this.panel14.Controls.Add(this.dateTimePickerCDFDate);
            this.panel14.Controls.Add(this.labelCDFFinishDateTime);
            this.panel14.Controls.Add(this.label41);
            this.panel14.Controls.Add(this.labelCdfInfo);
            this.panel14.Location = new System.Drawing.Point(6, 460);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(594, 60);
            this.panel14.TabIndex = 210;
            // 
            // AddEmployee2
            // 
            this.AddEmployee2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddEmployee2.BackgroundImage")));
            this.AddEmployee2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddEmployee2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddEmployee2.Location = new System.Drawing.Point(249, 30);
            this.AddEmployee2.Name = "AddEmployee2";
            this.AddEmployee2.Size = new System.Drawing.Size(24, 24);
            this.AddEmployee2.TabIndex = 201;
            this.AddEmployee2.UseVisualStyleBackColor = true;
            // 
            // comboBoxCdfInfoTech
            // 
            this.comboBoxCdfInfoTech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCdfInfoTech.FormattingEnabled = true;
            this.comboBoxCdfInfoTech.Location = new System.Drawing.Point(85, 32);
            this.comboBoxCdfInfoTech.Name = "comboBoxCdfInfoTech";
            this.comboBoxCdfInfoTech.Size = new System.Drawing.Size(152, 21);
            this.comboBoxCdfInfoTech.TabIndex = 200;
            // 
            // dateTimePickerCDFDate
            // 
            this.dateTimePickerCDFDate.Location = new System.Drawing.Point(374, 32);
            this.dateTimePickerCDFDate.Name = "dateTimePickerCDFDate";
            this.dateTimePickerCDFDate.Size = new System.Drawing.Size(198, 20);
            this.dateTimePickerCDFDate.TabIndex = 198;
            // 
            // labelCDFFinishDateTime
            // 
            this.labelCDFFinishDateTime.AutoSize = true;
            this.labelCDFFinishDateTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCDFFinishDateTime.Location = new System.Drawing.Point(283, 36);
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
            // labelNotesLabel
            // 
            this.labelNotesLabel.AutoSize = true;
            this.labelNotesLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotesLabel.Location = new System.Drawing.Point(3, 5);
            this.labelNotesLabel.Name = "labelNotesLabel";
            this.labelNotesLabel.Size = new System.Drawing.Size(59, 24);
            this.labelNotesLabel.TabIndex = 155;
            this.labelNotesLabel.Text = "Notes";
            // 
            // textBoxNACNotes
            // 
            this.textBoxNACNotes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNACNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNACNotes.Location = new System.Drawing.Point(8, 29);
            this.textBoxNACNotes.MaxLength = 100000;
            this.textBoxNACNotes.Multiline = true;
            this.textBoxNACNotes.Name = "textBoxNACNotes";
            this.textBoxNACNotes.Size = new System.Drawing.Size(879, 159);
            this.textBoxNACNotes.TabIndex = 136;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Create_Case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(921, 721);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Create_Case";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Case";
            this.Shown += new System.EventHandler(this.Create_Case_Shown);
            this.Click += new System.EventHandler(this.Create_Case_Click);
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxHardDriveDetails.ResumeLayout(false);
            this.groupBoxComputerDetails.ResumeLayout(false);
            this.groupBoxComputerDetails.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxDriveDetails.ResumeLayout(false);
            this.groupBoxDriveDetails.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxRelatedComputer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRelatedComputer)).EndInit();
            this.panelRelatedComputerGeneralInfo.ResumeLayout(false);
            this.panelRelatedComputerGeneralInfo.PerformLayout();
            this.panelRelatedComputerSystemInformation.ResumeLayout(false);
            this.panelRelatedComputerSystemInformation.PerformLayout();
            this.panelRaid.ResumeLayout(false);
            this.panelRaid.PerformLayout();
            this.panelRelatedRaidInformation.ResumeLayout(false);
            this.panelRelatedRaidInformation.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pnlJumperDiagram.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TrendDataSet trendDataSet;
        private System.Windows.Forms.BindingSource caseBindingSource;
        private TrendDataSetTableAdapters.CaseTableAdapter caseTableAdapter;
        private TrendDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox itemNumberTextBox;
        private System.Windows.Forms.TextBox matterTextBox;
        private System.Windows.Forms.TextBox caseNumberTextBox;
        private System.Windows.Forms.DateTimePicker barcodeDateVerifiedDateTimePicker;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button AddFirmContact;
        private System.Windows.Forms.Button AddFirm;
        private System.Windows.Forms.ComboBox examiner_idComboBox;
        private System.Windows.Forms.ComboBox requester_idComboBox;
        private System.Windows.Forms.ComboBox firm_idComboBox;
        private System.Windows.Forms.Button ViewEmployee;
        private System.Windows.Forms.Button ViewFirmContact;
        private System.Windows.Forms.Button ViewFirm;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listViewAssociatedComputerList;
        private System.Windows.Forms.Button buttonAddComputer;
        private System.Windows.Forms.Label labelComputerList;
        private System.Windows.Forms.Button buttonViewComputer;
        private System.Windows.Forms.Button buttonDeleteComputer;
        private System.Windows.Forms.Button buttonEditComputer;
        private System.Windows.Forms.GroupBox groupBoxComputerDetails;
        private System.Windows.Forms.GroupBox groupBoxHardDriveDetails;
        internal System.Windows.Forms.TextBox txtMakeOutput;
        internal System.Windows.Forms.TextBox txtModelOutput;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox txtSerialNum;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.TextBox txtSvcTag;
        internal System.Windows.Forms.Label Label20;
        private System.Windows.Forms.Label labelComputerRaid;
        private System.Windows.Forms.Label labelComputerInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.TextBox txtCMOSChangesMade;
        internal System.Windows.Forms.Label Label32;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtWasCMOSChanged;
        internal System.Windows.Forms.TextBox txtSetupKeystroke;
        internal System.Windows.Forms.TextBox txtTimeProvidedBy;
        internal System.Windows.Forms.TextBox txtActualTime;
        internal System.Windows.Forms.TextBox txtActualDate;
        internal System.Windows.Forms.TextBox txtCMOSTime;
        internal System.Windows.Forms.TextBox txtCMOSDate;
        internal System.Windows.Forms.TextBox txtWasItPoweredOn;
        internal System.Windows.Forms.TextBox txtShutDownBy;
        internal System.Windows.Forms.TextBox txtAppsRunning;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.TextBox txtSystemRunning;
        internal System.Windows.Forms.TextBox txtPulledPlug;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.TextBox txtHostname;
        internal System.Windows.Forms.TextBox txtHostedSystem;
        internal System.Windows.Forms.TextBox txtVirtualMachine;
        internal System.Windows.Forms.TextBox txtWasItAServer;
        internal System.Windows.Forms.TextBox txtServerType;
        internal System.Windows.Forms.Label Label40;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label Label38;
        internal System.Windows.Forms.Label Label39;
        internal System.Windows.Forms.Label Label29;
        private System.Windows.Forms.GroupBox groupBoxDriveDetails;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtFinishDateTime;
        internal System.Windows.Forms.TextBox txtTechExaminer;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblListOfHardDrives;
        private System.Windows.Forms.Button buttonDeleteHardDrives;
        private System.Windows.Forms.Button buttonEditHardDrives;
        private System.Windows.Forms.Button buttonViewHardDrives;
        private System.Windows.Forms.Button buttonAddHardDrives;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonViewTileComputerListView;
        private System.Windows.Forms.Button buttonViewDetailsComputerListView;
        internal System.Windows.Forms.TextBox textBoxNACNotes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonDeleteForensicProcess;
        private System.Windows.Forms.Button buttonEditForensicProcess;
        private System.Windows.Forms.Button buttonViewForensicProcess;
        private System.Windows.Forms.Button buttonAddForensicProcess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox textBoxHDFinishDateTimeOutput;
        internal System.Windows.Forms.TextBox textBoxHDTechExaminerOutput;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelJumperDiagram;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelJumperDetails;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelDrivePositionAsInstalled;
        private System.Windows.Forms.Label labelDriveInteface;
        private System.Windows.Forms.Label lblHardDriveInformation;
        internal System.Windows.Forms.Label lblHardDriveSize;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonViewDetailsHardDriveListView;
        private System.Windows.Forms.Button buttonViewTileHardDriveListView;
        private System.Windows.Forms.Button buttonViewSmallIconForensicProcessListView;
        private System.Windows.Forms.Button buttonViewTileForensicProcessListView;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label labelNotesLabel;
        internal System.Windows.Forms.Label labelType;
        internal System.Windows.Forms.TextBox txtTypeOutput;
        private System.Windows.Forms.ListView listViewHardDrivesOnHardDrivePage;
        private System.Windows.Forms.ListView listViewComputerAssociatedHardDrives;
        private System.Windows.Forms.ListView listViewAssociatedRaids;
        internal System.Windows.Forms.Label labelHDMake;
        internal System.Windows.Forms.Label labelHDModel;
        internal System.Windows.Forms.Label labelHDSerial;
        internal System.Windows.Forms.TextBox textBoxHDDetails_Serial;
        internal System.Windows.Forms.TextBox textBoxHDDetails_Model;
        internal System.Windows.Forms.TextBox textBoxHDDetails_Make;
        internal System.Windows.Forms.TextBox textBoxHDDetails_Interface;
        internal System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listViewFPDestinationMediae;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label labelImagesMade;
        private System.Windows.Forms.Label labelImageInforamtion;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelSoftware;
        private System.Windows.Forms.Label labelForensicDeviceUsed;
        private System.Windows.Forms.Label labelProcessingPerformed;
        private System.Windows.Forms.Label labelProcessingInformation;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label labelHardDriveOnly;
        private System.Windows.Forms.Label labelImageOnly;
        private System.Windows.Forms.Label labelPhotosTaken;
        private System.Windows.Forms.Label labelCustodainOrUser;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label label4CollectionLocation;
        private System.Windows.Forms.Label label4CollectionInformation;
        private System.Windows.Forms.ListView listViewFPAssociatedHardDrives;
        private System.Windows.Forms.ListView listViewFPAssociatedComputers;
        private System.Windows.Forms.Label labelImagesVerifiedBy;
        public System.Windows.Forms.TextBox textBoxFPCollectionLocationOutput;
        public System.Windows.Forms.TextBox textBoxFPRoomNumber;
        public System.Windows.Forms.TextBox textBoxFPCDFTechExaminer;
        public System.Windows.Forms.TextBox textBoxFPFinishDateTime;
        public System.Windows.Forms.TextBox textBoxFPImagesMade;
        public System.Windows.Forms.TextBox textBoxFPSoftware;
        public System.Windows.Forms.TextBox textBoxFPDeviceUsed;
        public System.Windows.Forms.TextBox textBoxFPProcessPerformed;
        public System.Windows.Forms.TextBox textBoxFPHardDriveOnly;
        public System.Windows.Forms.TextBox textBoxFPImageOnly;
        public System.Windows.Forms.TextBox textBoxFPPhotosTaken;
        public System.Windows.Forms.TextBox textBoxFPCustodianOrUser;
        public System.Windows.Forms.TextBox textBoxFPImagesVerifiedBy;
        private System.Windows.Forms.Label labelDestinationMediaInfo;
        private System.Windows.Forms.Label labelAssociatedcomputers;
        private System.Windows.Forms.Label labelAssociatedHardDrives;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListView listViewForensicProcesses;
        public System.Windows.Forms.Panel panelRaid;
        private System.Windows.Forms.Label label65;
        public System.Windows.Forms.TextBox textBoxHDJumperSettingsOutput;
        public System.Windows.Forms.TextBox textBoxHDDrivePositionOutput;
        public System.Windows.Forms.TextBox textBoxHDDriveInterfaceOutput;
        public System.Windows.Forms.TextBox textBoxHDSizeOutput;
        public System.Windows.Forms.TextBox textBoxHDSerialNumOutput;
        public System.Windows.Forms.TextBox textBoxHDModelOutput;
        public System.Windows.Forms.TextBox textBoxHDMakeOutput;
        private System.Windows.Forms.Button AddEmployee2;
        private System.Windows.Forms.ComboBox comboBoxCdfInfoTech;
        private System.Windows.Forms.DateTimePicker dateTimePickerCDFDate;
        internal System.Windows.Forms.Label labelCDFFinishDateTime;
        internal System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label labelCdfInfo;
        internal System.Windows.Forms.Label label66;
        public System.Windows.Forms.ListView listViewRelatedRaidonHDPage;
        public System.Windows.Forms.TextBox textBoxHDRaidLevel;
        public System.Windows.Forms.TextBox textBoxHDRaidHardwareOrSoftware;
        public System.Windows.Forms.TextBox textBoxHDRaidType;
        internal System.Windows.Forms.Label label62;
        internal System.Windows.Forms.Label label63;
        internal System.Windows.Forms.Label label64;
        public System.Windows.Forms.Panel panelRelatedRaidInformation;
        public System.Windows.Forms.GroupBox groupBoxRelatedComputer;
        public System.Windows.Forms.PictureBox pictureBoxRelatedComputer;
        public System.Windows.Forms.Panel panelRelatedComputerGeneralInfo;
        internal System.Windows.Forms.Label labelHDCompType;
        public System.Windows.Forms.TextBox textBoxHDRelatedComputerType;
        private System.Windows.Forms.Label label45;
        internal System.Windows.Forms.Label labelHDCompSvcTage;
        public System.Windows.Forms.TextBox textBoxHDRelatedComputerSvcTag;
        internal System.Windows.Forms.Label labelHDCompSerialNum;
        public System.Windows.Forms.TextBox textBoxHDRelatedComputerSerialNum;
        internal System.Windows.Forms.Label labelHDCompModel;
        internal System.Windows.Forms.Label labelHDCompMake;
        public System.Windows.Forms.TextBox textBoxHDRelatedComputerModel;
        public System.Windows.Forms.TextBox textBoxHDRelatedComputerMake;
        public System.Windows.Forms.Panel panelRelatedComputerSystemInformation;
        public System.Windows.Forms.TextBox textBoxHDRelatedCompSysInfoHostname;
        public System.Windows.Forms.TextBox textBoxHDRelatedCompSysInfoHostedSystem;
        public System.Windows.Forms.TextBox textBoxHDRelatedCompSysInfoVirtualMachine;
        public System.Windows.Forms.TextBox textBoxHDRelatedCompSysInfoServer;
        public System.Windows.Forms.TextBox textBoxHDRelatedCompSysInfoServerType;
        internal System.Windows.Forms.Label label50;
        internal System.Windows.Forms.Label label51;
        internal System.Windows.Forms.Label label52;
        internal System.Windows.Forms.Label label53;
        internal System.Windows.Forms.Label label54;
        public System.Windows.Forms.TextBox textBoxHDRelatedCompSysInfoPoweredOn;
        public System.Windows.Forms.TextBox textBoxHDRelatedCompSysInfoShutDownBy;
        public System.Windows.Forms.TextBox textBoxHDRelatedCompSysInfoAppsRunning;
        internal System.Windows.Forms.Label label55;
        public System.Windows.Forms.TextBox textBoxHDRelatedCompSysInfoSystemRunning;
        public System.Windows.Forms.TextBox textBoxHDRelatedCompSysInfoPulledPlug;
        internal System.Windows.Forms.Label label56;
        internal System.Windows.Forms.Label label57;
        internal System.Windows.Forms.Label label58;
        internal System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        public System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonRemoveActiveUserFile;
        private System.Windows.Forms.Button buttonEditActiveUserFile;
        private System.Windows.Forms.Button buttonViewActiveUserFile;
        private System.Windows.Forms.Button buttonAddActiveUserFiles;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListView listViewAUFActiveUserFiles;
        private System.Windows.Forms.Label labelConclusionLabel;
        internal System.Windows.Forms.TextBox textBoxConclusion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        internal System.Windows.Forms.Panel pnlJumperDiagram;
        internal System.Windows.Forms.Button jumperPosition9;
        internal System.Windows.Forms.Button jumperPosition8;
        internal System.Windows.Forms.Button jumperPosition7;
        internal System.Windows.Forms.Button jumperPosition6;
        internal System.Windows.Forms.Button jumperPosition5;
        internal System.Windows.Forms.Button jumperPosition4;
        internal System.Windows.Forms.Button jumperPosition3;
        internal System.Windows.Forms.Button jumperPosition2;
        internal System.Windows.Forms.Button jumperPosition1;
        internal System.Windows.Forms.Button jumperPosition0;
        internal System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox textBoxHDTypeOutput;
    }
}
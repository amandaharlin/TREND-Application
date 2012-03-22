using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrendWinForm;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;
using TrendWinForm.MyUtilities;
using NHibernate.Criterion;

namespace TrendWinForm
{
    public partial class Create_Computer : Create_BaseForm
    {
        public Computer NewComputer { get; set; }

        public IList<HardDrive> ComputerHardDrives = new List<HardDrive>();
        public IList<Raid> ComputerRaids = new List<Raid>();


        private UtilityListFormHelper addMakeHelper;
        private UtilityListFormHelper addModelHelper;
        private UtilityListFormHelper addSetupkeystrokeHelper;
        private UtilityListFormHelper addTimeProvidedByHelper;
        private UtilityListFormHelper addServerType;


        private string formEditMode = "create";

        #region [constructors and intialization]
        public Create_Computer()
        {
            InitializeComponent();
            
            
            
        }

        public Create_Computer(Computer incomingComputer, string _formEditMode)
        {
            InitializeComponent();
           
            
            

            formEditMode = _formEditMode;
            NewComputer = incomingComputer;
        }

        private void Create_Computer_Shown(object sender, EventArgs e)
        {
            
            SetupFormComboBoxes();
            PopulateFormComboBoxes();
            InitForm();

            if (formEditMode.ToLower() == "edit")
            {
                PopulateFormWithComputer(NewComputer);
                FormTitleHelper.SetFormFormattingByEditMode(formEditMode, this, NewComputer.Make + " " + NewComputer.Model);
            }
            else if (formEditMode.ToLower() == "view")
            {
                PopulateFormWithComputer(NewComputer);
                FormTitleHelper.SetFormFormattingByEditMode(formEditMode, this, NewComputer.Make + " " + NewComputer.Model);
            }
        }

        private void PopulateFormWithComputer(Computer incomingComputer)
        {
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    if (incomingComputer.Id != Guid.Empty)
                    {
                        incomingComputer = session.CreateCriteria(typeof(Computer))
                       .Add(Restrictions.Eq("Id", incomingComputer.Id))
                       .UniqueResult<Computer>();
                    }

                    comboBoxMake.Text = incomingComputer.Make;
                    comboBoxModel.Text = incomingComputer.Model;
                    comboBoxType.Text = incomingComputer.Type;
                    txtSerialNum.Text = incomingComputer.SerialNumber;
                    txtSvcTag.Text = incomingComputer.SvcTag;
                    dateTimePickerCMOS.Value = incomingComputer.CmosDate;
                    dateTimePickerActualDate.Value = incomingComputer.CurrentDate;
                    comboBoxTimeProvidedBy.Text = incomingComputer.ActualTimeProvidedBy;
                    comboBoxSetupKeystroke.Text = incomingComputer.KeystrokeForCmosSetup;
                    checkBoxCmosChanged.Checked = incomingComputer.CmosWasChanged;
                    txtCMOSChangesMade.Text = incomingComputer.DescriptionOfCmosChanges;
                    checkBoxSystemWasRunning.Checked = incomingComputer.SystemWasRunning;
                    checkBoxPlugWasPulled.Checked = incomingComputer.PlugWasPulled;
                    checkBoxSystemWasPoweredOn.Checked = incomingComputer.WasPoweredOn;
                    checkBoxSystemWasServer.Checked = incomingComputer.WasServer;
                    checkBoxWasVirtualMachine.Checked = incomingComputer.WasVirtualMachine;
                    checkBoxWasHostedSystem.Checked = incomingComputer.WasHostedSystem;
                    comboBoxServerType.Text = incomingComputer.ServerType;
                    textBoxHostname.Text = incomingComputer.Hostname;

                    NewComputer = incomingComputer;
                    ComputerHardDrives = incomingComputer.HardDrives;
                    ComputerRaids = incomingComputer.Raids;

                    EntitiesToListView.FillHardDrivesListViewDetailView(ComputerHardDrives, listViewCreateComputerHardDrives);
                    EntitiesToListView.FillHardRaidsListViewDetailView(ComputerRaids, listViewCreateComputerRaid);

                    transaction.Commit();
                }
            }
        }




        private void InitForm()
        {
            checkBoxSystemWasServer.Enabled = false;
            comboBoxServerType.Enabled = false;
            textBoxHostname.Enabled = false;
            txtCMOSChangesMade.Enabled = false;
        
        }


        //General functions
        private void UpdateFormEvent(object sender, EventArgs e)
        {
            //Prevents wiping out combo boxes, if lists are edited.
            var comboBoxesList = UtilityQueries.ReturnDictionaryOfComboBoxes(this);
            PopulateFormComboBoxes();
            comboBoxesList.ToList().ForEach(c => { c.Key.SelectedIndex = c.Key.FindStringExact(c.Value); });
        }

        private void SetupFormComboBoxes()
        {
            addMakeHelper = new UtilityListFormHelper("Computer_Make", comboBoxMake, this);
            addModelHelper = new UtilityListFormHelper("Computer_Model", comboBoxModel, this);
            addSetupkeystrokeHelper = new UtilityListFormHelper("Computer_Setup_Keystroke", comboBoxSetupKeystroke, this);
            addTimeProvidedByHelper = new UtilityListFormHelper("Computer_Time_Provider", comboBoxTimeProvidedBy, this);
            addServerType = new UtilityListFormHelper("Computer_Server_Type", comboBoxServerType, this);
        }


        private void PopulateFormComboBoxes()
        {
            //Populate combo Boxes
            EntitiesToComboBox.FillEmployeeComboBox(comboBoxShutDownBy);
            EntitiesToComboBox.FillEmployeeComboBox(comboBoxCdfInfoTech);

            addMakeHelper.PopulateComboBoxWithUtilityStrings();
            addModelHelper.PopulateComboBoxWithUtilityStrings();
            addSetupkeystrokeHelper.PopulateComboBoxWithUtilityStrings();
            addTimeProvidedByHelper.PopulateComboBoxWithUtilityStrings();
            addServerType.PopulateComboBoxWithUtilityStrings();

            comboBoxType.Items.Clear();
            comboBoxType.Items.Add("Desktop");
            comboBoxType.Items.Add("Laptop");
            comboBoxType.Items.Add("Server");
            comboBoxType.Items.Add("Mobile");
            comboBoxType.Items.Add("Other");
        }

        #endregion

        #region [HD Crud]
        //Create HD fucntions
        private Create_HardDrive newHardDriveSubForm = null;
        private void buttonAddHardDrive_Click(object sender, EventArgs e)
        {
            newHardDriveSubForm = new Create_HardDrive();
            newHardDriveSubForm.OnDataAvailable += new EventHandler(AddHardDriveToList);
            newHardDriveSubForm.FormClosed += this.UpdateFormEvent;
            newHardDriveSubForm.MdiParent = MdiParent;
            newHardDriveSubForm.Show();
        }

        private void AddHardDriveToList(object sender, EventArgs e)
        {
            var harddrive = newHardDriveSubForm.NewHardDrive;
            ComputerHardDrives.Add(harddrive);
            EntitiesToListView.FillHardDrivesListViewDetailView(ComputerHardDrives, listViewCreateComputerHardDrives);
        }

        private void buttonEditHardDrive_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteHardDrive_Click(object sender, EventArgs e)
        {

        }



        #endregion

        #region [Raid Crud]
        //Add
        private void AddRaidToList(object sender, EventArgs e)
        {
            var raid = newRaidForm.NewRaid;
            ComputerRaids.Add(raid);
            EntitiesToListView.FillHardRaidsListViewDetailView(ComputerRaids, listViewCreateComputerRaid);
        }

        //Create Raid Functions
        private Create_Raid newRaidForm = null;
        private void buttonAddRaid_Click(object sender, EventArgs e)
        {
            if (ComputerHardDrives.Any())
            {
                this.newRaidForm = new Create_Raid();
                newRaidForm.SelectableHardDrives = ComputerHardDrives;
                newRaidForm.OnDataAvailable += new EventHandler(AddRaidToList);
                newRaidForm.FormClosed += this.UpdateFormEvent;
                newRaidForm.MdiParent = MdiParent;
                newRaidForm.Show();
            }
            else
            {
                MessageBox.Show("An existing Hard Drive is required before any RAIDS can be added.\r\nPlease add a Hard Drive before reattemtping.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //View


        //Edit
        private void buttonEditRaid_Click(object sender, EventArgs e)
        {

        }

        //Delete
        private void buttonDeleteRaid_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region [onSave]

        public override void OnSave(EventArgs e)
        {
            MakeComputer();
        }

        private void MakeComputer()
        {
            NewComputer = new Computer()
            {
                //General Info
                Make = comboBoxMake.Text,
                Model = comboBoxModel.Text,
                Type = comboBoxType.Text,
                SerialNumber = txtSerialNum.Text,
                SvcTag = txtSvcTag.Text,

                //CMOS
                CmosDate = dateTimePickerCMOS.Value,
                CurrentDate = dateTimePickerActualDate.Value,
                ActualTimeProvidedBy = comboBoxTimeProvidedBy.Text,
                KeystrokeForCmosSetup = comboBoxSetupKeystroke.Text,
                CmosWasChanged = checkBoxCmosChanged.Checked,
                DescriptionOfCmosChanges = txtCMOSChangesMade.Text,

                //System Info
                SystemWasRunning = checkBoxSystemWasRunning.Checked,
                PlugWasPulled = checkBoxPlugWasPulled.Checked,
                AppsWereRunning = checkBoxAppsWereRunning.Checked,
                WhoShutDown = SelectSingleEntityById.SelectEmployeeById(new Guid(comboBoxShutDownBy.SelectedValue.ToString())),
                WasPoweredOn = checkBoxSystemWasPoweredOn.Checked,
                WasServer = checkBoxSystemWasServer.Checked,
                ServerType = comboBoxServerType.Text,
                WasVirtualMachine = checkBoxWasVirtualMachine.Checked,
                WasHostedSystem = checkBoxWasHostedSystem.Checked,
                Hostname = textBoxHostname.Text,
                //HD + Raid
                HardDrives = ComputerHardDrives,
                Raids = ComputerRaids,

                //CdfInfo
                CdfInfo = new CdfInfo()
                {
                    IsFinishDate = true,
                    Cdfdate = dateTimePickerCDFDate.Value,
                    TechExaminer = SelectSingleEntityById.SelectEmployeeById(new Guid(comboBoxCdfInfoTech.SelectedValue.ToString()))
                },
            };
            ComputerHardDrives.ToList().ForEach(hd => hd.ReferenceComputer = NewComputer);
        }
        #endregion

        #region [Validating]
        private void comboBoxMake_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(comboBoxMake, string.Empty);
            errorProvider.SetIconPadding(comboBoxMake, 25);

            if (comboBoxMake.Text == "")
            {
                errorProvider.SetError(comboBoxMake, "This must have a value.");
                e.Cancel = true;
            }
        }

        private void comboBoxModel_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(comboBoxModel, string.Empty);
            errorProvider.SetIconPadding(comboBoxModel, 25);


            if (comboBoxModel.Text == "")
            {
                errorProvider.SetError(comboBoxModel, "You must specify a model.");
                e.Cancel = true;
            }
        }

        private void comboBoxType_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(comboBoxType, string.Empty);
            if (comboBoxType.Text == "")
            {
                errorProvider.SetError(comboBoxType, "You must indicate the type of Computer.");

                e.Cancel = true;
            }
        }

        private void txtSerialNum_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(txtSerialNum, string.Empty);
            if (txtSerialNum.Text == "")
            {
                errorProvider.SetError(txtSerialNum, "Serial Number is required.");
                e.Cancel = true;
            }
        }

        private void txtSvcTag_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(txtSvcTag, string.Empty);
            if (txtSvcTag.Text == "")
            {
                errorProvider.SetError(txtSvcTag, "A service tag is required");
                e.Cancel = true;
            }
        }

        private void comboBoxCdfInfoTech_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(comboBoxCdfInfoTech, string.Empty);
            errorProvider.SetIconPadding(comboBoxCdfInfoTech, 25);
            if (comboBoxCdfInfoTech.Text == "")
            {
                errorProvider.SetError(comboBoxCdfInfoTech, "You must associate a Tech with this computer");
                e.Cancel = true;
            }
        }
        private void comboBoxShutDownBy_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(comboBoxShutDownBy, string.Empty);
            errorProvider.SetIconPadding(comboBoxShutDownBy, 25);
            if (comboBoxShutDownBy.Text == "")
            {
                errorProvider.SetError(comboBoxShutDownBy, "You must indicate who shut down the computer.");
                e.Cancel = true;
            }
        }

        #endregion

        #region [listHelpers]
        private void buttonAddCompModel_Click(object sender, EventArgs e)
        {
            addModelHelper.SummonUtilityList();
        }

        private void buttonAddCompMake_Click(object sender, EventArgs e)
        {
            addMakeHelper.SummonUtilityList();
        }

        private void buttonaddSetupKeystroke_Click(object sender, EventArgs e)
        {
            addSetupkeystrokeHelper.SummonUtilityList();
        }

        private void buttonaddTimeProvidedBy_Click(object sender, EventArgs e)
        {
            addTimeProvidedByHelper.SummonUtilityList();
        }

        private void buttonAddServerType_Click(object sender, EventArgs e)
        {
            addServerType.SummonUtilityList();
        }

        #endregion

        #region [utilities]

        //form Automation stuff
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 2)
            {
                checkBoxSystemWasServer.Enabled = true;
                checkBoxSystemWasServer.Checked = true;
                comboBoxServerType.Enabled = true;
            }
            else
            {
                checkBoxSystemWasServer.Enabled = false;
                checkBoxSystemWasServer.Checked = false;
                comboBoxServerType.Items.Clear();
                comboBoxServerType.Enabled = false;
            }
        }

        private void checkBoxWasHostedSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWasHostedSystem.Checked)
            {
                textBoxHostname.Enabled = true;
                textBoxHostname.Focus();
            }
            else
            {
                textBoxHostname.Clear();
                textBoxHostname.Enabled = false;
            }
        }

        private void checkBoxCmosChanged_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCmosChanged.Checked)
            {
                txtCMOSChangesMade.Enabled = true;
                txtCMOSChangesMade.Focus();
            }
            else
            {
                txtCMOSChangesMade.Clear();
                txtCMOSChangesMade.Enabled = false;
            }
        }

        //CDF info stuff
        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeToDatabase();
        }

        private void AddEmployee2_Click(object sender, EventArgs e)
        {
            AddEmployeeToDatabase();
        }

        private void AddEmployeeToDatabase()
        {
            Create_Employee newEmployeeForm = new Create_Employee();
            newEmployeeForm.FormClosed += this.UpdateFormEvent;
            newEmployeeForm.MdiParent = MdiParent;
            newEmployeeForm.Show();
        }

        #endregion





    }
}

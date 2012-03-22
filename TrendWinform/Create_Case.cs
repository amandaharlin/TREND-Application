using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate.Impl;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;
using NHibernate;
using NHibernate.Linq;
using TrendWinForm.MyUtilities;
using NHibernate.Criterion;

namespace TrendWinForm
{
    public partial class Create_Case : Form
    {
        private Case NewCase;
        public IList<Computer> CaseComputers = new List<Computer>();
        public IList<HardDrive> CaseHardDrives = new List<HardDrive>();
        public IList<ForensicProcess> CaseForensicProcesses = new List<ForensicProcess>();
        public IList<ActiveUserFile> CaseActiveUserFiles = new List<ActiveUserFile>();

        public event EventHandler CaseUpdatedOrCreated;
        private string formEditMode = "create";

        #region [Constructors and Initialization]
        public Create_Case()
        {
            InitializeComponent();
        }

        public Create_Case(Case incomingCase, string _formEditMode)
        {
            InitializeComponent();
            formEditMode = _formEditMode;
            NewCase = incomingCase;
        }

        private void Create_Case_Shown(object sender, EventArgs e)
        {
            
            UpdateDataBoundControls();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            if (formEditMode.ToLower() == "edit")
            {
                PopulateFormWithCase(NewCase);
                FormTitleHelper.SetFormFormattingByEditMode(formEditMode, this, NewCase.Matter.ToString());
            }
            else if (formEditMode.ToLower() == "view")
            {
                PopulateFormWithCase(NewCase);
                FormTitleHelper.SetFormFormattingByEditMode(formEditMode, this, NewCase.Matter.ToString());
                var formTextBoxes = UtilityQueries.GetAllControlsOfTypeFromParent(this, typeof(TextBox)).AsEnumerable().Cast<TextBox>();
                formTextBoxes.ForEach(t =>
                {
                    t.Enabled = false;
                    t.BorderStyle = BorderStyle.None;
                });
            }
            else
            {
                FormTitleHelper.SetFormFormattingByEditMode(formEditMode, this);
            }
        }
        private void PopulateFormWithCase(Case incomingCase)
        {
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    incomingCase = session.CreateCriteria(typeof(Case))
                        .Add(Restrictions.Eq("Id", incomingCase.Id))
                        .UniqueResult<Case>();

                    matterTextBox.Text = incomingCase.Matter;
                    caseNumberTextBox.Text = Math.Truncate(incomingCase.CaseNumber).ToString();
                    itemNumberTextBox.Text = incomingCase.ItemNumber.ToString();
                    startDateDateTimePicker.Value = incomingCase.StartDate;
                    barcodeTextBox.Text = incomingCase.Barcode.ToString();
                    barcodeDateVerifiedDateTimePicker.Value = incomingCase.BarcodeDateVerified;
                    firm_idComboBox.SelectedValue = incomingCase.Firm.Id;
                    EntitiesToComboBox.FillFirmContactComboBoxByFirm(incomingCase.Firm.Id, requester_idComboBox);
                    requester_idComboBox.SelectedValue = incomingCase.Requester.Id;
                    examiner_idComboBox.SelectedValue = incomingCase.Examiner.Id;
                    textBoxConclusion.Text = incomingCase.NotesAndConclusion.Conclusion;
                    textBoxNACNotes.Text = incomingCase.NotesAndConclusion.Notes;

                    NewCase = incomingCase;
                    CaseComputers = incomingCase.Computers;
                    CaseHardDrives = incomingCase.HardDrives;
                    CaseForensicProcesses = incomingCase.ForensicProcesses;
                    CaseActiveUserFiles = incomingCase.ActiveUserFiles;

                    EntitiesToListView.FillActiveUserFilesListViewDetailView(CaseActiveUserFiles, listViewAUFActiveUserFiles);
                    EntitiesToListView.FillComputersListview(CaseComputers, listViewAssociatedComputerList);
                    EntitiesToListView.FillHardDrivesListView(CaseHardDrives, listViewHardDrivesOnHardDrivePage);
                    EntitiesToListView.FillForensicProcessListView(CaseForensicProcesses, listViewForensicProcesses);

                    transaction.Commit();
                }
            }
        }

        public void UpdateFormEvent(object sender, EventArgs e)
        {
            UpdateDataBoundControls();
        }

        //Comboboxes, etc.
        public void UpdateDataBoundControls()
        {
            UpdateComboBoxes();
        }

        public void UpdateComboBoxes()
        {
            EntitiesToComboBox.FillEmployeeComboBox(examiner_idComboBox);
            EntitiesToComboBox.FillFirmComboBox(firm_idComboBox);
            EntitiesToComboBox.FillEmployeeComboBox(comboBoxCdfInfoTech);

            if (firm_idComboBox.SelectedValue != null)
            {
                var firmGuid = new Guid(firm_idComboBox.SelectedValue.ToString());
                EntitiesToComboBox.FillFirmContactComboBoxByFirm(firmGuid, requester_idComboBox);
            }
        }

        #endregion

        #region [Create Case Header Events]

        // Header Events.
        private void firm_idComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            var selectedfirm = new Guid(firm_idComboBox.SelectedValue.ToString());
            EntitiesToComboBox.FillFirmContactComboBoxByFirm(selectedfirm, requester_idComboBox);
        }

        //Header Add Entity BUttons
        private void AddFirm_Click(object sender, EventArgs e)
        {
            Create_Firm newFirmForm = new Create_Firm();
            newFirmForm.FormClosed += this.UpdateFormEvent;
            newFirmForm.MdiParent = MdiParent;
            newFirmForm.Show();
        }

        private void AddFirmContact_Click(object sender, EventArgs e)
        {
            Create_FirmContact newFirmContactForm = new Create_FirmContact();
            newFirmContactForm.FormClosed += this.UpdateFormEvent;
            newFirmContactForm.MdiParent = MdiParent;
            newFirmContactForm.Show();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            Create_Employee newEmployeeForm = new Create_Employee();
            newEmployeeForm.FormClosed += this.UpdateFormEvent;
            newEmployeeForm.MdiParent = MdiParent;
            newEmployeeForm.Show();
        }

        //Header View Buttons
        private void ViewFirm_Click(object sender, EventArgs e)
        {
            if (firm_idComboBox.SelectedValue != null)
            {
                MessageBox.Show(firm_idComboBox.SelectedValue.ToString());
            }

        }

        private void ViewFirmContact_Click(object sender, EventArgs e)
        {
            if (requester_idComboBox.SelectedValue != null)
            {
                MessageBox.Show(requester_idComboBox.SelectedValue.ToString());
            }

        }

        private void ViewEmployee_Click(object sender, EventArgs e)
        {
            if (examiner_idComboBox.SelectedValue != null)
            {
                MessageBox.Show(examiner_idComboBox.SelectedValue.ToString());
            }

        }
        #endregion

        #region [ Computer Tab ]

        ////////////////////////////////////////
        ///COMPUTER TAB!!!!!
        /// <summary>manage computers associated with case and thier associated hard drives. all entities are transient until save button is clicked.</summary>
        ///////////////////////////////////////

        /////////////////////s
        //Comp List CRUD

        //Add
        private Create_Computer newCompSubform = null;
        private void buttonAddComputer_Click(object sender, EventArgs e)
        {
            newCompSubform = new Create_Computer();
            newCompSubform.OnDataAvailable += AddComputerTolist; // ....Add Computer Entity From SubForm
            newCompSubform.FormClosed += UpdateFormEvent;
            newCompSubform.MdiParent = MdiParent;
            newCompSubform.Show();
        }

        // ....Add Computer Entity From SubForm
        private void AddComputerTolist(object sender, EventArgs e)
        {
            var computer = newCompSubform.NewComputer;
            computer.HardDrives.ForEach(hd => CaseHardDrives.Add(hd));
            CaseComputers.Add(computer);
            EntitiesToListView.FillComputersListview(CaseComputers, listViewAssociatedComputerList);
            EntitiesToListView.FillHardDrivesListView(CaseHardDrives, listViewHardDrivesOnHardDrivePage);
        }

        //View
        private void buttonViewComputer_Click(object sender, EventArgs e)
        {
            if (listViewAssociatedComputerList.SelectedItems.Count == 1)
            {

            }
            else
            {
                MessageBox.Show("Please Select a Computer from the List to View");
            }
        }
        //edit
        Create_Computer editCompSubform;
        private Computer _editComputer;
        private void buttonEditComputer_Click(object sender, EventArgs e)
        {
            if (listViewAssociatedComputerList.SelectedItems.Count == 1)
            {
                var compId = listViewAssociatedComputerList.SelectedItems[0].Tag;
                if (compId.GetType() == typeof(Computer))
                {
                    _editComputer = (Computer)compId;
                }
                else
                {
                    compId = new Guid(compId.ToString());
                    _editComputer = CaseComputers.SingleOrDefault(x => x.Id == (Guid)compId);
                }
                if (editCompSubform != null)
                {
                    editCompSubform.Close();
                }

                editCompSubform = new Create_Computer(_editComputer, "edit");
                editCompSubform.MdiParent = MdiParent;
                editCompSubform.OnDataAvailable += UpdateComputerInList;
                editCompSubform.FormClosed += UpdateFormEvent;
                editCompSubform.Show();
            }
            else
            {
                MessageBox.Show("Please Select a Computer from the List to Edit");
            }
        }

        private void UpdateComputerInList(object sender, EventArgs e)
        {
            var computer = editCompSubform.NewComputer;

            _editComputer.HardDrives.ForEach(hd => CaseHardDrives.Remove(hd));
            computer.HardDrives.ForEach(hd => CaseHardDrives.Add(hd));
            CaseComputers.Remove(_editComputer);
            CaseComputers.Add(computer);
            
            EntitiesToListView.FillComputersListview(CaseComputers, listViewAssociatedComputerList);
            EntitiesToListView.FillHardDrivesListView(CaseHardDrives, listViewHardDrivesOnHardDrivePage);
        }


        //Delete
        private void buttonDeleteComputer_Click(object sender, EventArgs e)
        {
            if (listViewAssociatedComputerList.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Really delete this Computer and its Hard Drives?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var compId = listViewAssociatedComputerList.SelectedItems[0].Tag;
                    if (compId.GetType() == typeof(Computer))
                    {
                        thisComputer = (Computer)compId;
                    }
                    else
                    {
                        compId = new Guid(compId.ToString());
                        thisComputer = CaseComputers.SingleOrDefault(x => x.Id == (Guid)compId);
                        DeleteSingleEntityById.DeleteComputerById((Guid)compId);
                    }
                    if (thisComputer.HardDrives.Any())
                    {
                        thisComputer.HardDrives.ForEach(hd => CaseHardDrives.Remove(hd));
                    }

                    CaseComputers.Remove(thisComputer);
                    EntitiesToListView.FillComputersListview(CaseComputers, listViewAssociatedComputerList);
                    EntitiesToListView.FillHardDrivesListView(CaseHardDrives, listViewHardDrivesOnHardDrivePage);
                    listViewComputerAssociatedHardDrives.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Select a Computer from the List to Delete");
            }
        }

        //Map Computer + Computer Data to Fields
        private Computer thisComputer = new Computer(); //outside closure to Hd's can see it
        private void listViewAssociatedComputerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAssociatedComputerList.SelectedItems.Count == 1)
            {

                //Select Item
                var compId = listViewAssociatedComputerList.SelectedItems[0].Tag;
                if (compId.GetType() == typeof(Computer))
                {
                    thisComputer = (Computer)compId;
                }
                else
                {
                    compId = new Guid(compId.ToString());
                    thisComputer = CaseComputers.SingleOrDefault(x => x.Id == (Guid)compId);
                }

                if (thisComputer != null)
                {
                    groupBoxDriveDetails.Controls.OfType<TextBox>().ForEach(x => x.Text = "");
                    //Puts computer info in fields
                    ListViewToDetailsFields.ComputerlistViewToDetailFields(thisComputer, this);
                    //puts the hard drives in their listView.
                    EntitiesToListView.FillHardDrivesListView(thisComputer.HardDrives, listViewComputerAssociatedHardDrives);
                    listViewComputerAssociatedHardDrives.View = View.LargeIcon;
                }
                listViewAssociatedRaids.Clear();
                if (thisComputer.Raids.Any())
                {
                    EntitiesToListView.FillHardRaidsListViewDetailView(thisComputer.Raids, listViewAssociatedRaids);
                }
            }
        }
        // Map Hd data to details area
        private void listViewComputerAssociatedHardDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewComputerAssociatedHardDrives.SelectedItems.Count == 1)
            {
                var i = listViewComputerAssociatedHardDrives.SelectedItems[0].Index;
                textBoxHDDetails_Make.Text = thisComputer.HardDrives[i].Make;
                textBoxHDDetails_Model.Text = thisComputer.HardDrives[i].Model;
                textBoxHDDetails_Serial.Text = thisComputer.HardDrives[i].Serial;
                textBoxHDDetails_Interface.Text = thisComputer.HardDrives[i].DriveInterface;
            }
        }
        #endregion

        #region[HD Tab]

        ////////////////////////////////////////
        ///HDTAB!!!!!
        /// 
        /// 
        /// <summary>manage HDs associated with case and thier associated raids. all entities are transient until save button is clicked.</summary>
        ///////////////////////////////////////
        private Create_HardDrive newHardDriveSubForm = null;
        private void buttonAddHardDrives_Click(object sender, EventArgs e)
        {
            newHardDriveSubForm = new Create_HardDrive();
            newHardDriveSubForm.OnDataAvailable += AddHardDriveTolist; //Add HD to List
            newHardDriveSubForm.FormClosed += UpdateFormEvent;
            newHardDriveSubForm.MdiParent = MdiParent;
            newHardDriveSubForm.Show();

        }
        ///////////////////
        //CRUD buttons

        //Add HD to List
        private void AddHardDriveTolist(object sender, EventArgs e)
        {
            CaseHardDrives.Add(newHardDriveSubForm.NewHardDrive);
            EntitiesToListView.FillHardDrivesListView(CaseHardDrives, listViewHardDrivesOnHardDrivePage);
        }

        //Delete
        private void buttonDeleteHardDrives_Click(object sender, EventArgs e)
        {
            if (listViewHardDrivesOnHardDrivePage.SelectedItems.Count == 1 && formEditMode != "view")
            {
                if (MessageBox.Show("Really delete this Hard Drive?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var hdId = listViewHardDrivesOnHardDrivePage.SelectedItems[0].Tag;
                    var hdToRemove = new HardDrive();
                    if (hdId.GetType() == typeof(HardDrive))
                    {
                        hdToRemove = (HardDrive)hdId;
                    }
                    else
                    {
                        hdId = new Guid(hdId.ToString());
                        hdToRemove = CaseHardDrives.SingleOrDefault(x => x.Id == (Guid)hdId);

                        if(hdToRemove.ReferenceComputer == null)
                        {
                            DeleteSingleEntityById.DeleteHardDriveById((Guid)hdId);
                        }

                    }
                    if (hdToRemove.ReferenceComputer == null)
                    {
                        CaseHardDrives.Remove(hdToRemove);
                    }else
                    {
                        MessageBox.Show("Delete or Edit the Associated Computer to this Hard Drive");
                    }

                    EntitiesToListView.FillComputersListview(CaseComputers, listViewAssociatedComputerList);
                    EntitiesToListView.FillHardDrivesListView(CaseHardDrives, listViewHardDrivesOnHardDrivePage);
                }
            }
            else
            {
                MessageBox.Show("Please Select which Hard Drive to remove");
            }
        }
        // Edit
        private void buttonEditHardDrives_Click(object sender, EventArgs e)
        {
            if (listViewHardDrivesOnHardDrivePage.SelectedItems.Count == 1)
            {

            }
            else
            {
                MessageBox.Show("Please Select which Hard Drive to Edit");
            }
        }
        // View
        private void buttonViewHardDrives_Click(object sender, EventArgs e)
        {
            if (listViewHardDrivesOnHardDrivePage.SelectedItems.Count == 1)
            {

            }
            else
            {
                MessageBox.Show("Please Select which Hard Drive to View");
            }
        }


        //....HDtab: Map HD Data to Fields
        private void listViewHardDrivesOnHardDrivePage_Click(object sender, EventArgs e)
        {
            if (listViewHardDrivesOnHardDrivePage.SelectedItems.Count == 1)
            {
                var hdId = listViewHardDrivesOnHardDrivePage.SelectedItems[0].Tag;
                var thisHardDrive = new HardDrive();
                if (hdId.GetType() == typeof(HardDrive))
                {
                    thisHardDrive = (HardDrive)hdId;
                }
                else
                {
                    hdId = new Guid(hdId.ToString());
                    thisHardDrive = CaseHardDrives.SingleOrDefault(x => x.Id == (Guid)hdId);
                }
                ListViewToDetailsFields.HardDrivelistViewToDetailFields(thisHardDrive, this);

            }
        }
        #endregion

        #region [Forensics Tab]

        ////////////////////////////////////////
        ///forensics Tab!!!!!
        /// 
        /// 
        /// <summary>forensic summary here.</summary>
        ///////////////////////////////////////
        private Create_ForensicProcess newFPSubForm = null;
        // Add FP
        private void buttonAddForensicProcess_Click(object sender, EventArgs e)
        {
            newFPSubForm = new Create_ForensicProcess();

            if (CaseComputers.Any() || CaseHardDrives.Any())
            {
                newFPSubForm.SelectableAssociatedComputers = CaseComputers;
                newFPSubForm.SelectableAssociatedHardDrives = CaseHardDrives;
                newFPSubForm.OnDataAvailable += AddForensicProcessTolist;
                newFPSubForm.FormClosed += UpdateFormEvent;
                newFPSubForm.Show();
            }
            else
            {
                MessageBox.Show("It is not useful to create a Foresnsic Process before either A computer or Hard Drive exists");
            }
        }

        private void AddForensicProcessTolist(object sender, EventArgs e)
        {
            var forensicprocess = newFPSubForm.NewForensicProcess;
            CaseForensicProcesses.Add(forensicprocess);
            EntitiesToListView.FillForensicProcessListView(CaseForensicProcesses, listViewForensicProcesses);
        }

        //View FP
        private void buttonViewForensicProcess_Click(object sender, EventArgs e)
        {
            if (listViewForensicProcesses.SelectedItems.Count == 1)
            {

            }
        }

        //Edit FP
        private void buttonEditForensicProcess_Click(object sender, EventArgs e)
        {
            if (listViewForensicProcesses.SelectedItems.Count == 1)
            {

            }
        }


        

        //Delete FP
        private void buttonDeleteForensicProcess_Click(object sender, EventArgs e)
        {
            if (listViewForensicProcesses.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Really delete this Forensic Process?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var fpId = listViewForensicProcesses.SelectedItems[0].Tag;
                    var this_ForensicProcess = new ForensicProcess();
                    if (fpId.GetType() == typeof(ForensicProcess))
                    {
                        this_ForensicProcess = (ForensicProcess)fpId;
                    }
                    else
                    {
                        fpId = new Guid(fpId.ToString());
                        this_ForensicProcess = CaseForensicProcesses.SingleOrDefault(x => x.Id == (Guid)fpId);
                        DeleteSingleEntityById.DeleteForensicProcessById((Guid)fpId);
                    }
                    CaseForensicProcesses.Remove(this_ForensicProcess);

                    EntitiesToListView.FillForensicProcessListView(CaseForensicProcesses, listViewForensicProcesses);
                }

            }

            else
            {
                MessageBox.Show("You must select a Forensic Process to Delete");
            }
        }

       
        
        
        private ForensicProcess this_ForensicProcess;
        private void listViewForensicProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewForensicProcesses.SelectedItems.Count == 1)
            {
                var fpId = listViewForensicProcesses.SelectedItems[0].Tag;

                //var this_ForensicProcess = new ForensicProcess();
                if (fpId.GetType() == typeof(ForensicProcess))
                {
                    this_ForensicProcess = (ForensicProcess)fpId;
                }
                else
                {
                    fpId = new Guid(fpId.ToString());
                    this_ForensicProcess = CaseForensicProcesses.SingleOrDefault(x => x.Id == (Guid)fpId);
                }

                ListViewToDetailsFields.ForensicProcesseslistViewToDetailFields(this_ForensicProcess, this);
                EntitiesToListView.FillDestinationMediaListViewDetailView(this_ForensicProcess.DestinationMediae, listViewFPDestinationMediae);
                EntitiesToListView.FillHardDrivesListViewDetailView(this_ForensicProcess.ReferenceHardDrives, listViewFPAssociatedHardDrives);
                EntitiesToListView.FillComputersListViewDetailView(this_ForensicProcess.ReferenceComputers, listViewFPAssociatedComputers);

            }
        }
        #endregion

        #region [Active User File Tab]
        // Add AUF
        private Create_ActiveUserFile newActiveUserFileSubForm = null;
        private void buttonAddActiveUserFiles_Click(object sender, EventArgs e)
        {

            if (CaseComputers.Any())
            {
                newActiveUserFileSubForm = new Create_ActiveUserFile();
                newActiveUserFileSubForm.ReferenceComputers = CaseComputers;
                newActiveUserFileSubForm.OnDataAvailable += AddActiveUserFilesToList;
                newActiveUserFileSubForm.FormClosed += UpdateFormEvent;
                newActiveUserFileSubForm.MdiParent = MdiParent;
                newActiveUserFileSubForm.Show();
            }
            else
            {
                MessageBox.Show("You need to have Computers associated with the Case, before you can add any Active User Files.");
            }
        }
        // View AUF
        private void buttonViewActiveUserFile_Click(object sender, EventArgs e)
        {
            if (listViewAUFActiveUserFiles.SelectedItems.Count == 1)
            {

            }
            else
            {
                MessageBox.Show("Please Select which Active User File, to view");
            }
        }
        // Edit AUF
        private void buttonEditActiveUserFile_Click(object sender, EventArgs e)
        {
            if (listViewAUFActiveUserFiles.SelectedItems.Count == 1)
            {

            }
            else
            {
                MessageBox.Show("Please Select which Active User File, to edit");
            }
        }
        // Delete AUF
        private void buttonRemoveActiveUserFile_Click(object sender, EventArgs e)
        {
            if (listViewAUFActiveUserFiles.SelectedItems.Count == 1 && formEditMode != "view")
            {
                if (MessageBox.Show("Really delete this Active User file?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var aufId = listViewAUFActiveUserFiles.SelectedItems[0].Tag;
                    var aufToRemove = new ActiveUserFile();
                    if (aufId.GetType() == typeof(ActiveUserFile))
                    {
                        aufToRemove = (ActiveUserFile)aufId;
                    }
                    else
                    {
                        aufId = new Guid(aufId.ToString());
                        aufToRemove = CaseActiveUserFiles.SingleOrDefault(x => x.Id == (Guid)aufId);
                        DeleteSingleEntityById.DeleteActiveUserFileById((Guid)aufId);
                    }
                    CaseActiveUserFiles.Remove(aufToRemove);
                    EntitiesToListView.FillActiveUserFilesListViewDetailView(CaseActiveUserFiles, listViewAUFActiveUserFiles);
                }
            }
            else
            {
                MessageBox.Show("Please Select which Active User File to remove");
            }
        }

        //add cdf employee
        private void AddEmployee2_Click(object sender, EventArgs e)
        {
            AddEmployeeToDatabase();
        }

        private void AddEmployeeToDatabase()
        {
            Create_Employee newEmployeeForm = new Create_Employee();
            newEmployeeForm.FormClosed += this.UpdateFormEvent;
            newEmployeeForm.Show();
        }

        private void AddActiveUserFilesToList(object sender, EventArgs e)
        {
            var activeuserfile = newActiveUserFileSubForm.NewActiveUserFile;
            CaseActiveUserFiles.Add(activeuserfile);
            EntitiesToListView.FillActiveUserFilesListViewDetailView(CaseActiveUserFiles, listViewAUFActiveUserFiles);
        }
        #endregion

        #region[Notes & Conclusion Tab]
        //pull in cdf employees

        #endregion

        #region [ Save & Cancel Buttons ]

        // Save and Cancel Buttons
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (MessageBox.Show("Are you sure you wish to save? Your changes to this Case will be applied to the daabase, and this form will close.", "Confirm Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var factory = SessionConfig.SessionFactory;
                    using (var session = factory.OpenSession())
                    {
                        var caseFirm = SelectSingleEntityById.SelectFirmById(new Guid(firm_idComboBox.SelectedValue.ToString()));
                        var caseRequester = SelectSingleEntityById.SelectFirmContactById(new Guid(requester_idComboBox.SelectedValue.ToString()));
                        var caseExmployee = SelectSingleEntityById.SelectEmployeeById(new Guid(examiner_idComboBox.SelectedValue.ToString()));
                        var caseNotesAndConclusion = new NotesAndConclusion()
                        {
                            Notes = textBoxNACNotes.Text,
                            Conclusion = textBoxConclusion.Text,
                            CdfInfo = new CdfInfo()
                            {
                                TechExaminer = SelectSingleEntityById.SelectEmployeeById(new Guid(comboBoxCdfInfoTech.SelectedValue.ToString())),
                                IsFinishDate = true,
                                Cdfdate = dateTimePickerCDFDate.Value,
                            }
                        };
                        if (formEditMode.ToLower() == "create")
                        {
                            NewCase = new Case()
                            {
                                CaseNumber = Convert.ToInt32(caseNumberTextBox.Text),
                                Matter = matterTextBox.Text,
                                ItemNumber = Convert.ToInt32(itemNumberTextBox.Text),
                                StartDate = startDateDateTimePicker.Value,
                                Barcode = barcodeTextBox.Text,
                                BarcodeDateVerified = barcodeDateVerifiedDateTimePicker.Value,
                                Firm = caseFirm,
                                Requester = caseRequester,
                                Examiner = caseExmployee,

                                Computers = CaseComputers,
                                HardDrives = CaseHardDrives,
                                ForensicProcesses = CaseForensicProcesses,
                                ActiveUserFiles = CaseActiveUserFiles,
                                NotesAndConclusion = caseNotesAndConclusion,
                            };
                        }
                        else if (formEditMode.ToLower() == "edit")
                        {
                            NewCase.CaseNumber = Convert.ToDecimal(caseNumberTextBox.Text);
                            NewCase.Matter = matterTextBox.Text;
                            NewCase.ItemNumber = Convert.ToInt32(itemNumberTextBox.Text);
                            NewCase.StartDate = startDateDateTimePicker.Value;
                            NewCase.Barcode = barcodeTextBox.Text;
                            NewCase.BarcodeDateVerified = barcodeDateVerifiedDateTimePicker.Value;
                            NewCase.Firm = caseFirm;
                            NewCase.Requester = caseRequester;
                            NewCase.Examiner = caseExmployee;
                            NewCase.Computers = CaseComputers;
                            NewCase.HardDrives = CaseHardDrives;
                            NewCase.ForensicProcesses = CaseForensicProcesses;
                            NewCase.ActiveUserFiles = CaseActiveUserFiles;
                            NewCase.NotesAndConclusion = caseNotesAndConclusion;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Form Edit Mode : Please Restart Appliction.");
                        }

                        NewCase.NotesAndConclusion.ReferenceCase = NewCase;
                        using (var transaction = session.BeginTransaction())
                        {
                            if (formEditMode.ToLower() == "create")
                            {
                                session.Save(NewCase);
                            }
                            else if (formEditMode.ToLower() == "edit")
                            {
                                session.Update(NewCase);
                            }
                            transaction.Commit();
                        }
                    }

                    if (CaseUpdatedOrCreated != null)
                    {
                        CaseUpdatedOrCreated(this, EventArgs.Empty);
                    }
                    
                    Close();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to exit? Your changes to this Case will be dicarded.", "Confirm Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                errorProvider1.Clear();
                Close();
            }
        }

        #endregion

        #region [Form Utilities]
        //Change LISTVIEW Views
        private void buttonViewTileComputerListView_Click(object sender, EventArgs e) { listViewAssociatedComputerList.View = View.Tile; }
        private void buttonViewDetailsComputerListView_Click(object sender, EventArgs e) { listViewAssociatedComputerList.View = View.SmallIcon; }
        private void buttonViewTileForensicProcessListView_Click(object sender, EventArgs e) { listViewForensicProcesses.View = View.Tile; }
        private void buttonViewSmallIconForensicProcessListView_Click(object sender, EventArgs e) { listViewForensicProcesses.View = View.SmallIcon; }
        private void buttonViewTileHardDriveListView_Click(object sender, EventArgs e) { listViewHardDrivesOnHardDrivePage.View = View.Tile; }
        private void buttonViewDetailsHardDriveListView_Click(object sender, EventArgs e) { listViewHardDrivesOnHardDrivePage.View = View.SmallIcon; }


        #endregion

        #region[validation]


        private void caseNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(caseNumberTextBox, string.Empty);
            if (caseNumberTextBox.Text == "")
            {
                errorProvider1.SetError(caseNumberTextBox, "This must have a value.");
                e.Cancel = true;
            }
        }

        private void matterTextBox_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(matterTextBox, string.Empty);
            if (matterTextBox.Text == "")
            {
                errorProvider1.SetError(matterTextBox, "This must have a value.");
                e.Cancel = true;
            }
        }

        private void itemNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(itemNumberTextBox, string.Empty);
            if (itemNumberTextBox.Text == "")
            {
                errorProvider1.SetError(itemNumberTextBox, "This must have a value.");
                e.Cancel = true;
            }
        }
        #endregion

    }
}
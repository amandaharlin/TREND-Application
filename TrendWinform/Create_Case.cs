using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using TrendWinForm.Domain.Entities;
using TrendWinForm.MyUtilities;

namespace TrendWinForm
{
    public partial class Create_Case : Form
    {
        private Case NewCase;
        public IList<Computer> CaseComputers = new List<Computer>();
        public IList<HardDrive> CaseHardDrives = new List<HardDrive>();
        public IList<ForensicProcess> CaseForensicProcesses = new List<ForensicProcess>();
        public IList<ActiveUserFile> CaseActiveUserFiles = new List<ActiveUserFile>();

        private readonly string formEditMode = "create";


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
                PopulateFormwithCase(NewCase);
                FormTitleHelper.SetFormFormattingByEditMode(formEditMode, this, NewCase.Matter);
            }
            else if (formEditMode.ToLower() == "view")
            {
                PopulateFormwithCase(NewCase);
                FormTitleHelper.SetFormFormattingByEditMode(formEditMode, this, NewCase.Matter);
                IEnumerable<TextBox> formTextBoxes =
                    UtilityQueries.GetAllControlsOfTypeFromParent(this, typeof (TextBox)).AsEnumerable().Cast<TextBox>();
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

        private void Create_Case_Click(object sender, EventArgs e)
        {
            //if (formEditMode == "edit")
            //{
            //    PopulateFormwithCase(NewCase);
            //}
        }


        private void PopulateFormwithCase(Case incomingCase)
        {
            ISessionFactory factory = SessionConfig.SessionFactory;
            using (ISession session = factory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    incomingCase = session.CreateCriteria(typeof (Case))
                        .Add(Restrictions.Eq("Id", incomingCase.Id))
                        .UniqueResult<Case>();

                    matterTextBox.Text = incomingCase.Matter;
                    caseNumberTextBox.Text = Math.Truncate(incomingCase.CaseNumber).ToString();
                    itemNumberTextBox.Text = incomingCase.ItemNumber.ToString();
                    startDateDateTimePicker.Value = incomingCase.StartDate;
                    barcodeTextBox.Text = incomingCase.Barcode;
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

                    EntitiesToListView.FillActiveUserFilesListViewDetailView(CaseActiveUserFiles,
                                                                             listViewAUFActiveUserFiles);
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


            // EntitiesToComboBox.FillReferenceComputersComboBox();
            //shouldn't there be a requester entities to combobox here? like fillfirmcontactcombobox or fillfirmcontactcomboboxbyfirm
        }

        //Change LISTVIEW Views
        private void buttonViewTileComputerListView_Click(object sender, EventArgs e)
        {
            listViewAssociatedComputerList.View = View.Tile;
        }

        private void buttonViewDetailsComputerListView_Click(object sender, EventArgs e)
        {
            listViewAssociatedComputerList.View = View.SmallIcon;
        }

        private void buttonViewTileForensicProcessListView_Click(object sender, EventArgs e)
        {
            listViewForensicProcesses.View = View.Tile;
        }

        private void buttonViewSmallIconForensicProcessListView_Click(object sender, EventArgs e)
        {
            listViewForensicProcesses.View = View.SmallIcon;
        }

        private void buttonViewTileHardDriveListView_Click(object sender, EventArgs e)
        {
            listViewHardDrivesOnHardDrivePage.View = View.Tile;
        }

        private void buttonViewDetailsHardDriveListView_Click(object sender, EventArgs e)
        {
            listViewHardDrivesOnHardDrivePage.View = View.SmallIcon;
        }

        #region [add buttons]

        //Add Entity BUttons
        private void AddFirm_Click(object sender, EventArgs e)
        {
            var newFirmForm = new Create_Firm();
            newFirmForm.FormClosed += UpdateFormEvent;
            newFirmForm.Show();
        }

        private void AddFirmContact_Click(object sender, EventArgs e)
        {
            var newFirmContactForm = new Create_FirmContact();
            newFirmContactForm.FormClosed += UpdateFormEvent;
            newFirmContactForm.Show();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            var newEmployeeForm = new Create_Employee();
            newEmployeeForm.FormClosed += UpdateFormEvent;
            newEmployeeForm.Show();
        }

        #endregion

        #region[view buttons]

        //View Form Buttons
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

        #region [ Save & Cancel Buttons ]

        // Save and Cancel Buttons
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    "Are you sure you wish to save? Your changes to this Case will be applied to the daabase, and this form will close.",
                    "Confirm Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ISessionFactory factory = SessionConfig.SessionFactory;
                using (ISession session = factory.OpenSession())
                {
                    Firm caseFirm =
                        SelectSingleEntityById.SelectFirmById(new Guid(firm_idComboBox.SelectedValue.ToString()));

                    FirmContact caseRequester =
                        SelectSingleEntityById.SelectFirmContactById(
                            new Guid(requester_idComboBox.SelectedValue.ToString()));

                    Employee caseExmployee =
                        SelectSingleEntityById.SelectEmployeeById(new Guid(examiner_idComboBox.SelectedValue.ToString()));

                    var caseNotesAndConclusion = new NotesAndConclusion
                                                     {
                                                         Notes = textBoxNACNotes.Text,
                                                         Conclusion = textBoxConclusion.Text,
                                                         CdfInfo = new CdfInfo
                                                                       {
                                                                           TechExaminer =
                                                                               SelectSingleEntityById.SelectEmployeeById
                                                                               (new Guid(
                                                                                    comboBoxCdfInfoTech.SelectedValue.
                                                                                        ToString())),
                                                                           IsFinishDate = true,
                                                                           Cdfdate = dateTimePickerCDFDate.Value,
                                                                       }
                                                     };
                    if (formEditMode.ToLower() == "create")
                    {
                        NewCase = new Case
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

                    using (ITransaction transaction = session.BeginTransaction())
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
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Are you sure you wish to exit? Your changes to this Case will be dicarded.",
                                "Confirm Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                errorProvider1.Clear();
                Close();
            }
        }

        #endregion

        private void firm_idComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedfirm = new Guid(firm_idComboBox.SelectedValue.ToString());
            EntitiesToComboBox.FillFirmContactComboBoxByFirm(selectedfirm, requester_idComboBox);
        }

        #region [ CRUD ]

        private void buttonViewComputer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View computer with GUid at selected index");
        }

        private void buttonEditComputer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit computer with GUid at selected index");
        }

        private void buttonDeleteComputer_Click(object sender, EventArgs e)
        {
            //If computer has other associated cases, you should remove the computer fromt eh box, but not the potatobase
            // Otherwise, delete the entire computer.
            MessageBox.Show("Delete computer with GUid at selected index");
        }

        #endregion

        private void DisplayStatsOfcurrentlySelectedComputer()
        {
        }

        #region [ Computer Tab ]

        ////////////////////////////////////////
        ///COMPUTER TAB!!!!!
        /// 
        /// 
        /// <summary>manage computers associated with case and thier associated hard drives. all entities are transient until save button is clicked.</summary>
        ///////////////////////////////////////
        private Create_Computer newCompSubform;

        private void buttonAddComputer_Click(object sender, EventArgs e)
        {
            newCompSubform = new Create_Computer();
            newCompSubform.OnDataAvailable += AddComputerTolist;
            newCompSubform.FormClosed += UpdateFormEvent;
            newCompSubform.Show();
        }


        //....CompTab: Map Computer Data to Fields

        private Computer this_Computer;

        private void listViewAssociatedComputerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAssociatedComputerList.SelectedItems.Count == 1)
            {
                int i = listViewAssociatedComputerList.SelectedItems[0].Index;

                this_Computer = CaseComputers[i];
                //Puts computer info in fields
                ListViewToDetailsFields.ComputerlistViewToDetailFields(i, CaseComputers, this);

                //puts the hard drives in their listView.
                EntitiesToListView.FillHardDrivesListView(CaseComputers[i].HardDrives,
                                                          listViewComputerAssociatedHardDrives);
                listViewComputerAssociatedHardDrives.View = View.LargeIcon;

                listViewAssociatedRaids.Clear();
                if (CaseComputers[i].Raids.Count > 0)
                {
                    EntitiesToListView.FillHardRaidsListViewDetailView(CaseComputers[i].Raids, listViewAssociatedRaids);
                }

                groupBoxDriveDetails.Controls.OfType<TextBox>().ForEach(x => x.Text = "");
            }
        }

        private void AddComputerTolist(object sender, EventArgs e)
        {
            Computer computer = newCompSubform.NewComputer;
            computer.HardDrives.ForEach(hd => CaseHardDrives.Add(hd));
            CaseComputers.Add(computer);
            EntitiesToListView.FillComputersListview(CaseComputers, listViewAssociatedComputerList);
            EntitiesToListView.FillHardDrivesListView(CaseHardDrives, listViewHardDrivesOnHardDrivePage);
        }

        private void listViewComputerAssociatedHardDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewComputerAssociatedHardDrives.SelectedItems.Count == 1)
            {
                int i = listViewComputerAssociatedHardDrives.SelectedItems[0].Index;

                textBoxHDDetails_Make.Text = this_Computer.HardDrives[i].Make;
                textBoxHDDetails_Model.Text = this_Computer.HardDrives[i].Model;
                textBoxHDDetails_Serial.Text = this_Computer.HardDrives[i].Serial;
                textBoxHDDetails_Interface.Text = this_Computer.HardDrives[i].DriveInterface;
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
        private Create_HardDrive newHardDriveSubForm;

        private void buttonAddHardDrives_Click(object sender, EventArgs e)
        {
            newHardDriveSubForm = new Create_HardDrive();
            newHardDriveSubForm.OnDataAvailable += AddHardDriveTolist;
            newHardDriveSubForm.FormClosed += UpdateFormEvent;
            newHardDriveSubForm.Show();
        }

        private void AddHardDriveTolist(object sender, EventArgs e)
        {
            CaseHardDrives.Add(newHardDriveSubForm.NewHardDrive);
            EntitiesToListView.FillHardDrivesListView(CaseHardDrives, listViewHardDrivesOnHardDrivePage);
        }

        //....HDtab: Map HD Data to Fields
        private void listViewHardDrivesOnHardDrivePage_Click(object sender, EventArgs e)
        {
            if (listViewHardDrivesOnHardDrivePage.SelectedItems.Count == 1)
            {
                int i = listViewHardDrivesOnHardDrivePage.SelectedItems[0].Index;

                ListViewToDetailsFields.HardDrivelistViewToDetailFields(i, CaseHardDrives, this);
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
        private Create_ForensicProcess newFPSubForm;

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
                MessageBox.Show(
                    "It is not useful to create a Foresnsic Process before either A computer or Hard Drive exists");
            }
        }

        private void AddForensicProcessTolist(object sender, EventArgs e)
        {
            ForensicProcess forensicprocess = newFPSubForm.NewForensicProcess;
            CaseForensicProcesses.Add(forensicprocess);

            EntitiesToListView.FillForensicProcessListView(CaseForensicProcesses, listViewForensicProcesses);
        }

        private ForensicProcess this_ForensicProcess;

        private void listViewForensicProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewForensicProcesses.SelectedItems.Count == 1)
            {
                int i = listViewForensicProcesses.SelectedItems[0].Index;
                this_ForensicProcess = CaseForensicProcesses[i];


                ListViewToDetailsFields.ForensicProcesseslistViewToDetailFields(i, CaseForensicProcesses, this);
                EntitiesToListView.FillDestinationMediaListViewDetailView(CaseForensicProcesses[i].DestinationMediae,
                                                                          listViewFPDestinationMediae);

                EntitiesToListView.FillHardDrivesListViewDetailView(CaseForensicProcesses[i].ReferenceHardDrives,
                                                                    listViewFPAssociatedHardDrives);
                EntitiesToListView.FillComputersListViewDetailView(CaseForensicProcesses[i].ReferenceComputers,
                                                                   listViewFPAssociatedComputers);
            }
        }

        #endregion

        #region [Active User File Tab]

        private Create_ActiveUserFile newActiveUserFileSubForm;

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
                MessageBox.Show(
                    "You need to have Computers associated with the Case, before you can add any Active User Files.");
            }
        }

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

        private void buttonRemoveActiveUserFile_Click(object sender, EventArgs e)
        {
            if (listViewAUFActiveUserFiles.SelectedItems.Count == 1 && formEditMode != "view")
            {
                object aufId = listViewAUFActiveUserFiles.SelectedItems[0].Tag;

                var aufToRemove = new ActiveUserFile();
                if (aufId.GetType() == typeof (ActiveUserFile))
                {
                    aufToRemove = (ActiveUserFile) aufId;
                }
                else
                {
                    aufId = new Guid(aufId.ToString());
                    aufToRemove = CaseActiveUserFiles.SingleOrDefault(x => x.Id == (Guid) aufId);
                    DeleteSingleEntityById.DeleteActiveUserFileById((Guid) aufId);
                }

                CaseActiveUserFiles.Remove(aufToRemove);

                EntitiesToListView.FillActiveUserFilesListViewDetailView(CaseActiveUserFiles, listViewAUFActiveUserFiles);
            }
            else
            {
                MessageBox.Show("Please Select which Active User File to remove");
            }
        }

        private void AddActiveUserFilesToList(object sender, EventArgs e)
        {
            ActiveUserFile activeuserfile = newActiveUserFileSubForm.NewActiveUserFile;
            CaseActiveUserFiles.Add(activeuserfile);
            EntitiesToListView.FillActiveUserFilesListViewDetailView(CaseActiveUserFiles, listViewAUFActiveUserFiles);
        }

        #endregion

        #region[Notes & Conclusion Tab]

        //pull in cdf employees

        #endregion
    }
}
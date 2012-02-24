using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;
using TrendWinForm.MyUtilities;

namespace TrendWinForm
{
    public partial class Create_ForensicProcess : Create_BaseForm
    {
        public ForensicProcess NewForensicProcess { get; set; }
        public IList<DestinationMedia> ForensicProcessDestinationMediae = new List<DestinationMedia>();

        public IList<Computer> SelectableAssociatedComputers { get; set; }
        public IList<HardDrive> SelectableAssociatedHardDrives { get; set; }

        private UtilityListFormHelper addProcessPerformedHelper;
        private UtilityListFormHelper addDeviceUsedHelper;
        private UtilityListFormHelper addSoftwareHelper;
        private UtilityListFormHelper addImagesMadeHelper;
        private UtilityListFormHelper addImagesVerifiedByHelper;



        public Create_ForensicProcess()
        {
            InitializeComponent();


            addProcessPerformedHelper = new UtilityListFormHelper("Process_Performed", comboBoxProcessPerformed);
            addDeviceUsedHelper = new UtilityListFormHelper("Device_Used", comboBoxDeviceUsed);
            addSoftwareHelper = new UtilityListFormHelper("Software_Used", comboBoxSoftwareProcessing);
            addImagesMadeHelper = new UtilityListFormHelper("Images_Made", comboBoxImagesMade);
            addImagesVerifiedByHelper = new UtilityListFormHelper("Images_Verified_By", comboBoxImagesVerifiedBy);

            PopulateFormComboBoxes();
        }

        private void Create_ForensicProcess_Shown(object sender, EventArgs e)
        {
            var displayComputers = SelectableAssociatedComputers.ToDictionary(comp => comp, comp => comp.Make + " | " + comp.Model);
            var displayHardDrives = SelectableAssociatedHardDrives.ToDictionary(hd => hd, hd => hd.Make + " | " + hd.Model);

            if (displayComputers.Any())
            {
                checkedListBoxAssociatedcomputers.DataSource = new BindingSource(displayComputers, null);
                checkedListBoxAssociatedcomputers.DisplayMember = "Value";
                checkedListBoxAssociatedcomputers.ValueMember = "Key";
            }
            if (displayHardDrives.Any())
            {
                checkedListBoxAssociatedhardDrives.DataSource = new BindingSource(displayHardDrives, null);
                checkedListBoxAssociatedhardDrives.DisplayMember = "Value";
                checkedListBoxAssociatedhardDrives.ValueMember = "Key";
            }
        }

        private void UpdateFormEvent(object sender, EventArgs e)
        {
            var comboBoxesList = UtilityQueries.ReturnDictionaryOfComboBoxes(this);
            PopulateFormComboBoxes();
            comboBoxesList.ToList().ForEach(c => { c.Key.SelectedIndex = c.Key.FindStringExact(c.Value); });
        }

        private void PopulateFormComboBoxes()
        {
            EntitiesToComboBox.FillEmployeeComboBox(comboBoxCDFInfoTech);

            addProcessPerformedHelper.PopulateComboBoxWithUtilityStrings();
            addDeviceUsedHelper.PopulateComboBoxWithUtilityStrings();
            addSoftwareHelper.PopulateComboBoxWithUtilityStrings();
            addImagesMadeHelper.PopulateComboBoxWithUtilityStrings();
            addImagesVerifiedByHelper.PopulateComboBoxWithUtilityStrings();

            ////processing performed
            //comboBoxProcessPerformed.Items.Clear();
            //comboBoxProcessPerformed.Items.Add("Imaging");
            //comboBoxProcessPerformed.Items.Add("Logical Copy");
            //comboBoxProcessPerformed.Items.Add("Clone");
            //comboBoxProcessPerformed.Items.Add("Review");
            //comboBoxProcessPerformed.Items.Add("No Processing");

            ////forensic device used
            //comboBoxDeviceUsed.Items.Clear();
            //comboBoxDeviceUsed.Items.Add("Portable Computer");
            //comboBoxDeviceUsed.Items.Add("Write Blocker");
            //comboBoxDeviceUsed.Items.Add("TD1 Duplicator");
            //comboBoxDeviceUsed.Items.Add("Other");

            ////software used
            //comboBoxSoftwareProcessing.Items.Clear();
            //comboBoxSoftwareProcessing.Items.Add("FTK Imager");
            //comboBoxSoftwareProcessing.Items.Add("EnCase");
            //comboBoxSoftwareProcessing.Items.Add("Helix Pro");
            //comboBoxSoftwareProcessing.Items.Add("Other");
            //comboBoxSoftwareProcessing.Items.Add("Version");


            ////images made
            //comboBoxImagesMade.Items.Clear();
            //comboBoxImagesMade.Items.Add("EDD");
            //comboBoxImagesMade.Items.Add("Examination Copy");
            //comboBoxImagesMade.Items.Add("Clone Copy");
            //comboBoxImagesMade.Items.Add("Archive");
            //comboBoxImagesMade.Items.Add("Other");

            ////images verified by
            //comboBoxImagesVerifiedBy.Items.Clear();
            //comboBoxImagesVerifiedBy.Items.Add("MD5 Hash");
            //comboBoxImagesVerifiedBy.Items.Add("SHA1 Hash");
            //comboBoxImagesVerifiedBy.Items.Add("SHA 256 Hash");
            //comboBoxImagesVerifiedBy.Items.Add("Not Verified");
            //comboBoxImagesVerifiedBy.Items.Add("Other");
        }
        public override void OnSave(EventArgs e)
        {
            MakeForensicProcess();
        }

        private void MakeForensicProcess()
        {

            IList<HardDrive> selectedHardDrives = new List<HardDrive>();
            IList<Computer> selectedComputers = new List<Computer>();


            foreach (var item in checkedListBoxAssociatedhardDrives.CheckedItems)
            {
                int i = checkedListBoxAssociatedhardDrives.Items.IndexOf(item);
                selectedHardDrives.Add(SelectableAssociatedHardDrives.ElementAt(i));
            }

            foreach (var item in checkedListBoxAssociatedcomputers.CheckedItems)
            {
                int i = checkedListBoxAssociatedcomputers.Items.IndexOf(item);
                selectedComputers.Add(SelectableAssociatedComputers.ElementAt(i));
            }


            NewForensicProcess = new ForensicProcess()
                                     {
                                         //collection onformation
                                         CollectionLocation = textBoxCollectionLocation.Text,
                                         RoomNumber = textBoxRoomNumber.Text,
                                         CustodianOrUser = textBoxCustodianUser.Text,
                                         PhotoWasTaken = checkBoxPhotosWereTaken.Checked,
                                         WasImageOnly = checkBoxOnlyImageWasReceived.Checked,
                                         WasHardDriveOnly = checkBoxOnlyHardDriveWasReceived.Checked,
                                         ProcessingPerformed = comboBoxProcessPerformed.Text,
                                         ForensicDeviceUsed = comboBoxDeviceUsed.Text,
                                         Software = comboBoxSoftwareProcessing.Text,
                                         ImagesMade = comboBoxImagesMade.Text,
                                         ImagesVerifiedBy = comboBoxImagesVerifiedBy.Text,
                                         CdfInfo = new CdfInfo()
                                                       {
                                                           IsFinishDate = true,
                                                           Cdfdate = dateTimePickerFPFinishDateTime.Value,
                                                           TechExaminer = SelectSingleEntityById.SelectEmployeeById(new Guid(comboBoxCDFInfoTech.SelectedValue.ToString()))
                                                       },
                                         DestinationMediae = ForensicProcessDestinationMediae,

                                         ReferenceHardDrives = selectedHardDrives,
                                         ReferenceComputers = selectedComputers,
                                     };
            ForensicProcessDestinationMediae.ToList().ForEach(dm => dm.SerialNumber = NewForensicProcess.ToString());
        }



        private Create_DestinationMedia newDMSubForm = null;

        private void buttonAddDestinationMedia_Click(object sender, EventArgs e)
        {
            this.newDMSubForm = new Create_DestinationMedia();
            newDMSubForm.OnDataAvailable += AddDestinationMediaToList;
            newDMSubForm.FormClosed += UpdateFormEvent;
            newDMSubForm.Show();
        }

        private void AddDestinationMediaToList(object sender, EventArgs e)
        {
            var newDestinationMedia = newDMSubForm.NewDestinationMedia;
            ForensicProcessDestinationMediae.Add(newDestinationMedia);
            EntitiesToListView.FillDestinationMediaListViewDetailView(ForensicProcessDestinationMediae, listViewDestinationMedia);
        }

        private void buttonDeleteDestinationMedia_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            Create_Employee newEmployeeForm = new Create_Employee();
            newEmployeeForm.FormClosed += UpdateFormEvent;
            newEmployeeForm.Show();
        }

        private void buttonAddProcessPerformed_Click(object sender, EventArgs e)
        {
            addProcessPerformedHelper.SummonUtilityList();
        }

        private void buttonAddDeviceUsed_Click(object sender, EventArgs e)
        {
            addDeviceUsedHelper.SummonUtilityList();
        }

        private void buttonAddSoftware_Click(object sender, EventArgs e)
        {
            addSoftwareHelper.SummonUtilityList();
        }

        private void buttonAddImagesMade_Click(object sender, EventArgs e)
        {
            addImagesMadeHelper.SummonUtilityList();
        }

        private void buttonAddImagesVerifiedBy_Click(object sender, EventArgs e)
        {
            addImagesVerifiedByHelper.SummonUtilityList();
        }

    
    }


}

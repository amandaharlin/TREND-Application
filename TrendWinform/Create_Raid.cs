using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate.Collection.Generic;
using TrendWinForm.Domain.Entities;
using TrendWinForm.MyUtilities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm
{
    public partial class Create_Raid : Create_BaseForm
    {

        public Raid NewRaid { get; set; }

        public IList<HardDrive> SelectableHardDrives { get; set; }

        public Create_Raid()
        {
            InitializeComponent();
            IntializeRadioButtons();
            textBoxRaidLevelOther.Enabled = false;
        }


        

        public override void OnSave(EventArgs e)
        {
            MakeNewRaid();
            
        }

        private void Create_Raid_Load(object sender, EventArgs e)
        {
            PopulateCheckBoxList();
        }

        private void IntializeRadioButtons()
        {
            RadioButtonListUtilities.SelectFirstRadioInGroup(groupBoxHardwareOrSoftware);
            RadioButtonListUtilities.SelectFirstRadioInGroup(groupBoxRaidLevel);
        }

        private void PopulateCheckBoxList()
        {

            var displayDrives = SelectableHardDrives.ToDictionary(hd => hd, hd => hd.Make + " | " + hd.Model);


            if (SelectableHardDrives.Any())
            {
                checkedListBoxOfHardDrives.DataSource = new BindingSource(displayDrives, null);
                checkedListBoxOfHardDrives.DisplayMember = "Value";
                checkedListBoxOfHardDrives.ValueMember = "Key";

            }
            else
            {
                checkedListBoxOfHardDrives.DataSource = null;

            }
        }

        

        private void MakeNewRaid()
        {
            IList<HardDrive> selectedHardDrives = new List<HardDrive>();
            //IList<HardDrive> selectedHardDrives = (from object item in checkedListBoxOfHardDrives.CheckedItems select checkedListBoxOfHardDrives.Items.IndexOf(item) into i select SelectableHardDrives.ElementAt(i)).ToList();
            foreach (var item in checkedListBoxOfHardDrives.CheckedItems)
            {
                int i = checkedListBoxOfHardDrives.Items.IndexOf(item);
                selectedHardDrives.Add(SelectableHardDrives.ElementAt(i));
            }

            string HardOrSoft = RadioButtonListUtilities.ExtractTextFromRadioButtonGroup(groupBoxHardwareOrSoftware);

            RaidType raidType;
            if(HardOrSoft.ToUpper() == "HARDWARE")
            {
                raidType = TrendWinForm.Domain.Entities.RaidType.Hardware;
            }else
            {
                raidType = TrendWinForm.Domain.Entities.RaidType.Software;
            }

            NewRaid = new Raid()
                          {
                              //raid information
                              SoftwareOrHardware = raidType,
                              RaidType = txtTypeofRaid.Text,
                              RaidLevel = RadioButtonListUtilities.ExtractTextFromRadioButtonGroup(groupBoxRaidLevel),
                              AssociatedHardDrives = selectedHardDrives

                          };


           selectedHardDrives.ToList().ForEach(hd => hd.ReferenceRaid = NewRaid);
        }

        private void radioButtonRaidLevelOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRaidLevelOther.Checked)
            {
                textBoxRaidLevelOther.Enabled = true;
            }
            else
            {
                textBoxRaidLevelOther.Enabled = false;
            }
        }

        
    }
}

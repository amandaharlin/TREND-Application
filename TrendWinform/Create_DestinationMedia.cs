using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrendWinForm.Domain.Entities;
using TrendWinForm.FluentMappings;
using TrendWinForm.MyUtilities;
using TrendWinForm.Domain.ValueObjects;
using System.Text.RegularExpressions;

namespace TrendWinForm
{
    public partial class Create_DestinationMedia : Create_BaseForm
    {
        public DestinationMedia NewDestinationMedia { get; set; }
        private UtilityListFormHelper addBrandType;

        public Create_DestinationMedia()
        {
            InitializeComponent();
            addBrandType = new UtilityListFormHelper("Brand_Type", comboBoxBrandOutput);
            PopulateFormComboBoxes();


        }

        private void UpdateFormEvent(object sender, EventArgs e)
        {
            PopulateFormComboBoxes();

        }

        private void PopulateFormComboBoxes()
        {
            //destination media
            comboBoxDestinationMedia.Items.Clear();
            comboBoxDestinationMedia.Items.Add("Hard Drive");
            comboBoxDestinationMedia.Items.Add("External Drive");
            comboBoxDestinationMedia.Items.Add("DVD");
            comboBoxDestinationMedia.Items.Add("CD");
            comboBoxDestinationMedia.Items.Add("SAN");
            comboBoxDestinationMedia.Items.Add("Other");

            addBrandType.PopulateComboBoxWithUtilityStrings();
        }

        public override void OnSave(EventArgs e)
        {
            MakeDestinationMedia();
        }


        private void textBoxSizeOutput_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(textBoxSizeOutput, string.Empty);
            if (ErrorProviders.HasSomethingOtherThanNumbers(textBoxSizeOutput.Text))
            {
                errorProvider.SetError(textBoxSizeOutput, "This Control must be only numbers and not be empty");
                e.Cancel = true;
            }
        }

        private void MakeDestinationMedia()
        {
            NewDestinationMedia = new DestinationMedia()
            {
                Type = comboBoxDestinationMedia.Text,
                Brand = comboBoxBrandOutput.Text,
                Size = Convert.ToDecimal(textBoxSizeOutput.Text),
                SerialNumber = textBoxSerialNumber.Text

            };
        }

        private void buttonAddBrand_Click(object sender, EventArgs e)
        {
            addBrandType.SummonUtilityList();
        }
    }
}

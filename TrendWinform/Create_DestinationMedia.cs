using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using NHibernate.Linq;
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
        ImageList destinationMediaImageList = new ImageList();

        public Create_DestinationMedia()
        {




            InitializeComponent();
            addBrandType = new UtilityListFormHelper("Brand_Type", comboBoxBrandOutput);


            



            PopulateFormComboBoxes();

            InitializeDestinationMediaList();


        }

        private void UpdateFormEvent(object sender, EventArgs e)
        {
            PopulateFormComboBoxes();

        }

        private void InitializeDestinationMediaList()
        {

            //TODO:BIG IMAGES HERE!

            IList<String> images = new List<string>();
            images.Add("TrendWinForm.Images.Icons.solidState_hardDrive_48.png");
            images.Add("TrendWinForm.Images.Icons.Floppy-Drive_48.png");
            images.Add("TrendWinForm.Images.Icons.DVD_48.png");
            images.Add("TrendWinForm.Images.Icons.DVD_48.png");
            images.Add("TrendWinForm.Images.Icons.san_icon_48.png");
            images.Add("TrendWinForm.Images.Icons.Floppy-Drive_48.png");
            images.Add("TrendWinForm.Images.Icons.mystery_computer_48.png");
            destinationMediaImageList.ImageSize = new System.Drawing.Size(48, 48);
            destinationMediaImageList.ColorDepth = ColorDepth.Depth32Bit;
            images.ForEach(image =>
            {
                Assembly myAssembly = Assembly.GetExecutingAssembly();
                Stream myStream = myAssembly.GetManifestResourceStream(image);
                Bitmap img = new Bitmap(myStream);
                destinationMediaImageList.Images.Add(img);
            }
                );
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
            comboBoxDestinationMedia.Items.Add("Floppy");
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

        private void comboBoxDestinationMedia_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(comboBoxDestinationMedia, string.Empty);
            if (comboBoxDestinationMedia.Text == "")
            {
                errorProvider.SetError(textBoxSizeOutput, "Media type is required.");
                e.Cancel = true;
            }

        }

        private void comboBoxBrandOutput_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(comboBoxBrandOutput, string.Empty);
            if (comboBoxBrandOutput.Text == "")
            {
                errorProvider.SetIconPadding(comboBoxBrandOutput, 25);
                errorProvider.SetError(textBoxSizeOutput, "Brand is required. Add it to the list if not present.");
                e.Cancel = true;
            }


        }

        private void comboBoxDestinationMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxDestinationMedia.Text == "Hard Drive")
            {
                pictureBox_DestinationMedia.Image = destinationMediaImageList.Images[0];
            }
            else if (comboBoxDestinationMedia.Text == "External Drive")
            {
                pictureBox_DestinationMedia.Image = destinationMediaImageList.Images[1];
            }
            else if (comboBoxDestinationMedia.Text == "DVD")
            {
                pictureBox_DestinationMedia.Image = destinationMediaImageList.Images[2];
            }
            else if (comboBoxDestinationMedia.Text == "CD")
            {
                pictureBox_DestinationMedia.Image = destinationMediaImageList.Images[3];
            }
            else if (comboBoxDestinationMedia.Text == "SAN")
            {
                pictureBox_DestinationMedia.Image = destinationMediaImageList.Images[4];
            }
            else if (comboBoxDestinationMedia.Text == "Floppy")
            {
                pictureBox_DestinationMedia.Image = destinationMediaImageList.Images[5];
            }
            else 
            {
                pictureBox_DestinationMedia.Image = destinationMediaImageList.Images[6];
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrendWinForm.Domain.Entities;
using TrendWinForm.MyUtilities;

namespace TrendWinForm
{
    public partial class Create_ActiveUserFile : Create_BaseForm
    {
        public IList<Computer> ReferenceComputers { get; set; }
        public ActiveUserFile NewActiveUserFile { get; set; }

        //form Level Events
        public Create_ActiveUserFile()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Create_ActiveUserFile_Shown(object sender, EventArgs e)
        {
            var comboDictionaryOfComputers = new Dictionary<string, Computer>();
            ReferenceComputers.ToList().ForEach(x =>
            {
                comboDictionaryOfComputers.Add((x.Make + " " + x.Model + " [" + x.SerialNumber + "]"), x);
            });

            comboBoxAUFReferenceComputer.DataSource = new BindingSource(comboDictionaryOfComputers, null);
            comboBoxAUFReferenceComputer.DisplayMember = "Key";
            comboBoxAUFReferenceComputer.ValueMember = "Value";

            EntitiesToComboBox.FillEmployeeComboBox(comboBoxCdfInfoTech);
        }

        public override void OnSave(EventArgs e)
        {
            MakeActiveUserFile();
        }

        //Create Entity Event
        private void MakeActiveUserFile()
        {
            NewActiveUserFile = new ActiveUserFile()
                                    {
                                        ReferenceComputer = (Computer)comboBoxAUFReferenceComputer.SelectedValue,
                                        FileName = textBoxAUFFileName.Text,
                                        Description = textBoxAUFDescription.Text,
                                        MemoryUsage = decimal.Parse(textBoxAUFMemoryUsage.Text == String.Empty ? "0" : textBoxAUFMemoryUsage.Text),
                                        CpuUsage = decimal.Parse(textBoxAUFCPUUsage.Text == String.Empty ? "0" : textBoxAUFCPUUsage.Text),
                                        CdfInfo = new CdfInfo()
                                        {
                                            TechExaminer = SelectSingleEntityById.SelectEmployeeById(new Guid(comboBoxCdfInfoTech.SelectedValue.ToString())),
                                            IsFinishDate = true,
                                            Cdfdate = dateTimePickerCDFDate.Value,
                                        }
                                    };
        }

       
        //Control Special Events
        private void trackBarMemoryUsage_ValueChanged(object sender, EventArgs e)
        {
            textBoxAUFMemoryUsage.Text = (trackBarMemoryUsage.Value * 0.1).ToString();
        }

        private void trackBarCpuUsage_ValueChanged(object sender, EventArgs e)
        {
            textBoxAUFCPUUsage.Text = (trackBarCpuUsage.Value * 0.1).ToString();
        }

        private void textBoxAUFMemoryUsage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBoxAUFCPUUsage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }


         //Validation
        
        private void comboBoxAUFReferenceComputer_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(comboBoxAUFReferenceComputer, string.Empty);
            if (comboBoxAUFReferenceComputer.Text == "")
            {
                errorProvider.SetError(comboBoxAUFReferenceComputer, "You must associate a computer with this active user file.");

                e.Cancel = true;
            }
        }

        private void textBoxAUFFileName_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(textBoxAUFFileName, string.Empty);
            if (textBoxAUFFileName.Text == "")
            {
                errorProvider.SetError(textBoxAUFFileName, "You must specify the type of program.");

                e.Cancel = true;
            }

        }

        

     




    }
}

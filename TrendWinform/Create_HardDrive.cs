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
using TrendWinForm.Domain.ValueObjects;
using System.Text.RegularExpressions;

namespace TrendWinForm
{
    public partial class Create_HardDrive : Create_BaseForm
    {
        public HardDrive NewHardDrive { get; set; }


        private UtilityListFormHelper addMakeHelper;
        private UtilityListFormHelper addModelHelper;

        private int GlobalJumperValue = 0;
        private JumperDiagram jumperDiagram = new JumperDiagram()
        {
            Jumper_0 = 0,
            Jumper_1 = 0,
            Jumper_2 = 0,
            Jumper_3 = 0,
            Jumper_4 = 0,
            Jumper_5 = 0,
            Jumper_6 = 0,
            Jumper_7 = 0,
            Jumper_8 = 0,
            Jumper_9 = 0
        };



        public Create_HardDrive()
        {
            InitializeComponent();



            addMakeHelper = new UtilityListFormHelper("Hard_Drive_Make", comboBoxHDMake, this);
            addModelHelper = new UtilityListFormHelper("Hard_Drive_Model", comboBoxHDModel, this);

            PopulateFormComboBoxes();
            IntializeRadioButtons();
            textBoxJumperSettingsOther.Enabled = false;
            textBoxDriveInterfaceOther.Enabled = false;
            textBoxDrivePositionOther.Enabled = false;
        }

        private void IntializeRadioButtons()
        {
            RadioButtonListUtilities.SelectFirstRadioInGroup(groupBoxDriveInterface);
            RadioButtonListUtilities.SelectFirstRadioInGroup(groupBoxDrivePostitionAsInstalled);
            RadioButtonListUtilities.SelectFirstRadioInGroup(groupBoxJumperSettings);

        }

        private void PopulateFormComboBoxes()
        {
            comboBoxHDType.Items.Clear();
            comboBoxHDType.Items.Add("Solid State Drive");
            comboBoxHDType.Items.Add("Consumer Internal Disk Drive");
            comboBoxHDType.Items.Add("Enterprise Internal Disk Drive");
            comboBoxHDType.Items.Add("External Disk Drive");
            comboBoxHDType.Items.Add("External Flash Drive");
            comboBoxHDType.Items.Add("Other");

            EntitiesToComboBox.FillEmployeeComboBox(comboBoxCdfInfoTech);

            addMakeHelper.PopulateComboBoxWithUtilityStrings();
            addModelHelper.PopulateComboBoxWithUtilityStrings();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            Create_Employee newEmployeeForm = new Create_Employee();
            newEmployeeForm.FormClosed += this.UpdateFormEvent;
            newEmployeeForm.MdiParent = MdiParent;
            newEmployeeForm.Show();
        }

        private void UpdateFormEvent(object sender, EventArgs e)
        {

            var comboBoxesList = UtilityQueries.ReturnDictionaryOfComboBoxes(this);
            PopulateFormComboBoxes();
            comboBoxesList.ToList().ForEach(c => { c.Key.SelectedIndex = c.Key.FindStringExact(c.Value); });


        }

        public override void OnSave(EventArgs e)
        {
            MakeHardDrive();
        }

        private void MakeHardDrive()
        {
            NewHardDrive = new HardDrive()
                               {
                                   //hard drive information
                                   Make = comboBoxHDMake.Text,
                                   Model = comboBoxHDModel.Text,
                                   Type = comboBoxHDType.Text,
                                   Serial = textBoxSerialNum.Text,
                                   SizeInGB = Convert.ToDecimal(textBoxSize.Text),
                                   DriveInterface = RadioButtonListUtilities.ExtractTextFromRadioButtonGroup(groupBoxDriveInterface),
                                   DrivePosition = RadioButtonListUtilities.ExtractTextFromRadioButtonGroup(groupBoxDrivePostitionAsInstalled),
                                   JumperSetting = RadioButtonListUtilities.ExtractTextFromRadioButtonGroup(groupBoxJumperSettings),
                                   JumperDiagram = jumperDiagram,
                                   CDFInfo = new CdfInfo()
                                                 {
                                                     IsFinishDate = true,
                                                     Cdfdate = dateTimePickerCDFDate.Value,
                                                     TechExaminer = SelectSingleEntityById.SelectEmployeeById(new Guid(comboBoxCdfInfoTech.SelectedValue.ToString())),

                                                 }
                               };
        }



        private void buttonAddMake_Click(object sender, EventArgs e)
        {
            addMakeHelper.SummonUtilityList();
        }

        private void buttonAddModel_Click(object sender, EventArgs e)
        {
            addModelHelper.SummonUtilityList();
        }


        private void textBoxSerialNum_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(textBoxSerialNum, string.Empty);
            if (textBoxSerialNum.Text == "")
            {
                errorProvider.SetError(textBoxSerialNum, "This Must Have a value!");
                e.Cancel = true;
            }
        }

        private void textBoxSize_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(textBoxSize, string.Empty);
            if (ErrorProviders.HasSomethingOtherThanNumbers(textBoxSize.Text))
            {
                errorProvider.SetError(textBoxSize, "This Control must be only numbers and not be empty");
                e.Cancel = true;
            }
        }

        private void comboBoxCdfInfoTech_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(comboBoxCdfInfoTech, string.Empty);
            if (comboBoxCdfInfoTech.Text == "")
            {
                errorProvider.SetError(comboBoxCdfInfoTech, "This Must Have a value!");
                e.Cancel = true;
            }
        }

        private void comboBoxHDMake_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(comboBoxHDMake, string.Empty);
            if (comboBoxHDMake.Text == "")
            {
                errorProvider.SetError(comboBoxHDMake, "This must have a value.");
                e.Cancel = true;
            }
        }

        private void comboBoxHDModel_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(comboBoxHDModel, string.Empty);
            if (comboBoxHDModel.Text == "")
            {
                errorProvider.SetError(comboBoxHDModel, "This must have a value.");
                e.Cancel = true;
            }
        }

        private void comboBoxHDType_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(comboBoxHDType, string.Empty);
            if (comboBoxHDType.Text == "")
            {
                errorProvider.SetError(comboBoxHDType, "This must have a value.");
                e.Cancel = true;
            }
        }



        private void buttonClearJumperSettings_Click(object sender, EventArgs e)
        {
            jumperDiagram.Jumper_0 = 0;
            jumperDiagram.Jumper_1 = 0;
            jumperDiagram.Jumper_2 = 0;
            jumperDiagram.Jumper_3 = 0;
            jumperDiagram.Jumper_4 = 0;
            jumperDiagram.Jumper_5 = 0;
            jumperDiagram.Jumper_6 = 0;
            jumperDiagram.Jumper_7 = 0;
            jumperDiagram.Jumper_8 = 0;
            jumperDiagram.Jumper_9 = 0;
            jumperPosition0.BackColor = Color.White;
            jumperPosition1.BackColor = Color.White;
            jumperPosition2.BackColor = Color.White;
            jumperPosition3.BackColor = Color.White;
            jumperPosition4.BackColor = Color.White;
            jumperPosition5.BackColor = Color.White;
            jumperPosition6.BackColor = Color.White;
            jumperPosition7.BackColor = Color.White;
            jumperPosition8.BackColor = Color.White;
            jumperPosition9.BackColor = Color.White;

        }

        //Jumper stuff
        private void jumperPosition0_Click(object sender, EventArgs e)
        {
            setButtonColorAndJumperValue(jumperPosition0);
        }

        private void jumperPosition1_Click(object sender, EventArgs e)
        {
            setButtonColorAndJumperValue(jumperPosition1);
        }

        private void jumperPosition2_Click(object sender, EventArgs e)
        {
            setButtonColorAndJumperValue(jumperPosition2);
        }

        private void jumperPosition3_Click(object sender, EventArgs e)
        {
            setButtonColorAndJumperValue(jumperPosition3);
        }

        private void jumperPosition4_Click(object sender, EventArgs e)
        {
            setButtonColorAndJumperValue(jumperPosition4);
        }

        private void jumperPosition5_Click(object sender, EventArgs e)
        {
            setButtonColorAndJumperValue(jumperPosition5);
        }

        private void jumperPosition6_Click(object sender, EventArgs e)
        {
            setButtonColorAndJumperValue(jumperPosition6);

        }

        private void jumperPosition7_Click(object sender, EventArgs e)
        {
            setButtonColorAndJumperValue(jumperPosition7);
        }

        private void jumperPosition8_Click(object sender, EventArgs e)
        {
            setButtonColorAndJumperValue(jumperPosition8);
        }

        private void jumperPosition9_Click(object sender, EventArgs e)
        {
            setButtonColorAndJumperValue(jumperPosition9);
        }


        private void setButtonColorAndJumperValue(Button jumper)
        {
            switch (GlobalJumperValue)
            {

                case 1:
                    jumper.BackColor = Color.Lime;
                    break;
                case 2:
                    jumper.BackColor = Color.Red;
                    break;
                case 3:
                    jumper.BackColor = Color.Aqua;
                    break;
                case 4:
                    jumper.BackColor = Color.Yellow;
                    break;
                case 5:
                    jumper.BackColor = Color.FromArgb(64, 64, 64);
                    break;
                default:
                    jumper.BackColor = Color.White;
                    break;
            }

            switch (jumper.Name)
            {
                case "jumperPosition0":
                    jumperDiagram.Jumper_0 = GlobalJumperValue;
                    break;
                case "jumperPosition1":
                    jumperDiagram.Jumper_1 = GlobalJumperValue;
                    break;
                case "jumperPosition2":
                    jumperDiagram.Jumper_2 = GlobalJumperValue;
                    break;
                case "jumperPosition3":
                    jumperDiagram.Jumper_3 = GlobalJumperValue;
                    break;
                case "jumperPosition4":
                    jumperDiagram.Jumper_4 = GlobalJumperValue;
                    break;
                case "jumperPosition5":
                    jumperDiagram.Jumper_5 = GlobalJumperValue;
                    break;
                case "jumperPosition6":
                    jumperDiagram.Jumper_6 = GlobalJumperValue;
                    break;
                case "jumperPosition7":
                    jumperDiagram.Jumper_7 = GlobalJumperValue;
                    break;
                case "jumperPosition8":
                    jumperDiagram.Jumper_8 = GlobalJumperValue;
                    break;
                case "jumperPosition9":
                    jumperDiagram.Jumper_9 = GlobalJumperValue;
                    break;
                default:
                    MessageBox.Show("Jumper diagram error");
                    break;
            }


        }

        private void radioButtonGreenJumper_CheckedChanged(object sender, EventArgs e)
        {
            changeGlobalJumperValueAndIlluminateRadio(radioButtonGreenJumper);
        }

        private void radioButtonRedJumper_CheckedChanged(object sender, EventArgs e)
        {
            changeGlobalJumperValueAndIlluminateRadio(radioButtonRedJumper);
        }

        private void radioButtonBlueJumper_CheckedChanged(object sender, EventArgs e)
        {
            changeGlobalJumperValueAndIlluminateRadio(radioButtonBlueJumper);
        }

        private void radioButtonYellowJumper_CheckedChanged(object sender, EventArgs e)
        {
            changeGlobalJumperValueAndIlluminateRadio(radioButtonYellowJumper);
        }

        private void radioButtonBlackJumper_CheckedChanged(object sender, EventArgs e)
        {
            changeGlobalJumperValueAndIlluminateRadio(radioButtonBlackJumper);
        }

        private void radioButtonDefaultJumper_CheckedChanged(object sender, EventArgs e)
        {
            changeGlobalJumperValueAndIlluminateRadio(radioButtonDefaultJumper);
        }

        private void changeGlobalJumperValueAndIlluminateRadio(RadioButton radio)
        {

            resetRadioBackcolors();
            switch (radio.Name)
            {
                case "radioButtonGreenJumper":
                    if (radio.Checked)
                    {
                        radio.BackColor = Color.Lime;
                        radio.ForeColor = Color.Green;
                        GlobalJumperValue = 1;
                    }
                    break;
                case "radioButtonRedJumper":
                    if (radio.Checked)
                    {
                        radio.BackColor = Color.Red;
                        radio.ForeColor = Color.Maroon;
                        GlobalJumperValue = 2;
                    }

                    break;
                case "radioButtonBlueJumper":
                    if (radio.Checked)
                    {
                        radio.BackColor = Color.Aqua;
                        radio.ForeColor = Color.Blue;
                        GlobalJumperValue = 3;
                    }

                    break;
                case "radioButtonYellowJumper":
                    if (radio.Checked)
                    {
                        radio.BackColor = Color.Yellow;
                        radio.ForeColor = Color.FromArgb(64, 64, 64);
                        GlobalJumperValue = 4;
                    }

                    break;
                case "radioButtonBlackJumper":
                    if (radio.Checked)
                    {
                        radio.BackColor = Color.Black;
                        radio.ForeColor = Color.White;
                        GlobalJumperValue = 5;
                    }

                    break;
                case "radioButtonDefaultJumper":
                    if (radio.Checked)
                    {
                        radio.BackColor = Color.White;
                        radio.ForeColor = Color.Magenta;
                        GlobalJumperValue = 0;
                    }
                    break;
                default:
                    MessageBox.Show("Jumper diagram error");
                    break;
            }
        }

        private void resetRadioBackcolors()
        {
            radioButtonGreenJumper.BackColor = Color.FromArgb(0, 192, 0);
            radioButtonRedJumper.BackColor = Color.FromArgb(192, 0, 0);
            radioButtonBlueJumper.BackColor = Color.FromArgb(0, 192, 192);
            radioButtonYellowJumper.BackColor = Color.FromArgb(192, 192, 0);
            radioButtonBlackJumper.BackColor = Color.FromArgb(64, 64, 64);

            radioButtonGreenJumper.ForeColor = Color.WhiteSmoke;
            radioButtonRedJumper.ForeColor = Color.WhiteSmoke;
            radioButtonBlueJumper.ForeColor = Color.WhiteSmoke;
            radioButtonYellowJumper.ForeColor = Color.WhiteSmoke;
            radioButtonBlackJumper.ForeColor = Color.WhiteSmoke;

            radioButtonDefaultJumper.ForeColor = Color.Black;

            radioButtonDefaultJumper.BackColor = Color.White;
        }

        private void radioButtonJumperOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonJumperOther.Checked)
            {
                textBoxJumperSettingsOther.Enabled = true;
            }
            else
            {
                textBoxJumperSettingsOther.Clear();
                textBoxJumperSettingsOther.Enabled = false;
            }
        }

        private void radioButtonDriveInterfaceOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDriveInterfaceOther.Checked)
            {
                textBoxDriveInterfaceOther.Enabled = true;
            }
            else
            {
                textBoxDriveInterfaceOther.Clear();
                textBoxDriveInterfaceOther.Enabled = false;
            }
        }

        private void radioButtonDrivePositionOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDrivePositionOther.Checked)
            {
                textBoxDrivePositionOther.Enabled = true;
            }
            else
            {
                textBoxDrivePositionOther.Clear();
                textBoxDrivePositionOther.Enabled = false;
            }
        }





    }
}


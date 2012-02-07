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

        public Create_ActiveUserFile()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        public override void OnSave(EventArgs e)
        {
            MakeActiveUserFile();
        }

        private void MakeActiveUserFile()
        {
            NewActiveUserFile = new ActiveUserFile()
                                    {
                                        ReferenceComputer = (Computer)comboBoxAUFReferenceComputer.SelectedItem,
                                        FileName = textBoxAUFFileName.Text,
                                        Description = textBoxAUFDescription.Text,
                                        MemoryUsage = decimal.Parse(textBoxAUFMemoryUsage.Text),
                                        CpuUsage = decimal.Parse(textBoxAUFCPUUsage.Text),
                                        CdfInfo = new CdfInfo()
                                        {
                                            TechExaminer = SelectSingleEntityById.SelectEmployeeById(new Guid(comboBoxCdfInfoTech.SelectedValue.ToString())),
                                            IsFinishDate = true,
                                            Cdfdate = dateTimePickerCDFDate.Value,
                                        }
                                    };
        }

        private void Create_ActiveUserFile_Shown(object sender, EventArgs e)
        {
            ReferenceComputers.ToList().ForEach(x =>
                                                    {
                                                        comboBoxAUFReferenceComputer.Items.Add(x);
                                                    });
            comboBoxAUFReferenceComputer.DisplayMember = "Model";
            EntitiesToComboBox.FillEmployeeComboBox(comboBoxCdfInfoTech);
        }




    }
}

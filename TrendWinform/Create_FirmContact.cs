using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrendWinForm.Domain.ValueObjects;
using TrendWinForm.Domain.Entities;
using TrendWinForm.MyUtilities;

namespace TrendWinForm
{
    public partial class Create_FirmContact : Create_BaseForm
    {
        public Create_FirmContact()
        {
            InitializeComponent();
        }

        private void firmContactBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.firmContactBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trendDataSet);
        }

        private void Create_FirmContact_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'trendDataSet.Firm' table. You can move, or remove it, as needed.
            this.firmTableAdapter.Fill(this.trendDataSet.Firm);
            // TODO: This line of code loads data into the 'trendDataSet.FirmContact' table. You can move, or remove it, as needed.
            this.firmContactTableAdapter.Fill(this.trendDataSet.FirmContact);

            EntitiesToComboBox.FillFirmComboBox(firm_idComboBox);

        }

        public override void OnSave(EventArgs e)
        {
            SaveFirmContact();
        }

        private void SaveFirmContact()
        {
            var factory = SessionConfig.SessionFactory;

            
            PhoneNumber _phone = UserContolToValueObject.ReturnPhoneNumber(phoneUserControl1);
            Name _name = UserContolToValueObject.ReturnName(nameUserControl1);
            
            var firm = SelectSingleEntityById.SelectFirmById(new Guid(firm_idComboBox.SelectedValue.ToString()));

            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var newFirmContact = new FirmContact()
                    {
                        Name = _name,
                        PhoneNumber = _phone,
                        Notes = notesTextbox.Text,
                        Position = positionTextbox.Text,
                        Firm = firm
                    };

                    session.Save(newFirmContact);
                    transaction.Commit();
                }
            }
        }

        private void ShowFirmDetails()
        {
            if(firm_idComboBox.SelectedValue != null)
            {
                var selectedfirm = new Guid(firm_idComboBox.SelectedValue.ToString());
                var firm = SelectSingleEntityById.SelectFirmById(selectedfirm);
                textBoxCity.Text = firm.Address.City;
                textBoxStreet1.Text = firm.Address.StreetLine1;
                textBoxStreet2.Text = firm.Address.StreetLine2;
                textBoxState.Text = firm.Address.State;
                textBoxZipCode.Text = firm.Address.ZipCode;
                textboxAreaCode.Text = firm.PhoneNumber.AreaCode.ToString();

                textBoxPhoneNumber.Text = firm.PhoneNumber.Number.ToString();

                //textBoxPhoneFirstThree.Text = firm.PhoneNumber.Number
                //textBoxPhoneFirstThree.Text = firm.PhoneNumber.FirstThreeDigits.ToString();
                //textBoxPhoneLastFour.Text = firm.PhoneNumber.LastFourDigits.ToString();
                
                
                textBoxExtension.Text = firm.PhoneNumber.Extension.ToString();


                //textBoxPhoneNumber.Text = string.Format(firm.PhoneNumber.AreaCode + firm.PhoneNumber.Number + " [" + firm.PhoneNumber.Extension + "]");
                //textBoxPhoneNumber.Text = firm.PhoneNumber.AreaCode + firm.PhoneNumber.FirstThreeDigits + " - " + firm.PhoneNumber.LastFourDigits + "[" + firm.PhoneNumber.Extension + "]";
                
                
                textBoxNotes.Text = firm.FirmDescription;
                groupBoxSelectedfirmDetails.Text = firm.FirmName;
            }
            else
            {
                textBoxCity.Text = "";
                textBoxStreet1.Text = "";
                textBoxStreet2.Text = "";
                textBoxState.Text = "";
                textBoxZipCode.Text = "";
                textboxAreaCode.Text = "";
                textBoxPhoneNumber.Text = "";
                //textBoxPhoneLastFour.Text = "";
                textBoxExtension.Text = "";
                textBoxNotes.Text = "";
                groupBoxSelectedfirmDetails.Text = "";
            }
        }

        private void firm_idComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowFirmDetails();
        }

        private void Create_FirmContact_Shown(object sender, EventArgs e)
        {
            ShowFirmDetails();
        }

        private Create_Firm newFirm = null;
        private void AddFirm_Click(object sender, EventArgs e)
        {
            this.newFirm = new Create_Firm();
            newFirm.FormClosed += Create_FirmContact_Load;
            newFirm.MdiParent = MdiParent;
            newFirm.Show();
        }
    }
}

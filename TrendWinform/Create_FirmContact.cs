using System;
using NHibernate;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;
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
            Validate();
            firmContactBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(trendDataSet);
        }

        private void Create_FirmContact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trendDataSet.Firm' table. You can move, or remove it, as needed.
            firmTableAdapter.Fill(trendDataSet.Firm);
            // TODO: This line of code loads data into the 'trendDataSet.FirmContact' table. You can move, or remove it, as needed.
            firmContactTableAdapter.Fill(trendDataSet.FirmContact);

            EntitiesToComboBox.FillFirmComboBox(firm_idComboBox);
        }

        public override void OnSave(EventArgs e)
        {
            SaveFirmContact();
        }

        private void SaveFirmContact()
        {
            ISessionFactory factory = SessionConfig.SessionFactory;


            PhoneNumber _phone = UserContolToValueObject.ReturnPhoneNumber(phoneUserControl1);
            Name _name = UserContolToValueObject.ReturnName(nameUserControl1);

            Firm firm = SelectSingleEntityById.SelectFirmById(new Guid(firm_idComboBox.SelectedValue.ToString()));

            using (ISession session = factory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var newFirmContact = new FirmContact
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
            if (firm_idComboBox.SelectedValue != null)
            {
                var selectedfirm = new Guid(firm_idComboBox.SelectedValue.ToString());
                Firm firm = SelectSingleEntityById.SelectFirmById(selectedfirm);
                textBoxCity.Text = firm.Address.City;
                textBoxStreet1.Text = firm.Address.StreetLine1;
                textBoxStreet2.Text = firm.Address.StreetLine2;
                textBoxState.Text = firm.Address.State;
                textBoxZipCode.Text = firm.Address.ZipCode;
                textboxAreaCode.Text = firm.PhoneNumber.AreaCode.ToString();

                textBoxPhoneNumber.Text = firm.PhoneNumber.Number.ToString();

                textBoxExtension.Text = firm.PhoneNumber.Extension;

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

        private Create_Firm newFirm;

        private void AddFirm_Click(object sender, EventArgs e)
        {
            newFirm = new Create_Firm();
            newFirm.FormClosed += Create_FirmContact_Load;
            newFirm.Show();
        }
    }
}

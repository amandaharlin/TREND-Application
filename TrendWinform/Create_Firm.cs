using System;
using System.Windows.Forms;
using NHibernate;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;
using TrendWinForm.MyUtilities;

namespace TrendWinForm
{
    public partial class Create_Firm : Create_BaseForm
    {
        public Create_Firm()
        {
            InitializeComponent();
        }

        private void firmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            firmBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(trendDataSet);
        }

        private void Create_Firm_Load(object sender, EventArgs e)
        {
            firmContactTableAdapter.Fill(trendDataSet.FirmContact);
            // TODO: This line of code loads data into the 'trendDataSet.Firm' table. You can move, or remove it, as needed.
            firmTableAdapter.Fill(trendDataSet.Firm);
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
                if (Controls[i] is RichTextBox)
                {
                    Controls[i].Text = "";
                }
            }
        }

        public override void OnSave(EventArgs e)
        {
            SaveFirm();
        }

        private void SaveFirm()
        {
            ISessionFactory factory = SessionConfig.SessionFactory;

            Address _address = UserContolToValueObject.ReturnAddress(addressUserControlFirm);
            PhoneNumber _phone = UserContolToValueObject.ReturnPhoneNumber(phoneUserControlFirm);

            using (ISession session = factory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    var newFirm = new Firm
                                      {
                                          FirmName = firmNameTextBox.Text,
                                          PhoneNumber = _phone,
                                          Address = _address,
                                          FirmDescription = firmDescriptionRichTextBox.Text,
                                      };

                    session.Save(newFirm);
                    transaction.Commit();
                }
            }
        }
    }
}

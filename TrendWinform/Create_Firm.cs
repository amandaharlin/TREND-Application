using System;
using System.Collections.Generic;
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
    public partial class Create_Firm : Create_BaseForm
    {
        public Create_Firm()
        {
            InitializeComponent();
        }

        private void firmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.firmBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trendDataSet);

        }

        private void Create_Firm_Load(object sender, EventArgs e)
        {
            
            this.firmContactTableAdapter.Fill(this.trendDataSet.FirmContact);
            // TODO: This line of code loads data into the 'trendDataSet.Firm' table. You can move, or remove it, as needed.
            this.firmTableAdapter.Fill(this.trendDataSet.Firm);
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    this.Controls[i].Text = "";
                }
                if (this.Controls[i] is RichTextBox)
                {
                    this.Controls[i].Text = "";
                }
            }
        }

        public override void OnSave(EventArgs e)
        {
            SaveFirm();
        }

        private void SaveFirm()
        {
            var factory = SessionConfig.SessionFactory;

            Address _address = UserContolToValueObject.ReturnAddress(addressUserControlFirm);
            PhoneNumber _phone = UserContolToValueObject.ReturnPhoneNumber(phoneUserControlFirm);

            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var newFirm = new Firm()
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

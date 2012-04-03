using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrendCustromControls
{
    public partial class PhoneUserControl : UserControl
    {
        public string Type
        {
            get { return cmbboxPhoneType.SelectedValue.ToString(); }
            set { cmbboxPhoneType.SelectedItem = value; }
        }

        public int AreaCode
        {
            get
            {
                string areaStr = textboxAreaCode.Text;
                int area;
                int.TryParse(areaStr, out area);
                return area;
            }
            set
            {
                if (value.ToString().Length == 3)
                {
                    textboxAreaCode.Text = value.ToString();
                }
            }
        }

        public int Number
        {
            get
            {
                string phone = textBoxPhoneFirstThree.Text + textBoxPhoneLastFour.Text;
                int phoneNumber;
                int.TryParse(phone, out phoneNumber);
                return phoneNumber;
            }
            set
            {
                string incomingNumber = value.ToString();
                if (incomingNumber.Length == 7)
                {
                    textBoxPhoneFirstThree.Text = incomingNumber.Substring(0, 3);
                    textBoxPhoneLastFour.Text = incomingNumber.Substring(2, 4);
                }
            }
        }

        public string Extension
        {
            get { return textBoxExtension.Text; }
            set { textBoxExtension.Text = value; }
        }

        public PhoneUserControl()
        {
            InitializeComponent();
            PopulateTypeCombobox();
        }


        private void PopulateTypeCombobox()
        {
            var types = new Dictionary<string, string>();
            types.Add("Mobile", "Mobile");
            types.Add("Office", "Office");
            types.Add("Home", "Home");
            types.Add("Fax", "Fax");
            types.Add("Other", "Other");

            cmbboxPhoneType.DataSource = new BindingSource(types, null);
            cmbboxPhoneType.DisplayMember = "Value";
            cmbboxPhoneType.ValueMember = "Key";
        }


        private void ueTxtAny_Enter(object sender, EventArgs e)
        {
            //This method will prevent the cursor from being positioned in the middle 
            //of a textbox when the user clicks in it.
            var textBox = sender as MaskedTextBox;

            if (textBox != null)
            {
                BeginInvoke((MethodInvoker) delegate
                                                {
                                                    int pos = textBox.SelectionStart;

                                                    if (pos > textBox.Text.Length)
                                                        pos = textBox.Text.Length;

                                                    textBox.Select(pos, 0);
                                                });
            }
        }
    }
}

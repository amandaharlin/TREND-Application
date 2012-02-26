using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq;


namespace TrendCustromControls
{
    public partial class AddressUserControl : UserControl
    {
        public string StreetLine1
        {
            get { return street1txt.Text; }
            set { street1txt.Text = value; }
        }
        public string StreetLine2
        {
            get { return street2txt.Text; }
            set { street2txt.Text = value; }
        }
        public string City
        {
            get { return citytxt.Text; }
            set { citytxt.Text = value; }
        }
        public string State
        {
            get { return stateCombo.SelectedValue.ToString(); }
            set { stateCombo.SelectedItem = value; }
        }
        public string ZipCode
        {
            get { return zipcodetxt.Text; }
            set { zipcodetxt.Text = value; }
        }

        public AddressUserControl()
        {
            InitializeComponent();
            PopulateStateCombobox();
           
        }

        

        private void PopulateStateCombobox()
        {
            var states = new Dictionary<string, string>();
            states.Add("AL", "Alabama");
            states.Add("AK", "Alaska");
            states.Add("AZ", "Arizona");
            states.Add("AR", "Arkansas");
            states.Add("CA", "California");
            states.Add("CO", "Colorado");
            states.Add("CT", "Connecticut");
            states.Add("DE", "Delaware");
            states.Add("DC", "District of Columbia");
            states.Add("FL", "Florida");
            states.Add("GA", "Georgia");
            states.Add("HI", "Hawaii");
            states.Add("ID", "Idaho");
            states.Add("IL", "Illinois");
            states.Add("IN", "Indiana");
            states.Add("IA", "Iowa");
            states.Add("KS", "Kansas");
            states.Add("KY", "Kentucky");
            states.Add("LA", "Louisiana");
            states.Add("ME", "Maine");
            states.Add("MD", "Maryland");
            states.Add("MA", "Massachusetts");
            states.Add("MI", "Michigan");
            states.Add("MN", "Minnesota");
            states.Add("MS", "Mississippi");
            states.Add("MO", "Missouri");
            states.Add("MT", "Montana");
            states.Add("NE", "Nebraska");
            states.Add("NV", "Nevada");
            states.Add("NH", "New Hampshire");
            states.Add("NJ", "New Jersey");
            states.Add("NM", "New Mexico");
            states.Add("NY", "New York");
            states.Add("NC", "North Carolina");
            states.Add("ND", "North Dakota");
            states.Add("OH", "Ohio");
            states.Add("OK", "Oklahoma");
            states.Add("OR", "Oregon");
            states.Add("PA", "Pennsylvania");
            states.Add("RI", "Rhode Island");
            states.Add("SC", "South Carolina");
            states.Add("SD", "South Dakota");
            states.Add("TN", "Tennessee");
            states.Add("TX", "Texas");
            states.Add("UT", "Utah");
            states.Add("VT", "Vermont");
            states.Add("VA", "Virginia");
            states.Add("WA", "Washington");
            states.Add("WV", "West Virginia");
            states.Add("WI", "Wisconsin");
            states.Add("WY", "Wyoming");
            stateCombo.DataSource = new BindingSource(states, null);
            stateCombo.DisplayMember = "Value";
            stateCombo.ValueMember = "Key";
        }



        private void ueTxtAny_Enter(object sender, EventArgs e)
        {
            //This method will prevent the cursor from being positioned in the middle 
            //of a textbox when the user clicks in it.
            MaskedTextBox textBox = sender as MaskedTextBox;

            if (textBox != null)
            {
                this.BeginInvoke((MethodInvoker)delegate()
                {
                    int pos = textBox.SelectionStart;

                    if (pos > textBox.Text.Length)
                        pos = textBox.Text.Length;

                    textBox.Select(pos, 0);
                });
            }
        }

        private void AddressUserControl_Load(object sender, EventArgs e)
        {
            stateCombo.SelectedIndex = 36;
        }


    }





}

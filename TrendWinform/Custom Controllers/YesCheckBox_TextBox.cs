using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YesCheckBoxOption
{
    public partial class YesCheckBox_TextBox : UserControl
    {
        public YesCheckBox_TextBox()
        {
            InitializeComponent();
            txtYes.Visible = false;
        }

        
        private void chckYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chckYes.Checked == false)
            {
                txtYes.Visible = false;
            }
            else
            {
                txtYes.Visible = true;
            }
        }
    }
}

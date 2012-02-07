using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrendWinForm
{
    public partial class Othercheckbox_textbox : UserControl
    {
        public Othercheckbox_textbox()
        {
            InitializeComponent();
            Othertxt.Visible = false;
        }

        private void Otherchckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Otherchckbox.Checked == false)
            {
                Othertxt.Visible = false;
            }
            else
            {
                Othertxt.Visible = true;
            }
        }
    }
}

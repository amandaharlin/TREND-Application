using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrendCustromControls
{
    public partial class NameUserControl : UserControl
    {
        public string FirstName
        {
            get { return firstnametxt.Text; }
            set { firstnametxt.Text = value; }
        }
        public string MiddleNameorInitial
        {
            get { return middlenametxt.Text; }
            set { middlenametxt.Text = value; }
        }

        public string LastName
        {
            get { return lastnametxt.Text; }
            set { lastnametxt.Text = value; }
        }

        public NameUserControl()
        {
            InitializeComponent();
        }
    }
}

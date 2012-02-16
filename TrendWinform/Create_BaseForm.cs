using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TrendWinForm
{
    public partial class Create_BaseForm : Form
    {
        public event EventHandler OnDataAvailable;
        public Create_BaseForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                OnSave(e);
                if (OnDataAvailable != null) { OnDataAvailable(this, EventArgs.Empty); }
                this.Close();
            }
        }

        public virtual void OnSave(EventArgs e)
        {
            // Override this
        }
    }
}

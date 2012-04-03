using System;
using System.Windows.Forms;

namespace TrendWinForm
{
    public partial class Create_BaseForm : Form
    {
        public event EventHandler OnDataAvailable;

        public Create_BaseForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                OnSave(e);
                if (OnDataAvailable != null)
                {
                    OnDataAvailable(this, EventArgs.Empty);
                }
                Close();
            }
        }

        public virtual void OnSave(EventArgs e)
        {
            // Override this
        }
    }
}

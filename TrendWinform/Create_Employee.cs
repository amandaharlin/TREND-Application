using System;
using System.Windows.Forms;
using NHibernate;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;
using TrendWinForm.MyUtilities;

namespace TrendWinForm
{
    public partial class Create_Employee : Create_BaseForm
    {
        public Create_Employee()
        {
            InitializeComponent();
        }


        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            employeeBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(trendDataSet);
        }

        private void Create_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trendDataSet.Employee' table. You can move, or remove it, as needed.
            employeeTableAdapter.Fill(trendDataSet.Employee);
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
            }
            var random = new Random();
            int randomNumber = random.Next(0, 10000);

            employeeNumberTextBox.Text = randomNumber.ToString();
        }

        public override void OnSave(EventArgs e)
        {
            SaveEmployee();
        }


        private void SaveEmployee()
        {
            ISessionFactory factory = SessionConfig.SessionFactory;
            using (ISession session = factory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    PhoneNumber _number = UserContolToValueObject.ReturnPhoneNumber(phoneUserControl1);
                    Name _name = UserContolToValueObject.ReturnName(nameUserControl1);

                    var newEmployee = new Employee
                                          {
                                              EmployeeNumber = int.Parse(employeeNumberTextBox.Text),
                                              EmployeeTitle = employeeTitleTextBox.Text,
                                              EmployeePhoneNumber = _number,
                                              EmployeeName = _name
                                          };
                    session.Save(newEmployee);
                    transaction.Commit();
                }
            }
        }

        private void nameUserControl1_Load(object sender, EventArgs e)
        {
        }
    }
}

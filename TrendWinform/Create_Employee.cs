using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrendWinForm.Domain;
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
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trendDataSet);

        }

        private void Create_Employee_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'trendDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.trendDataSet.Employee);
            for (int i = 0; i < this.Controls.Count; i++)
            {

                if (this.Controls[i] is TextBox)
                {

                    this.Controls[i].Text = "";

                }

            }
            Random random = new Random();
            int randomNumber = random.Next(0, 10000);


            employeeNumberTextBox.Text = randomNumber.ToString();

        }

        public override void OnSave(EventArgs e)
        {

            SaveEmployee();
        }



        private void SaveEmployee()
        {
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    PhoneNumber _number = UserContolToValueObject.ReturnPhoneNumber(phoneUserControl1);
                    Name _name = UserContolToValueObject.ReturnName(nameUserControl1);

                    var newEmployee = new Employee()
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

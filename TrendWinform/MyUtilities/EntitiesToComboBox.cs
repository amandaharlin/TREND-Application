using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate.Linq;
using TrendWinForm.Domain.Entities;

namespace TrendWinForm.MyUtilities
{
    public class EntitiesToComboBox
    {
        public static void FillEmployeeComboBox(ComboBox target)
        {
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var employees = session.Query<Employee>().ToDictionary(v => v.Id,
                                                                           v =>
                                                                           v.EmployeeName.FirstName + " " +
                                                                           v.EmployeeName.LastName);

                    if (employees.Count > 0)
                    {

                        var sortedemployees = (from entry in employees orderby entry.Value ascending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);
                        target.DataSource = new BindingSource(sortedemployees, null);
                        target.DisplayMember = "Value";
                        target.ValueMember = "Key";
                    }
                    else
                    {
                        target.DataSource = null;
                        target.Items.Clear();
                    }

                    transaction.Commit();
                }
            }
        }

        public static void FillEmployeeComboBox(ComboBox target, bool blankValueAtTop)
        {
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var employees = session.Query<Employee>().ToDictionary(v => v.Id,
                                                                           v =>
                                                                           v.EmployeeName.FirstName + " " +
                                                                           v.EmployeeName.LastName);

                    if (employees.Count > 0)
                    {
                        if (blankValueAtTop)
                        {
                            employees[Guid.Empty] = "";
                        }
                        var sortedemployees = (from entry in employees orderby entry.Value ascending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);

                        target.DataSource = new BindingSource(sortedemployees, null);
                        target.DisplayMember = "Value";
                        target.ValueMember = "Key";
                    }
                    else
                    {
                        target.DataSource = null;
                        target.Items.Clear();
                    }

                    transaction.Commit();
                }
            }
        }

        public static void FillFirmComboBox(ComboBox target)
        {
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var firms = session.Query<Firm>().ToDictionary(x => x.Id, x => x.FirmName);

                    if (firms.Count > 0)
                    {
                        var sortedfirms = (from entry in firms orderby entry.Value ascending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);

                        target.DataSource = new BindingSource(sortedfirms, null);
                        target.DisplayMember = "Value";
                        target.ValueMember = "Key";
                    }
                    else
                    {
                        target.DataSource = null;
                        target.Items.Clear();
                    }

                    transaction.Commit();

                }
            }
        }


        public static void FillFirmComboBox(ComboBox target, bool blankValueAtTop)
        {
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var firms = session.Query<Firm>().ToDictionary(x => x.Id, x => x.FirmName);

                    if (firms.Count > 0)
                    {

                        if (blankValueAtTop)
                        {
                            firms[Guid.Empty] = "";
                        }
                        var sortedfirms = (from entry in firms orderby entry.Value ascending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);

                        target.DataSource = new BindingSource(sortedfirms, null);
                        target.DisplayMember = "Value";
                        target.ValueMember = "Key";
                    }
                    else
                    {
                        target.DataSource = null;
                        target.Items.Clear();
                    }

                    transaction.Commit();

                }
            }
        }


        public static void FillFirmContactComboBox(ComboBox target, bool blankValueAtTop)
        {
            if (blankValueAtTop == null)
            {
                blankValueAtTop = true;
            }
            else
            {
                blankValueAtTop = false;
            }

            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var firmContacts = session.Query<FirmContact>().ToDictionary(x => x.Id, x => x.Name.FirstName + " " + x.Name.LastName);

                    if (firmContacts.Count > 0)
                    {
                        if (blankValueAtTop)
                        {
                            firmContacts[Guid.Empty] = "";
                        }


                        var sortedfirmContacts = (from entry in firmContacts orderby entry.Value ascending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);

                        target.DataSource = new BindingSource(sortedfirmContacts, null);
                        target.DisplayMember = "Value";
                        target.ValueMember = "Key";
                    }
                    else
                    {
                        target.DataSource = null;
                        target.Items.Clear();
                    }
                    transaction.Commit();
                }
            }
        }

        public static void FillFirmContactComboBoxByFirm(Guid firmId, ComboBox target)
        {
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var firmContacts = session.Query<FirmContact>().Where(x => x.Firm.Id == firmId)
                        .ToDictionary(x => x.Id, x => x.Name.FirstName + " " + x.Name.LastName);

                    if (firmContacts.Count > 0)
                    {

                        var sortedfirmcontacts = (from entry in firmContacts orderby entry.Value ascending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);


                        target.DataSource = new BindingSource(sortedfirmcontacts, null);
                        target.DisplayMember = "Value";
                        target.ValueMember = "Key";
                    }
                    else
                    {
                        target.DataSource = null;
                        target.Items.Clear();
                    }
                    transaction.Commit();
                }
            }
        }

     


    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Linq;
using TrendWinForm.Domain.ValueObjects;
using TrendWinForm.Domain.Entities;
using TrendWinForm.MyUtilities;
using NHibernate.Criterion;

namespace TrendWinForm
{
    public partial class View_CaseBrowser : Form
    {


        IList<Case> casesFromDatabase;
        private ListViewColumnSorter lvwColumnSorter;
        private Guid currentlySelectedGuid = Guid.Empty;

        private int resultsPage = 1;
        private int numberOfResults = 100;

        //filters
        private string caseMatterFilterString = "";
        private string caseNumberFilterString = "";
        private string caseItemFilterString = "";

        private DateTime caseStartDateBeginFilterString = DateTime.Parse("1800-09-02 1:00:00");
        private DateTime caseStartDateEndFilterString = DateTime.MaxValue;

        private Guid caseFirmFilterGuid = Guid.Empty;
        private Guid caseRequesterFilterGuid = Guid.Empty;
        private Guid caseExaminerFilterGuid = Guid.Empty;


        public View_CaseBrowser()
        {
            InitializeComponent();

            QueryDatabaseForCases(numberOfResults, resultsPage);
            lvwColumnSorter = new ListViewColumnSorter();
            listViewListOfCases.ListViewItemSorter = lvwColumnSorter;

            //int Sort to Date.
            lvwColumnSorter.Order = SortOrder.Descending;
            lvwColumnSorter.SortColumn = 1;
            listViewListOfCases.Sort();


            //PopulateComboBoxesWithEntities();

        }

        private void View_CaseBrowser_Load(object sender, EventArgs e)
        {
            EntitiesToComboBox.FillEmployeeComboBox(examiner_idComboBox, true);
            EntitiesToComboBox.FillFirmComboBox(firm_idComboBox, true);
            EntitiesToComboBox.FillFirmContactComboBox(requester_idComboBox, true);



        }


        private void PopulateComboBoxesWithEntities()
        {


        }


        private void QueryDatabaseForCases(int numberOfCasesToTake, int pageNumber)
        {
            var factory = SessionConfig.SessionFactory;
            IList<Case> cases;
            using (var session = factory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    ICriteria caseQuery = session.CreateCriteria(typeof(Case))
                        

                        //TODO: fix Fetch Mode stuff

                        //.SetFetchMode("Computers", FetchMode.Lazy)
                        //.CreateAlias("Computers", "c")
                        //.SetFetchMode("c.WhoShutDown", FetchMode.Lazy)
                        //.SetFetchMode("c.Raids", FetchMode.Lazy)
                        //.SetFetchMode("c.HardDrives", FetchMode.Lazy)
                        //.SetFetchMode("c.CdfInfo", FetchMode.Lazy)

                        //.SetFetchMode("HardDrives", FetchMode.Lazy)
                        //.SetFetchMode("ForensicProcesses", FetchMode.Lazy)
                        //.SetFetchMode("ActiveUserFiles", FetchMode.Lazy)
                        
                        .Add(Restrictions.Between("StartDate", caseStartDateBeginFilterString, caseStartDateEndFilterString))
                        
                        .SetMaxResults(numberOfResults);

                    if (caseMatterFilterString != String.Empty)
                    {
                        caseQuery.Add(Restrictions.Like("Matter", "%" + caseMatterFilterString + "%"))
                            ;
                    }   
                    if (caseNumberFilterString != String.Empty)
                    {
                        caseQuery.Add(Expression.Sql("{alias}.CaseNumber like ?", "%" + caseNumberFilterString + "%", NHibernateUtil.String))
                            ;
                    }
                    if (caseItemFilterString != String.Empty)
                    {
                        caseQuery.Add(Expression.Sql("{alias}.ItemNumber like ?", "%" + caseItemFilterString + "%", NHibernateUtil.String))
                            ;
                    }
                    if (caseFirmFilterGuid != Guid.Empty)
                    {
                        caseQuery.Add(Restrictions.Where<Case>(x => x.Firm.Id == new Guid(firm_idComboBox.SelectedValue.ToString())))
                            ;
                    }
                    if (caseRequesterFilterGuid != Guid.Empty)
                    {
                        caseQuery.Add(Restrictions.Where<Case>(x => x.Requester.Id == new Guid(requester_idComboBox.SelectedValue.ToString())));
                    }
                    if (caseExaminerFilterGuid != Guid.Empty)
                    {
                        caseQuery.Add(Restrictions.Where<Case>(x => x.Examiner.Id == new Guid(examiner_idComboBox.SelectedValue.ToString())));
                    }

                    

                    cases = caseQuery.List<Case>();
                    transaction.Commit();
                }


                EntitiesToListView.FillCasesListViewDetailView(cases, listViewListOfCases);
                casesFromDatabase = cases;
            }

        }

        private void listViewListOfCases_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }


            listViewListOfCases.Sort();

        }

        private void buttonSearchButton_Click(object sender, EventArgs e)
        {
            caseMatterFilterString = textBoxMatterFilter.Text.ToString();
            caseStartDateEndFilterString = dateTimePickerStartDateEnd.Value;
            caseStartDateBeginFilterString = dateTimePickerStartDateBegin.Value;
            caseNumberFilterString = textBoxCaseNumber.Text;
            caseItemFilterString = textBoxItemNumber.Text;

            if (firm_idComboBox.SelectedValue.ToString() == String.Empty)
            {
                caseFirmFilterGuid = Guid.Empty;
            }
            else
            {
                caseFirmFilterGuid = new Guid(firm_idComboBox.SelectedValue.ToString());
            }

            if (requester_idComboBox.SelectedValue.ToString() == String.Empty)
            {
                caseRequesterFilterGuid = Guid.Empty;
            }
            else
            {
                caseRequesterFilterGuid = new Guid(requester_idComboBox.SelectedValue.ToString());
            }

            if (examiner_idComboBox.SelectedValue.ToString() == String.Empty)
            {
                caseExaminerFilterGuid = Guid.Empty;
            }
            else
            {
                caseExaminerFilterGuid = new Guid(examiner_idComboBox.SelectedValue.ToString());
            }


            QueryDatabaseForCases(numberOfResults, resultsPage);


        }

       

        private void listViewListOfCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewListOfCases.SelectedItems.Count == 1)
            {

                currentlySelectedGuid = new Guid(listViewListOfCases.SelectedItems[0].Tag.ToString());


            }
        }

        
        /////////////////////////////////////////////////////////////////////
        // CRUD BUTTONS
        //.......add
        private void buttonAddNewCase_Click(object sender, EventArgs e)
        {
            Create_Case createCase_childForm = new Create_Case();
            createCase_childForm.MdiParent = this.MdiParent;
            createCase_childForm.Show();
        }
        //.......view
        private void buttonViewCase_Click(object sender, EventArgs e)
        {
            if (listViewListOfCases.SelectedItems.Count == 1 && currentlySelectedGuid != Guid.Empty)
            {
                var factory = SessionConfig.SessionFactory;
                Case caseToView;
                Create_Case viewCase_childForm;
                using (var session = factory.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        caseToView = session.Query<Case>().Where(x => x.Id == currentlySelectedGuid).ToList().ElementAt(0);
                        viewCase_childForm = new Create_Case(caseToView, "view");
                        transaction.Commit();
                    }
                }

                viewCase_childForm.MdiParent = this.MdiParent;
                viewCase_childForm.Show();
            }
        }
        //.......edit
        private void buttonEditCase_Click(object sender, EventArgs e)
        {

            if (listViewListOfCases.SelectedItems.Count == 1 && currentlySelectedGuid != Guid.Empty)
            {
                var factory = SessionConfig.SessionFactory;
                Case caseToEdit;
                Create_Case editCase_childForm;
                using (var session = factory.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        caseToEdit = session.Query<Case>().Where(x => x.Id == currentlySelectedGuid).ToList().ElementAt(0);
                        editCase_childForm = new Create_Case(caseToEdit, "edit");
                        transaction.Commit();
                    }
                }

                editCase_childForm.MdiParent = this.MdiParent;
                editCase_childForm.Show();
            }
        }

        //.......delete
        private void buttonDeleteCase_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You will Remove this Case, and all its associations from the database forever.", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var factory = SessionConfig.SessionFactory;
                Case caseToDelete;
                using (var session = factory.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        caseToDelete = session.Query<Case>().Where(x => x.Id == currentlySelectedGuid).ToList().ElementAt(0);
                        session.Delete(caseToDelete);
                        transaction.Commit();
                    }
                }
            }
        }

        
    }


    public class ListViewColumnSorter : IComparer
    {
        private int ColumnToSort;
        private SortOrder OrderOfSort;
        private CaseInsensitiveComparer ObjectCompare;

        public int SortColumn
        {
            set { ColumnToSort = value; }
            get { return ColumnToSort; }
        }
        public SortOrder Order
        {
            set { OrderOfSort = value; }
            get { return OrderOfSort; }
        }

        public ListViewColumnSorter()
        {
            ColumnToSort = 0;
            OrderOfSort = SortOrder.None;
            ObjectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;
            compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
            if (OrderOfSort == SortOrder.Ascending)
            {
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending)
            {
                return (-compareResult);
            }
            else
            {
                return 0;
            }
        }



    }


}

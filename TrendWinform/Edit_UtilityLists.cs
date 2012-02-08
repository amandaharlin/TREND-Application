using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate.Linq;
using TrendWinForm.Domain.Entities;
using TrendWinForm.MyUtilities;

namespace TrendWinForm
{
    public partial class Edit_UtilityLists : Form
    {

        public string ListToEdit { get; set; }
        private List<string> ListValues { get; set; }

        public event EventHandler ListEditingComplete;

        public Edit_UtilityLists()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            textBoxListItemToAdd.Focus();
        }

        private void buttonAddItemToList_Click(object sender, EventArgs e)
        {

            AddTextTolistBox();
        }


        private void AddTextTolistBox()
        {
            if (textBoxListItemToAdd.Text.Length > 0)
            {
                if (!(ListValues.Contains(textBoxListItemToAdd.Text)))
                {
                    ListValues.Add(textBoxListItemToAdd.Text);
                }
                else
                {
                    MessageBox.Show("You already have one of those .... ");
                }

                listBoxUtilityListItems.Items.Clear();
                ListValues.Sort();
                ListValues.ForEach(x => listBoxUtilityListItems.Items.Add(x));
                labelLengthOfList.Text = ListValues.Count().ToString();
                textBoxListItemToAdd.Clear();
                labelLengthOfList.Text = ListValues.Count().ToString();
            }
        }

        private void SubtractTextFromListBox()
        {

            if (listBoxUtilityListItems.SelectedIndex != -1)
            {
                if (MessageBox.Show("Remove This? ...." + textBoxItemToDelete.Text, "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ListValues.RemoveAt(listBoxUtilityListItems.SelectedIndex);

                    ListValues.Sort();

                    listBoxUtilityListItems.Items.Clear();
                    ListValues.ForEach(x => listBoxUtilityListItems.Items.Add(x));

                    textBoxItemToDelete.Clear();

                    labelLengthOfList.Text = ListValues.Count().ToString();
                }


            }


        }


        private void buttonSubtractItemFromList_Click(object sender, EventArgs e)
        {
            SubtractTextFromListBox();
        }

        public string CleanUtilityListTitle(string incomingtitle)
        {
            return incomingtitle.Replace("_", " ");
        }


        private void Edit_UtilityLists_Shown(object sender, EventArgs e)
        {
            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {
                //var allUtilityLists = session.Query<UtilityList>().ToDictionary(d=> d.Id, d => d.UtilityListKey);
                labelCurrentList.Text = CleanUtilityListTitle(ListToEdit);
                if (ListToEdit != null)
                {
                    var selectedUtilityList = session.QueryOver<UtilityList>().Where(x => x.UtilityListKey == ListToEdit).SingleOrDefault();

                    if (selectedUtilityList == null)
                    {
                        using (var transaction = session.BeginTransaction())
                        {
                            var newUtilityList = new UtilityList()
                            {
                                UtilityListKey = ListToEdit,
                                UtilityListValues = new List<string>() { }
                            };
                            session.Save(newUtilityList);
                            transaction.Commit();
                        }
                        //must exist.
                        selectedUtilityList = session.QueryOver<UtilityList>().Where(x => x.UtilityListKey == ListToEdit).SingleOrDefault();
                    }

                    labelLengthOfList.Text = selectedUtilityList.UtilityListValues.Count().ToString();
                    selectedUtilityList.UtilityListValues.ForEach(x => listBoxUtilityListItems.Items.Add(x));
                    ListValues = selectedUtilityList.UtilityListValues.ToList();

                    ListValues.Sort();
                }
            }
        }

        private void listBoxUtilityListItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUtilityListItems.SelectedIndices.Count == 1)
            {
                textBoxItemToDelete.Text = listBoxUtilityListItems.SelectedItem.ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (textBoxListItemToAdd.Text.Length > 0)
            {
                if (MessageBox.Show("Save This? ...." + textBoxListItemToAdd.Text, "Confirm Addition", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AddTextTolistBox();
                }
            }

            var factory = SessionConfig.SessionFactory;
            using (var session = factory.OpenSession())
            {

                var selectedUtilityList = session.QueryOver<UtilityList>().Where(x => x.UtilityListKey == ListToEdit).SingleOrDefault();

                selectedUtilityList.UtilityListValues = ListValues;

                using (var transaction = session.BeginTransaction())
                {
                    session.Save(selectedUtilityList);
                    transaction.Commit();
                }
            }

            ListEditingComplete(this, EventArgs.Empty);
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}

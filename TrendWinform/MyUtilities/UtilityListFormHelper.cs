using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrendWinForm.Domain.Entities;

namespace TrendWinForm.MyUtilities
{
    public class UtilityListFormHelper
    {

        public string SummonList { set; get; }
        public ComboBox FormComboBox { set; get; }

        private Create_BaseForm CallingPage { set; get; }

        public UtilityListFormHelper()
        {
            
        }

    
        public UtilityListFormHelper(string summonList, ComboBox formCombobox, Create_BaseForm callingPage)
        {
            SummonList = summonList;
            FormComboBox = formCombobox;
            CallingPage = callingPage;
        }


        public void SummonUtilityList()
        {
            Edit_UtilityLists newEditUtilityLists = new Edit_UtilityLists();
            newEditUtilityLists.ListToEdit = SummonList;
            newEditUtilityLists.ListEditingComplete += FillComboBox;
            newEditUtilityLists.MdiParent = CallingPage.MdiParent;
            newEditUtilityLists.Show();
        }

        public  void FillComboBox(object s, EventArgs eventArgs)
        {
            PopulateComboBoxWithUtilityStrings();
        }

        public  void PopulateComboBoxWithUtilityStrings()
        {
            var factory = SessionConfig.SessionFactory;
            UtilityList utilityList;
            using (var session = factory.OpenSession())
            {
                utilityList = session.QueryOver<UtilityList>().Where(x => x.UtilityListKey == SummonList).SingleOrDefault();


                if (utilityList != null)
                {
                    List<string> comboboxValues = utilityList.UtilityListValues.Take(100000).ToList();
                    comboboxValues.Sort();
                    FormComboBox.Items.Clear();
                    comboboxValues.ForEach(x => FormComboBox.Items.Add(x));
                }

            }

   
        }


        

    }
}

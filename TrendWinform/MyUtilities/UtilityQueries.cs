using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate.Linq;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;
using TrendCustromControls;


namespace TrendWinForm.MyUtilities
{
    class UtilityQueries
    {


        public static IEnumerable<Control> GetAllControlsOfTypeFromParent(Control parent, Type type)
        {
            var controls = parent.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllControlsOfTypeFromParent(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }


        public static Dictionary<ComboBox, string> ReturnDictionaryOfComboBoxes(Form thisForm)
        {
            return GetAllControlsOfTypeFromParent(thisForm, typeof(ComboBox)).AsEnumerable().Cast<ComboBox>().ToDictionary(c => c, c => c.Text);
        }
    }
}

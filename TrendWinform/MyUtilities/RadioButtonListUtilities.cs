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
    class RadioButtonListUtilities
    {
        public static string ExtractTextFromRadioButtonGroup(GroupBox radioButtonGroupBox)
        {
            var radioButtonText = "";
            var radButtonList = radioButtonGroupBox.Controls.OfType<RadioButton>();
            radButtonList.ForEach(r =>
                                      {
                                          if (r.Checked)
                                          {
                                              radioButtonText = r.Text;
                                          }
                                          if (radioButtonText.ToUpper() == "OTHER")
                                          {
                                              radioButtonText = radioButtonGroupBox.Controls.OfType<TextBox>().ElementAt(0).Text ?? "";
                                          }
                                      });
            return radioButtonText;
        }

        public static void SelectFirstRadioInGroup(GroupBox target)
        {
            target.Controls.OfType<RadioButton>().OrderBy(x => x.TabIndex).ElementAt(0).Checked = true;
        }
    }
}

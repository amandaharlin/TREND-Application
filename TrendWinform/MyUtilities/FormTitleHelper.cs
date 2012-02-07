using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Reflection;

namespace TrendWinForm.MyUtilities
{
    class FormTitleHelper
    {

        public static void SetFormFormattingByEditMode(string formEditMode, Form target)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            System.Drawing.Icon ico;
            if (formEditMode.ToLower() == "create")
            {
                Stream myStream = myAssembly.GetManifestResourceStream("TrendWinForm.Images.formHeaderIcons.formState_Create.ico");
                ico = new System.Drawing.Icon(myStream);
                target.Text = "Create :: " + target.Text;
            }
            else if (formEditMode.ToLower() == "edit")
            {
                Stream myStream = myAssembly.GetManifestResourceStream("TrendWinForm.Images.formHeaderIcons.formState_Edit.ico");
                ico = new System.Drawing.Icon(myStream);
                target.Text = "Edit :: " + target.Text;
            }
            else if (formEditMode.ToLower() == "view")
            {
                Stream myStream = myAssembly.GetManifestResourceStream("TrendWinForm.Images.formHeaderIcons.formState_View.ico");
                ico = new System.Drawing.Icon(myStream);
                target.Text = "View :: " + target.Text;
            }
            else
            {
                Stream myStream = myAssembly.GetManifestResourceStream("TrendWinForm.Images.formHeaderIcons.formState_Contact.ico");
                ico = new System.Drawing.Icon(myStream);
            }
            target.Icon = ico;
        }


        public static void SetFormFormattingByEditMode(string formEditMode, Form target, string predicate)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            System.Drawing.Icon ico;
            if (formEditMode.ToLower() == "create")
            {
                Stream myStream = myAssembly.GetManifestResourceStream("TrendWinForm.Images.formHeaderIcons.formState_Create.ico");
                ico = new System.Drawing.Icon(myStream);
                target.Text = "Create :: " + target.Text + "[" + predicate + "]";
            }
            else if (formEditMode.ToLower() == "edit")
            {
                Stream myStream = myAssembly.GetManifestResourceStream("TrendWinForm.Images.formHeaderIcons.formState_Edit.ico");
                ico = new System.Drawing.Icon(myStream);
                target.Text = "Edit :: " + target.Text + "[" + predicate + "]";
            }
            else if (formEditMode.ToLower() == "view")
            {
                Stream myStream = myAssembly.GetManifestResourceStream("TrendWinForm.Images.formHeaderIcons.formState_View.ico");
                ico = new System.Drawing.Icon(myStream);
                target.Text = "View :: " + target.Text + "[" + predicate + "]";
            }
            else
            {
                Stream myStream = myAssembly.GetManifestResourceStream("TrendWinForm.Images.formHeaderIcons.formState_Contact.ico");
                ico = new System.Drawing.Icon(myStream);
            }
            target.Icon = ico;
        }



    }
}

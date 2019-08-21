using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp.Extensions
{
    public static class ButtonExtension
    {
        private static bool HasXPath;
        private static bool HasFile;

        public static void XPathInputChanged(this Button button,object sender, EventArgs e)
        {
            HasXPath = !String.IsNullOrWhiteSpace( ((TextBox)sender).Text );
            button.Enabled = HasXPath && HasFile;
        }

        public static void FileNameChanged(this Button button, bool isEmpty)
        {
            HasFile = isEmpty;
            button.Enabled = HasXPath && HasFile;
        }
    }
}
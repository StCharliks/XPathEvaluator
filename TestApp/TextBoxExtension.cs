using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp
{
    public static class TextBoxExtension
    {
        public static string GetText(this TextBox textBox)
        {
            return textBox.Text;
        }
    }
}
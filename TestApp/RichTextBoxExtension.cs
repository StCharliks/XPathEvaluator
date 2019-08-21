using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp
{
    public static class RichTextBoxExtension
    {
        public static void ReceiveMessage(this RichTextBox richTextBox, string message)
        {
            richTextBox.Text = message;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Extensions;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private Controllers.Controller controller;
        public Form1()
        {
            InitializeComponent();
            controller = new Controllers.Controller();

            buttonChose.Click += controller.OnChoseXMLClick;
            buttonExecute.Click += controller.OnUseXPathClick;
            controller.GetTextFunc = textBoxXPath.GetText;
            controller.OnResultEvaluated += richTextBox1.ReceiveMessage;
            controller.OnFileChosingFinish += buttonExecute.FileNameChanged;
            textBoxXPath.TextChanged += buttonExecute.XPathInputChanged;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp.Controllers
{
    class Controller
    {
        private string fileName;
        private string filter = "XML Files (*.xml)|*.xml";
        private FileSystemObserver observer;
        private XmlAnalyzer.XmlAnalyzer xmlAnalyzer;

        public delegate string GetText();
        public delegate void GetEvaluationResult(string result);
        public delegate void OnFileChosing(bool IsEmpty);
        public GetText GetTextFunc;

        public event GetEvaluationResult OnResultEvaluated;
        public event OnFileChosing OnFileChosingFinish;

        public Controller()
        {
            observer = new StandartFileSystemObserver(filter);
            xmlAnalyzer = new XmlAnalyzer.XmlAnalyzer();
        }

        public void OnChoseXMLClick(object sender, EventArgs e)
        {
            fileName = observer.ChoseFile();
            OnFileChosingFinish(!String.IsNullOrWhiteSpace(fileName));
            MessageBox.Show("Файл выбран");
        }

        public void OnUseXPathClick(object sender, EventArgs e)
        {
            string xpath = GetTextFunc();
            OnResultEvaluated(xmlAnalyzer.GetXPathResult(xpath, fileName));
        }     
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp
{
    public class StandartFileSystemObserver:FileSystemObserver
    {
        public StandartFileSystemObserver(string searchFilter)
        {
            this.searchFilter = searchFilter;
        }

        public override void ChangeFilter(string newFilter)
        {
            this.searchFilter = newFilter;
        }

        public override string ChoseFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = this.searchFilter;
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return null;
            // получаем выбранный файл
            return dialog.FileName;
        }
    }

    public abstract class FileSystemObserver
    {
        protected string searchFilter;

        public abstract string ChoseFile();

        public abstract void ChangeFilter(string newFilter);
    }
}
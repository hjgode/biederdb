using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BiederDB3
{
    public partial class FileListBox : UserControl
    {
        private string sPath = Environment.CurrentDirectory;
        public string _sPath
        {
            get { return sPath; }
            set
            {
                if (System.IO.Directory.Exists(value))
                {
                    sPath = value;
                    fillList(value);
                }
            }
        }
        private void fillList(string thePath)
        {
            listBox1.Items.Clear();
            string[] sFiles = System.IO.Directory.GetFiles(thePath);
            foreach (string s in sFiles)
                listBox1.Items.Add(System.IO.Path.GetFileName(s));
        }
        public FileListBox()
        {
            InitializeComponent();
            listBox1.Sorted = true;
            string _appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (!_appPath.EndsWith(@"\"))
                _appPath += @"\";
            sPath = _appPath;
            //fillList(sPath);
        }
    }
}

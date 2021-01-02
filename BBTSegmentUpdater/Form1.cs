using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BBTSegmentUpdater
{
    public partial class Form1 : Form
    {
        private string[] files;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            files = openFileDialog.FileNames;
            fileTextBox.Text = "";

            foreach (string file in files)
            {
                fileTextBox.Text += file + "; ";
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            List<XElement> elements = new List<XElement>();

            foreach (string file in files)
            {
                XElement element = XElement.Load(file);
                elements.Add(element);
            }

            // Any% to NLS

            // NLS to Any%
        }
    }
}

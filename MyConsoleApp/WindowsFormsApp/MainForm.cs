using Common;
using IMainFormsApp;
using Presenters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApp
{
    public partial class MainForm : Form, IMainForm
    {
        private Presenter _presenter;
        private string _pathToFile;

        public MainForm()
        {
            InitializeComponent();
            _presenter = new Presenter(this);
        }


        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            if (fileText == null)
            {                
                MessageBox.Show("Can't read file");
            }
            richTextBox1.Text = fileText;
            groupBox1.Visible = true;
            richTextBox2.Visible = true;
            _pathToFile = filename;
            MessageBox.Show("File is opened");
        }

        private void aboutMethodsButton_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<string> infoAboutSearcherList = _presenter.getInformationAboutMethods();
            List<string> namesSearcherList = _presenter.getMethodsNames();
            if (infoAboutSearcherList.Count == namesSearcherList.Count)
            {
                for (int i = 0; i < infoAboutSearcherList.Count; i++)
                {
                    stringBuilder.Append("Mentod " + namesSearcherList[i] + ":\n");
                    stringBuilder.Append(infoAboutSearcherList[i] + "\n\n");
                }

            }

            MessageBox.Show(stringBuilder.ToString());
        }

        private void findStringButton_Click(object sender, EventArgs e)
        {
            List<ISearcher> results = new List<ISearcher>();
            if (textBox1.Text != "")
            {
                StringBuilder stringBuilder = new StringBuilder();
                results = _presenter.searchString(textBox1.Text, _pathToFile);
                for (int i = 0; i < results.Count; i++)
                {
                    stringBuilder.Append("Mentod " + results[i].MethodName + " found:\n");
                    stringBuilder.Append(results[i].Result + "\n\n");
                }
                richTextBox2.Text = stringBuilder.ToString();
                
            }
            else
                MessageBox.Show("Write a word, please");

        }
    }
}

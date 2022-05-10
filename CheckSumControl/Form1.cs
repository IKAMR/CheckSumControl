using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CheckSumControl
{
    public partial class Form1 : Form
    {

        String xmlFileName;
        String destFolder;
        List<string> results = new List<string>();

        CheckSumControl control = new CheckSumControl();
        CheckWellForm wellForm = new CheckWellForm();

        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            xmlFileName = files[0];
            if (files.Count() > 1)
                MessageBox.Show("Kun en fil av gangen!");
            else
            {
                string sourceFolder = Path.GetDirectoryName(xmlFileName);
                if (String.IsNullOrEmpty(txtResultFolder.Text))
                    destFolder = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(sourceFolder).FullName).FullName).FullName, @"repository_operations\analyse");
                else
                    destFolder = txtResultFolder.Text;

                listBox1.Items.Clear();
                listBox1.Items.Add(files[0]);
                //listBox1.Items.Add(sourceFolder);
                listBox1.Items.Add(destFolder);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Dra 'arkivuttrekk.xml' hit!");
        }

        private void btnWellFormControl_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("Kontrollerer sjekksum");
            textBox1.AppendText(Environment.NewLine);

            string folder = Path.GetDirectoryName(xmlFileName);
            if (destFolder != null)
            {
                results = control.RunChecksumControl(folder, xmlFileName);

                string resultFile = Path.Combine(destFolder, "sjekksum_kontroll.txt");
                WriteToFile(resultFile, results);
            }
               // RunXPath(destFolder);
            else
            {
                textBox1.Clear();
                textBox1.AppendText("Vennligst legg til fil");
            }
        }

        public void WriteToFile(string resFileName, List<string> results)
        {
            textBox1.AppendText("Writing to file " + resFileName);
            File.WriteAllLines(resFileName, results);
        }


        private void Reset_Click(object sender, EventArgs e)
        {
            xmlFileName = null;
            listBox1.Items.Clear();
            textBox1.Clear();
        }

        private void btnWellForm_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("Kontrollerer well formedness");
            textBox1.AppendText(Environment.NewLine);

            string folder = Path.GetDirectoryName(xmlFileName);
            if (destFolder != null)
            {
                results = wellForm.RunWellFormControl(folder);

                string resultFile = Path.Combine(destFolder, "velform_kontroll.txt");
                WriteToFile(resultFile, results);
            }
            // RunXPath(destFolder);
            else
            {
                textBox1.Clear();
                textBox1.AppendText("Vennligst legg til fil");
            }
        }
    }
}

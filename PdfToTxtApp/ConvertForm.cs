using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace PdfToTxtApp
{
    public partial class ConvertFrm : Form
    {
        int numberFiles = 0, counter = 0;
        List<string> listOfFiles;
        float step = 0;
        public ConvertFrm()
        {
            InitializeComponent();
        }
        private void convert2Txt(string pathWithName)
        {

            try {

                string fileName = System.IO.Path.GetFileName(pathWithName);
                string dir = System.IO.Path.GetDirectoryName(pathWithName);
                using (PdfReader reader = new PdfReader(pathWithName))
                using (StreamWriter writer = new StreamWriter(dir + "\\" + fileName + ".txt"))
                {
                    counter++;
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        string text = PdfTextExtractor.GetTextFromPage(reader, i);
                        writer.WriteLine($"--- page {i} ---");
                        writer.WriteLine(text);
                        writer.WriteLine();
                    
                    }
                    this.Invoke((MethodInvoker)(() =>
                    {
                        numberOfConvertedFilesLbl.Text = counter.ToString();
                        if (step >= 1)
                        {
                            // if(progressBar1.Value < 100)
                            if ((progressBar1.Value + step) > 100)
                            {
                                progressBar1.Value = 100;
                                progressLbl.Text = "100%";
                            }
                            else
                            {
                                progressBar1.Value += Convert.ToInt32(Math.Round(step));
                                progressLbl.Text = progressBar1.Value + "%";
                            }
                        }
                        else
                        {
                            step += step;
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listOfFiles = new List<string>();
          
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Multiselect = true;
            ofg.Filter = "Pdf Files (*.pdf)|*.pdf";
            if (ofg.ShowDialog() == DialogResult.OK)
            {
                numberOfFileSelectedLbl.Text = ofg.FileNames.Length.ToString();
                numberFiles = ofg.FileNames.Length;
                step = 100 / numberFiles;
                foreach (var path in ofg.FileNames)
                {
                    listOfFiles.Add(path);
                    //richTextBox1.Text += path + "\r\n";
                }
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (numberFiles == 0)
            {
                MessageBox.Show("Please Select at least a file");
            }
            else
            {
                numberOfConvertedFilesLbl.Text = "0";
                counter = 0;
                convertBackgroundWorker.RunWorkerAsync();
               
            }
        }
        
        private void convertBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var item in listOfFiles)
            {
                convert2Txt(item);
            }
        }

        private void convertBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            operationResultLbl.Text = "Done";
            numberFiles = 0;
            this.Invoke((MethodInvoker)(() =>
            {
                progressBar1.Value = 100;
                progressLbl.Text = "100%";
            }));
        }
    }
}

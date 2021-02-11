using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Excel_App
{
    public partial class Form1 : Form
    {
        private List<List<string>> inputData = new List<List<string>>();
        const string SEPARATOR = "	";
        private string template = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void templateBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                template = openFileDialog1.FileName;
                templateLbl.Text = openFileDialog1.SafeFileName;

                if (template.Length > 0 && inputData.Any())
                {
                    generateBtn.Enabled = true;
                } else
                {
                    generateBtn.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputData = new List<List<string>>();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                textLbl.Text = openFileDialog1.SafeFileName;
                try
                {
                    List<string> lines = File.ReadLines(file).ToList();
                    lines.ForEach(line =>
                    {
                        inputData.Add(line.Split(SEPARATOR).ToList());
                    });

                    if (template.Length > 0 && inputData.Any())
                    {
                        generateBtn.Enabled = true;
                    }
                    else
                    {
                        generateBtn.Enabled = false;
                    }
                }
                catch (IOException)
                {
                }
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using var package = new ExcelPackage(new FileInfo(template));
            var worksheet = package.Workbook.Worksheets.FirstOrDefault();
            var collection = new List<object[]>();
            for (int i = 0; i < inputData.Count; i++)
            {
                var row = inputData[i];
                collection.Add(new object[]
                    {
                        "", // Nomer modul
                        (i + 1).ToString(), // Nomer detail
                        "", // Material
                        row[5], // Debelina
                        row[0], // ime detail
                        row[6], // broi
                        row[1], //duljina
                        row[3], // shirina
                        "", // flader
                        "", // preden
                        "", // zaden
                        "", // lqv
                        "", //desen
                        "", // panti duljina
                        "", // panti shirina
                        "", // zabelejka
                    });
            }

            worksheet.Cells[13, 1, collection.Count, 17].LoadFromArrays(collection);


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save Excel sheet";
            saveFileDialog1.Filter = "Excel files|*.xlsx|All files|*.*";
            saveFileDialog1.FileName = "ExcelSheet_" + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsm";

            //check if user clicked the save button
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the FileInfo
                FileInfo fi = new FileInfo(saveFileDialog1.FileName);
                //write the file to the disk
                package.SaveAs(fi);
            }
        }

        private void templateLbl_Click(object sender, EventArgs e)
        {

        }
    }
}

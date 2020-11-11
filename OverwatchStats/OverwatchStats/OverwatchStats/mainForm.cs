using Aspose.Cells;
using Aspose.Cells.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverwatchStats
{
    public partial class mainForm : Form
    {
        public string platform;
        public string region;
        public string id;

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int selectedPlatform = cmbPlatform.SelectedIndex;

            switch (selectedPlatform)
            {
                case 0:
                    platform = "psn";
                    break;
                case 1:
                    platform = "xbl";
                    break;
                case 2:
                    platform = "pc";
                    break;
            }

            int selectedRegion = cmbRegion.SelectedIndex;

            switch (selectedRegion)
            {
                case 0:
                    region = "us";
                    break;
                case 1:
                    region = "eu";
                    break;
                case 2:
                    region = "asia";
                    break;
            }

            id = txtID.Text;
            string url = "https://ow-api.com/v1/stats/" + platform + "/" + region + "/" + id + "/profile";
            Request(url);
        }

        async static void Request(string url)
        {
            string path = @"C:\temp\results.json";
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        using (FileStream fs = File.Create(path))
                        {
                            string statContent = "";
                            byte[] info = new UTF8Encoding(true).GetBytes(statContent = await content.ReadAsStringAsync());
                            // Add some information to the file.
                            fs.Write(info, 0, info.Length);
                        }
                        MakeExcelFile();
                    }
                }
            }
        }

        private static void MakeExcelFile()
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
            string resultPath = @"C:\temp\results.json";

            // Read JSON File
            string jsonInput = File.ReadAllText(resultPath);

            // Set JsonLayoutOptions
            JsonLayoutOptions options = new JsonLayoutOptions();
            options.ArrayAsTable = true;

            // Import JSON Data
            JsonUtility.ImportData(jsonInput, worksheet.Cells, 0, 0, options);

            // Save Excel file
            workbook.Save("stats.xlsx");
        }
    }
}

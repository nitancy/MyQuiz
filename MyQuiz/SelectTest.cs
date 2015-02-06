using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;

using EncryptString;
using XmlUtils;

namespace MyQuiz
{
    public partial class SelectTest : Form
    {
        public SelectTest()
        {
            InitializeComponent();
        }

        private void SelectTest_Load(object sender, EventArgs e)
        {
            LoadTests();
        }

        
        private void LoadTests()
        {
            string fileName = "";
            string dirPath = "..\\..\\Data\\";

            string[] listOfFiles = Directory.GetFiles(dirPath, "*.xml");

            foreach (string test in listOfFiles)
            {
                fileName = Path.GetFileNameWithoutExtension(test);  // remove the path and the extension
                cboTests.Items.Add(fileName);
            }
            cboTests.SelectedIndex = 0;     // Select the first item

            // count the number of questions
            string strQCount = GetTheQuestionCount(cboTests.SelectedItem.ToString(), 0);
            lblCount.Text = strQCount;
        }

        private string GetTheQuestionCount(string filename, int indexNo)
        {
            string path = @"..\..\Data\";

            // Get count of Questions
            var nodeCount = 0;

            using (var reader = XmlReader.Create(path + filename + ".xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element &&
                        reader.Name == "Question")
                    {
                        nodeCount++;
                    }
                }
            }
            Console.WriteLine(nodeCount);
            // return the count as a string
            return nodeCount.ToString();
        }
    }
}

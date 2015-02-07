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
                lstTests.Items.Add(fileName);
            }
            lstTests.SelectedIndex = 0;     // Select the first item

            // count the number of questions
            Console.WriteLine("lstTests.SelectedItem: " +lstTests.SelectedItem.ToString());
            Console.WriteLine("lstTests.Text: " + lstTests.Text);
            string strQCount = GetTheQuestionCount(lstTests.Text);
            lblCount.Text = strQCount;
        }
        /// <summary>
        /// GetTheQuestionCount - counts each question in each test.
        /// </summary>
        /// <param name="filename">The name of the file</param>
        /// <returns>the count as a string</returns>
        private string GetTheQuestionCount(string filename)
        {
            string path = @"..\..\Data\";

            // Get count of Questions
            var nodeCount = 0;
            Console.WriteLine(path + filename + ".xml");
            using (var reader = XmlReader.Create(path + filename + ".xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Question")
                    {
                        nodeCount++;
                    }
                }
            }
            Console.WriteLine("NodeCount: " + nodeCount);
            // return the count as a string
            return nodeCount.ToString();
        }

        private void lstTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the count and stuff it in the text box.
            lblCount.Text = GetTheQuestionCount(lstTests.Text);

            Console.WriteLine("lstTests.Text: " + lstTests.Text);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // This is how you call a non-static method, you instantiate the class
            // first into a local variable.  This is the traditional way of doing things
            Linq2Xml GetXMLQA = new Linq2Xml();
            GetXMLQA.GetQA();

            
            //numberOfQuestions = int.Parse(updTotalQuestions.Value.ToString());
            // Open new window frmAnser pass in numberOfQuestions

            this.Hide();
            var frmAnswer = new SelectTest();
            frmAnswer.Closed += (s, args) => this.Close();
            frmAnswer.Show();
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodby");
            Application.Exit();
        }

        

    }
}

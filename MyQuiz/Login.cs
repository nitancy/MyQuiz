using System;
using System.Windows.Forms;

using System.Xml;

using EncryptString;

namespace MyQuiz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SetUp_Load(object sender, EventArgs e)
        {
        }


        private string GetTheQuestionCount(string filename, int indexNo )
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

        

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please enter a user name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string password = txtPassword.Text;
                string plaintext = password;

                // Encrypt the password
                string encryptedstring = StringCipher.Encrypt(plaintext, password);
                Console.WriteLine(encryptedstring);

                // Decrypt the password
                string decryptedstring = StringCipher.Decrypt(encryptedstring, password);
                Console.WriteLine(decryptedstring);

                // Find userNamer in file
                //string result = XmlUtils.XmlSearch.searchXMLFileOriginal("..\\..\\Data\\", "Users.usr", "John");
                string result = XmlUtils.XmlSearch.searchXMLFileOriginal("..\\..\\Data\\", "booksort.xml", "admin");
                Console.WriteLine("returned value: " + result);

                this.Hide();
                var selectTest = new SelectTest();
                selectTest.Closed += (s, args) => this.Close();
                selectTest.Show();
            }

        }
        
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar; // toggle boolean
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

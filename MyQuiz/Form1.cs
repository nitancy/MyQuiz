using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;
using System.Xml;
namespace MyQuiz
{
    public partial class Form1 : Form
    {
        
        /// <summary>
        /// Select node by element name
        /// </summary>
        private void SelectNodeByElementName()
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load("..\\..\\Data\\Names.xml");
            string xmlcontents = doc.InnerXml;
            Console.WriteLine(xmlcontents);

            XmlDocument xml = new XmlDocument(); 
            string myXmlString = "..\\..\\Data\\Names.xml";   //myXmlString is the xml file in string
            myXmlString = @"C:\Temp\TestQA.xml";
            //copying xml to string: string myXmlString = xmldoc.OuterXml.ToString();
            xml.Load(myXmlString); // suppose that myXmlString contains "<Names>...</Names>"

            XmlNodeList xnList = xml.SelectNodes("/Names/Name");
            foreach (XmlNode xn in xnList)
            {
                string firstName = xn["FirstName"].InnerText;
                string lastName = xn["LastName"].InnerText;
                Console.WriteLine("Name: {0} {1}", firstName, lastName);
            }
            
        }

        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();
        
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "A";
            string b = "B";
            string c = "C";
            string d = "D";
            string f = "E";

            string strForward = a + ", " + b + ", " + c + ", " + d + ", " + f;
            string strBackwards = Reverse(strForward);
            MessageBox.Show(strForward + "\n" + strBackwards, "1 Way");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string a = "A";
            string b = "B";
            string c = "C";
            string d = "D";
            string f = "E";
            string strForward = a + ", " + b + ", " + c + ", " + d + ", " + f;

            char[] array = strForward.ToCharArray();
            Array.Reverse(array);
            MessageBox.Show(strForward + "\n" + new String(array), "Another Way");
        }

        private static string Reverse(string text)
        {
            if (text == null) return null;

            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("it started!");
            SelectNodeByElementName();
            Console.WriteLine("it ended!");
        }

    }
}

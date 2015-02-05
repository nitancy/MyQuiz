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
//using Linq2Xml;

namespace MyQuiz
{
    public partial class Sandbox : Form
    {
        public Sandbox()
        {
            InitializeComponent();
        }

        private void btnSelectNodeByAttribute_Click(object sender, EventArgs e)
        {
            string strFileName = "..\\..\\Data\\Names.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = false;
            xmlDoc.Load(strFileName); // suppose that str string contains "<Names>...</Names>"

            /* XPath expressions used here is
             * / = Selects from the root node
             * Names = name of the root node
             * / = Select from child beneath 'Names' root node 
             * [] = means ????
             * @ = attribute
             * type = name of the attribute 
             * 'M' = text/value to search for
             */
            //XmlNodeList xnList = xmlDoc.SelectNodes("/Names/Name[@type='M' | @type= 'F' ]");
            //XmlNodeList xnList = xmlDoc.SelectNodes("/Names/Name[@type='M' | /Names/Name[@type='F' ]");
            //XmlNodeList xnList = xmlDoc.SelectNodes("/Names/Name[@type='M'] || /Names/Name[@type='M']");
            XmlNodeList xnList = xmlDoc.SelectNodes("/Names/Name[@type='M']");
            //string strXPath = "/Names/Name[@type='M'] or /Names/Name[@type='F']";
            //XmlNodeList xnList = xmlDoc.SelectNodes(strXPath);
            

            Console.Clear();
            Console.WriteLine("Console CLS");

            foreach (XmlNode xn in xnList)
            {
                Console.WriteLine(xn.InnerText);
            }
        }

        private void btnSortByAttribute_Click(object sender, EventArgs e)
        {
            //How to sort by Attribute (using LINQ to XML in XDocument)
            /*
            <Users>
                <User Name="Z"/>
                <User Name="D"/>
                <User Name="A"/>
            </User>
             * 
             * <Names>
              <Name type="M">
                <FirstName>John</FirstName>
                <LastName>Miller</LastName>
              </Name>
            */

            string strFileName = "..\\..\\Data\\Names.xml";
            XDocument input = XDocument.Load(strFileName, LoadOptions.PreserveWhitespace);

            Console.Clear();
            Console.WriteLine("Console CLS");

            XDocument output = new XDocument(
                new XElement("Names",
                    from node in input.Root.Elements()
                    orderby node.Attribute("type").Value ascending
                    select node));
            Console.WriteLine(output.ToString());
        }

        private void btnSortByChildDESC_Click(object sender, EventArgs e)
        {
            string strFileName = "..\\..\\Data\\Teams.xml";
            XDocument Doc = new XDocument();
            Doc = XDocument.Load(strFileName);

          //var results = Doc.Root.Descendants("Team").OrderByDescending(p => p.Element("LastAccessed"));
            var results = Doc.Descendants("Team").OrderByDescending(p => DateTime.Parse(p.Element("LastAccessed").Value));

            Console.Clear();
            Console.WriteLine("Console CLS");
            XDocument node = new XDocument(Doc.Descendants("KS").OrderByDescending(x => x.Element("Team").Element("LastAccessed").Value.Trim()));
            Console.WriteLine(node.ToString());
        }

        private void btnbtnSelectNodeByAttributeF_Click(object sender, EventArgs e)
        {
            string strFileName = "..\\..\\Data\\Names.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = false;
            xmlDoc.Load(strFileName); // suppose that str string contains "<Names>...</Names>"

            string strSelector = "?";
            XmlNodeList xnList = xmlDoc.SelectNodes("/Names/Name[@type='" + strSelector + "']");

            Console.Clear();
            Console.WriteLine("Console CLS");

            foreach (XmlNode xn in xnList)
            {
                Console.WriteLine(xn.InnerText);
            }
            
        }

        private void btnWriteXMLtoFile_Click(object sender, EventArgs e)
        {
            writeToXML();
        }

        public void writeToXML()
        {
            // Method to write lines to XML file 
            string fileName = "Teams.xml";
            string filePath = "..\\..\\Data\\";

            string FILE_PATH = filePath + fileName;

            XDocument xDoc = XDocument.Load(FILE_PATH);

          //<Team>
          //  <TeamName>Dodgers</TeamName>
          //  <TeamColor>blue</TeamColor>
          //  <LastAccessed>5/9/2013 4:44:44 PM</LastAccessed>
          //</Team>

            //Linq2Xml GMD = new Linq2Xml();
            //string strDateTimeNow = GMD.GetModDate();
            string strDateTimeNow = DateTime.Now.ToString();

            xDoc.Root.Add(new XElement("Team"));
            xDoc.Root.Add(new XElement("TeamName", "Cardinals"));
            xDoc.Root.Add(new XElement("TeamColor", "Red"));
            xDoc.Root.Add(new XElement("LastAccessed", strDateTimeNow));
            xDoc.Save(FILE_PATH);

            xDoc.Root.Add(new XElement("Team",
            new XElement("TeamName", "Cardinals"),
            new XElement("TeamColor", "Red"),
            new XElement("LastAccessed", strDateTimeNow))            
            );
            xDoc.Save(FILE_PATH);
        }
    }
}

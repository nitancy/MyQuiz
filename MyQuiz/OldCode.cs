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
using System.Xml.XPath;

namespace MyQuiz
{
    class GetSetXML
    {

        public class XML_Load
        {

            public void FindChildElement()
            {
                string theDate, thePONumber;
                XDocument POs = XDocument.Load("..\\..\\PurchaseOrders.xml");
                XElement po = POs.Root.Element("PurchaseOrder");
                theDate = POs.Root.Element("PurchaseOrder").Attribute("OrderDate").Value;
                thePONumber = POs.Root.Element("PurchaseOrder").Attribute("PurchaseOrderNumber").Value;
                Console.WriteLine("theDate: \t" + theDate);
                Console.WriteLine("thePONumber: \t" + thePONumber);

                // LINQ to XML query
                XElement el1 = po.Element("PurchaseOrder");             //DeliveryNotes

                // XPath expression
                XElement el2 = po.XPathSelectElement("PurchaseOrder");  //DeliveryNotes
                // same as "child::DeliveryNotes"
                // same as "./DeliveryNotes"

                if (el1 == el2)
                    Console.WriteLine("Results are identical");
                else
                    Console.WriteLine("Results differ");
                Console.WriteLine(el1);
            }
 
        }
    }
}

//class QandAs
//{
//    string _QuestionID;
//    string _Answer1;
//    string _Answer2;
//    string _Answer3;
//    string _Answer4;
//    string _Correct;

    // Constructor
    //public QandAs(string QuestionID, string Answer1,string Answer2,string Answer3, string Answer4, string Correct)
    //{
    //    this._QuestionID = _QuestionID;
    //    this._Answer1 = _Answer1;
    //    this._Answer2 = _Answer2;
    //    this._Answer3 = _Answer3;
    //    this._Answer4 = _Answer4;
    //    this._Correct = _Correct;
    //}
//}

//                //public int QuestionID { get; set; }
//                //public string Question { get; set; }
//                //public string Answer1 { get; set; }
//                //public string Answer2 { get; set; }
//                //public string Answer3 { get; set; }
//                //public string Answer4 { get; set; }
//                //public string Correct { get; set; }
//    }

//            //var QAList = new List<QandAs>();

//            //QAList.Add( new QandAs) {
//            //    QuestionID = 0,
//            //    Answer1 = "Answer1 text"),
//            //    Answer2 = "Answer2 text"),
//            //    Answer3 = "Answer3 text"),
//            //    Answer4 = "Answer4 text"),
//            //    txtCorrect = "Z"
//            //});

//            // Initilize the new class as usual
//            DisplayXMLData dxd = new DisplayXMLData();
//            // Pass in, with whatever logic you 
//            // want to use, all of the form objects
//            // that you need.
//            dxd.NewShowQA(radioButtons, textBoxes);


        //#region CaptureTheResponse
        //private void rdoAnswer1_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtCorrect.Text = "A";
        //}

        //private void rdoAnswer2_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtCorrect.Text = "B";
        //}

        //private void rdoAnswer3_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtCorrect.Text = "C";
        //}

        //private void rdoAnswer4_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtCorrect.Text = "D";
        //}
        //#endregion

/*
* From http://csharpadvance.blogspot.com/2012/12/c-xml-document-xpath-query.html 
 */

//How to select node by element name
/*
<Names>
    <Name type="M">
        <FirstName>John</FirstName>
        <LastName>Miller</LastName>
    </Name>
    <Name type="F">
        <FirstName>Sue</FirstName>
        <LastName>Miller</LastName>
    </Name>
    <Name type="M">
        <FirstName>James</FirstName>
        <LastName>Miller</LastName>
    </Name>
</Names>
 * */

/*
XmlDocument xml = new XmlDocument();
xml.LoadXml(myXmlString); // suppose that myXmlString contains "<Names>...</Names>"

XmlNodeList xnList = xml.SelectNodes("/Names/Name");
foreach (XmlNode xn in xnList)
{
  string firstName = xn["FirstName"].InnerText;
  string lastName = xn["LastName"].InnerText;
  Console.WriteLine("Name: {0} {1}", firstName, lastName);
}
 * */


// How to select a node by attribute
/*
<Names>
    <Name type="M">John</Name>
    <Name type="F">Susan</Name>
    <Name type="M">David</Name>
</Names>
*/
/*
XmlDocument xml = new XmlDocument();
xml.LoadXml(str);  // suppose that str string contains "<Names>...</Names>"

XmlNodeList xnList = xml.SelectNodes("/Names/Name[@type='M']");
foreach (XmlNode xn in xnList)
{
  Console.WriteLine(xn.InnerText);
}
*/

//How to sort by Attribute (using LINQ to XML in XDocument)
/*
<Users>
    <User Name="Z"/>
    <User Name="D"/>
    <User Name="A"/>
</User>
*/
/*
XDocument input = XDocument.Load(@"input.xml");
XDocument output = new XDocument(
    new XElement("Users",
        from node in input.Root.Elements()
        orderby node.Attribute("Name").Value descending
        select node));
*/

//<KS>
//  <Team>   
//    <TeamName>Knights</TeamName>
//    <TeamColor>blue</TeamColor>
//    <LastAccessed>5/9/2013 2:34:22 PM</LastAccessed>
//  </Team>
//  <Team>
//    <TeamName>Rangers</TeamName>
//    <TeamColor>red</TeamColor>
//    <LastAccessed>5/9/2013 3:49:06 PM</LastAccessed>
//  </Team>
//  <Team>
//    <TeamName>Eagles</TeamName>
//    <TeamColor>green</TeamColor>    
//    <LastAccessed>5/9/2013 3:50:18 PM</LastAccessed>
//  </Team>
//</KS>
//var results = Doc.Descendants("Team").OrderByDescending(p => DateTime.Parse(p.Element("LastAccessed").Value));


//Console.WriteLine("Please enter a password to use:");
//string password = Console.ReadLine();
//Console.WriteLine("Please enter a string to encrypt:");
//string plaintext = Console.ReadLine();
//Console.WriteLine("");

//Console.WriteLine("Your encrypted string is:");
//string encryptedstring = StringCipher.Encrypt(plaintext, password);
//Console.WriteLine(encryptedstring);
//Console.WriteLine("");

//Console.WriteLine("Your decrypted string is:");
//string decryptedstring = StringCipher.Decrypt(encryptedstring, password);
//Console.WriteLine(decryptedstring);
//Console.WriteLine("");

//Console.ReadLine();

// Use this event handler for the FormClosing event.
//private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
//{
//   this.Hide();
//   e.Cancel = true; // this cancels the close event.
//}
// or this one which forces the form to be hidden
//private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
//{
//    if (e.CloseReason != CloseReason.UserClosing) return;
//    e.Cancel = true;
//    Hide();
//}
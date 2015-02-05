using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Linq;

namespace MyQuiz
{
    class Linq2Xml
    {
        public void GetSpecificElementWithSpecificAttribute()
        {
            // Quiz, QA, Question/Answer1-4/Correct
            //XElement xelement = XElement.Load("..\\..\\Data\\TestQA.xml");
            //var QNo = from theNo in xelement.Elements("QA")
            //          where (string)QA.Element("Question").Attribute("Number") == "1"
            //                select Question;
            //Console.WriteLine("List Question and Answers.");
            //foreach (XElement xEle in QA)
            //{
            //    Console.WriteLine(xEle.Element("Phone").Value);
            //}
        }

        public string GetModDate()
        {
            string theDate;
                
            
            DateTime now = DateTime.Now;        // Get DateTime now
            string format = "MMM-dd-yyyy";      // This format yeilds a date like 'Feb-01-2015'
            theDate = now.ToString(format);

            return theDate;
        }

        public void GetQA()
        {
            string theNo, theDate;
            //string theQuestion;
            XDocument Quiz = XDocument.Load("..\\..\\Data\\TestQA.xml");
            XElement quiz = Quiz.Root.Element("QA");
            theDate = Quiz.Root.Element("ModDate").Value;

            Quiz.Descendants().Where(p => p.Name.LocalName == "Question");

            theNo = Quiz.ToString();            //("Question").Attribute("Nmbr").Value;
//            theQuestion = Quiz.Root.Element("Question").Value;
            //Console.WriteLine("theNo: \t" + theNo);
            //Console.WriteLine("thePONumber: \t" + theQuestion);

            
        }
    }
}

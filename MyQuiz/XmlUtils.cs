using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml;

namespace XmlUtils

{
    public static class XmlSearch
    {
        public static string searchXMLFile(string path, string filename, string queryString)
        {
            XmlDocument doc = new XmlDocument();
            Console.WriteLine(path + filename);
            doc.PreserveWhitespace = true;
            doc.Load(path + filename);

            //Create an XmlNamespaceManager for resolving namespaces.
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("bk", "urn:samples");

            //Select the book node with the matching attribute value.
            XmlNode User;
            XmlElement root = doc.DocumentElement;
            User = root.SelectSingleNode("descendant::User[@bk:role='Admin']", nsmgr);

            Console.WriteLine(User.OuterXml);

            return User.OuterXml;
        }

        public static string searchXMLFileOriginal(string path, string filename, string queryString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path + filename);

            //Create an XmlNamespaceManager for resolving namespaces.
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("bk", "urn:samples");

            //Select the book node with the matching attribute value.
            XmlNode book;
            XmlElement root = doc.DocumentElement;
            book = root.SelectSingleNode("descendant::book[@bk:role='admin']", nsmgr);
            string personName = book.FirstChild.InnerText;
            Console.WriteLine("First child: " + book.FirstChild.InnerText);

            return personName;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyQuiz
{
    class DisplayXMLData
    {
        public void NewShowQA(List<RadioButton> radioButtons, List<TextBox> textBoxes)
        {
            // So here is where you get a list of
            // the text boxes/radio buttons from
            // the form based upon what you pass
            // into the form.

            // You would create any logic/param/
            // whatever you wanted to support this
            // method.

            // That's probably a new trick ;)
            textBoxes.ForEach(m =>
                m.Text += "I added this text to each textbox"
            );

            string url = @"C:\Temp\TestQA.xml";
            XmlReader reader = new XmlTextReader(url);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "Question":
                            textBoxes[0].Text = reader.ReadElementContentAsString();
                            break;
                        case "Answer1":
                            radioButtons[0].Text = reader.ReadElementContentAsString();
                            break;
                        case "Answer2":
                            radioButtons[1].Text = reader.ReadElementContentAsString();
                            break;
                        case "Answer3":
                            radioButtons[2].Text = reader.ReadElementContentAsString();
                            break;
                        case "Answer4":
                            radioButtons[3].Text = reader.ReadElementContentAsString();
                            break;
                        case "Correct":
                            textBoxes[1].Text = reader.ReadElementContentAsString();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public void GetQAs(List<RadioButton> radioButtons, List<TextBox> textBoxes)
        {
            // So here is where you get a list of
            // the text boxes/radio buttons from
            // the form based upon what you pass
            // into the form.

            // You would create any logic/param/
            // whatever you wanted to support this
            // method.

            // That's probably a new trick ;)
            textBoxes.ForEach(m =>
                m.Text += "I added this text to each textbox"
            );

            string url = @"C:\Temp\TestQA.xml";
            XmlReader reader = new XmlTextReader(url);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "Question":
                            textBoxes[0].Text = reader.ReadElementContentAsString();
                            break;
                        case "Answer1":
                            radioButtons[0].Text = reader.ReadElementContentAsString();
                            break;
                        case "Answer2":
                            radioButtons[1].Text = reader.ReadElementContentAsString();
                            break;
                        case "Answer3":
                            radioButtons[2].Text = reader.ReadElementContentAsString();
                            break;
                        case "Answer4":
                            radioButtons[3].Text = reader.ReadElementContentAsString();
                            break;
                        case "Correct":
                            textBoxes[1].Text = reader.ReadElementContentAsString();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}

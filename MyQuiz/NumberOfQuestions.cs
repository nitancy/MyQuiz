using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQuiz
{
    public partial class NumberOfQuestions : Form
    {
        public NumberOfQuestions()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // This is how you call a non-static method, you instantiate the class
            // first into a local variable.  This is the traditional way of doing things
            Linq2Xml GetXMLQA = new Linq2Xml();
            GetXMLQA.GetQA();
            
            QuestionAnswer frmAnswer = new QuestionAnswer();
            int numberOfQuestions = int.Parse(updTotalQuestions.Value.ToString());
            // Open new window frmAnser pass in numberOfQuestions

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

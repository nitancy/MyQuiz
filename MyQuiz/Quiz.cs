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
    public partial class DisplayQA : Form
    {
        public DisplayQA()
        {
            InitializeComponent();
            // To prevent the text from being selected when the textbox
            // control gets focus select 0 length characters from the 0th (beginning) position
            txtQuestion.GotFocus += delegate { txtQuestion.Select(0, 0); };
        }

        private void DisplayQA_Load(object sender, EventArgs e)
        {
            // Here you have access to all of the
            // form elements, as they are within
            // the scope of this class.
            List<RadioButton> radioButtons = new List<RadioButton>();
            radioButtons.Add(rdoAnswer1);
            radioButtons.Add(rdoAnswer2);
            radioButtons.Add(rdoAnswer3);
            radioButtons.Add(rdoAnswer4);


            List<TextBox> textBoxes = new List<TextBox>();
            // Add those when you have them...
            textBoxes.Add(txtQuestion);
            textBoxes.Add(txtCorrect);

        }
        

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((rdoAnswer1.Checked == true) && (txtCorrect.Text == "A"))
                MessageBox.Show("That is the right answer.", "Correct" );            
        }

        private void rdoAnswer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoAnswer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoAnswer3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoAnswer4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

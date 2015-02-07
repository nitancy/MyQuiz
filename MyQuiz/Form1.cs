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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public void Form1_Load()
        {
            if (!this.Focused)
                this.Focus();
        }

        private void btnPassData_Click(object sender, EventArgs e)
        {
            // On click, the second form will appear and this form will be made to hide

            // Take the value from the textbox
            // Now send the string to the second form.
            Form2 frm2 = new Form2(txtDataToPass.Text, "Renamed Title for Form2");
            frm2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //creating form2 object 
            Form2 f2 = new Form2();
            this.Hide();

            //opening second form 
            _ = f2.ShowDialog();

            Close();



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //message box asking user if they are sure they want to exit
            DialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 

            //if they answer yes on the message box, the application closes
            if(DialogResult==DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();

            Close(); 
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();

            Close(); 
        }
    }
}

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
    public partial class Form3 : Form
    {
        //declaring a list for the english colours
        static List<string> englishList = new List<string>() { "red", "orange", "yellow", "green", "blue", "purple", "brown", "black", "grey", "white", "indigo", "pink", "light blue", "dark blue", "deep blue" };

        //declaring a list for the german colours
        static List<string> germanList = new List<string>() { "rot", "orange", "gelb", "grün", "blau", "purpurn", "braue", "schwarz", "grau", "weis", "indigofarben", "rosa", "hellblau", "dunkelblau", "tiefblau" };

        //declaring a random variable to select random colour from the english list
        static Random rand = new Random();

        //a string colour to store a random colour from the list in to
        static string colour = "";

        //int variable to keep track of the points being tallied throughout the game
        static int points = 0;

        //int variable to set the amount of questions that the user wants to be asked
        static int size; 

        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //validation to ensure that a number is entered into the textbox
            if (!int.TryParse(textBox2.Text, out size))
            {
                MessageBox.Show("You must enter a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox2.Focus();
            }

            else
            {


                //for loop to store random colours into the colour variable using the size entered as a parameter
                for(int count=0; count <size; count++)
                {
                    //storing random english colours into the variable
                    colour = englishList[rand.Next(size)];

                }

                //selection statements to find and output the colour of the label 

                if (colour.Equals("red"))
                {
                    label3.BackColor = Color.Red;

                }

                else if (colour.Equals("orange"))
                {
                    label3.BackColor = Color.Orange;

                }

                else if (colour.Equals("yellow"))
                {
                    label3.BackColor = Color.Yellow;

                }

                else if (colour.Equals("green"))
                {
                    label3.BackColor = Color.Green;


                }

                else if (colour.Equals("blue"))
                {
                    label3.BackColor = Color.Blue;

                }

                else if (colour.Equals("purple"))
                {
                    label3.BackColor = Color.Purple;

                }

                else if (colour.Equals("brown"))
                {
                    label3.BackColor = Color.Brown;

                }

                else if (colour.Equals("brown"))
                {
                    label3.BackColor = Color.Brown;

                }

                else if (colour.Equals("black"))
                {
                    label3.BackColor = Color.Black;

                }

                else if (colour.Equals("grey"))
                {
                    label3.BackColor = Color.Gray;


                }

                else if (colour.Equals("white"))
                {
                    label3.BackColor = Color.White;

                }

                else if (colour.Equals("indigo"))
                {

                    label3.BackColor = Color.Indigo;

                }

                else if (colour.Equals("pink"))
                {
                    label3.BackColor = Color.Pink;

                }

                else if (colour.Equals("light blue"))
                {
                    label3.BackColor = Color.LightBlue;

                }

                else if (colour.Equals("dark blue"))
                {
                    label3.BackColor = Color.DarkBlue;


                }

                else if (colour.Equals("deep blue"))
                {
                    label3.BackColor = Color.DeepSkyBlue;

                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //declaring answer variable and setting it = to textbox input
            string answer = textBox1.Text.ToLower();

            //validation to ensure that the user doesnt leave the textbox empty
            if (answer.Equals(""))
            {
                MessageBox.Show("You must submit an answer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                //start of loop statement to determine if answer is correct
                for (int count = 0; count < size; count++)

                {
                    //if colour is equal to english list position 0 to 15 and answer = spanish list at the same index, answer is correct
                    if (colour == englishList[count] && answer == germanList[count])
                    {
                        //output message
                        MessageBox.Show("Correct!", "Correct");

                        //awarded points for correct answer
                        points = points + 10;

                        //calling method to clear and focus textbox
                        clear();
                    }

                    //if the answer is not correct
                    else if (colour == englishList[count] && answer != germanList[count])
                    {
                        //output incorrect and the answer will be given to them
                        MessageBox.Show("Incorrect!", "Incorrect");


                        //calling out method to clear and focus textbox 1
                        clear();
                    }
                }
            }
        }

        //method to clear and focus the textbox1. This saves a couple lines of code from being repeated
        private void clear()
        {
            textBox1.Clear();
            textBox1.Focus(); 
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //message box asking the user are they sure they want to exit
            DialogResult exit = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 

            //if they answer yes, end the program
            if(exit==DialogResult.Yes)
            {
                MessageBox.Show("Points: " + points);
                Application.Exit();
            }
        }

        //method to get the answer if the pass button is clicked
        private void Button4_Click(object sender, EventArgs e)
        {
            for (int count = 0; count < size; count++)

            {
                //if colour is equal to english list position 0 to 15 and answer = spanish list at the same index, answer is correct
                if (colour == englishList[count])
                {
                    MessageBox.Show("Answer: " + germanList[count]);
                }

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //for loop to find the first letter of the answer
            for (int count = 0; count < size; count++)

            {
                if (colour == englishList[count])
                {
                    //finding and outputting the first letter in a messagebox using substrings
                    MessageBox.Show("First Letter: " + germanList[count].Substring(0, 1));

                    
                }


            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.Focus(); 
        }
    }
}

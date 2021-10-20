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
    public partial class Form2 : Form
    {
        //english list containing all the different colours in english
        static List<string> englishList = new List<string>() { "red", "orange", "yellow", "green", "blue", "purple", "brown", "black", "grey", "white", "indigo", "pink", "light blue", "dark blue", "deep blue" };

        //spanish list containing all the different colours in spanish
        static List<string> spanishList = new List<string>() { "rojo", "naranja", "amarillo", "verde", "azul", "púrpura", "marrón", "negro", "gris", "blanco", "índigo", "rosa", "azul claro", "azul oscuro", "azul intenso" };

        //creating a random object so that i can randomly select colours
        Random rand = new Random();

        //declaring a static point variable to it can be used in the two methods
        static int points = 0;

        //declaring a static string variable to store random colours from the list into it
        static string colour = "";

        static int size; 

        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //validation to ensure that the user types in a number
            if (!int.TryParse(textBox2.Text, out size))
            {
                //output if they havent entered a number
                MessageBox.Show("You Must enter a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox2.Focus();
            }

            else
            {

                //for loop using the size as a parameter to store random colours in the variable
               for (int count =0; count <size; count ++)
                {
                    //storing random english colours into the variable
                    colour = englishList[rand.Next(size)];

                }

                //selection statements to find and output the colour of the label -- could improve this by adding a third list

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
                    if (colour == englishList[count] && answer == spanishList[count])
                    {
                        //output message
                        MessageBox.Show("Correct!", "Correct");

                        //awarded points for correct answer
                        points = points + 10;

                        //calling method to clear and focus textbox
                        clear();
                    }

                    //if the answer is not correct
                    else if (colour == englishList[count] && answer != spanishList[count])
                    {
                        //output incorrect and the answer will be given to them
                        MessageBox.Show("Incorrect!", "Incorrect");


                        //calling out method to clear and focus textbox 1
                        clear();
                    }
                }
            }


        }

        //method to clear and focus textbox -- saves having to type it in everytime i want it cleared
        private void clear()
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.Focus(); 

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //if the exit button is clicked the user will be prompted "are you sure?"
            DialogResult exit = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if statement so that if they hit "yes", their points are shown then the application closes
            if (exit == DialogResult.Yes)
            {
                
                MessageBox.Show("Points: " + points);
                Application.Exit();
            }

            


            

        }

        //method to output the correct answer if the pass button is clicked
        private void Button4_Click(object sender, EventArgs e)
        {
            for (int count = 0; count < size; count++)

            {
                //if colour is equal to english list position 0 to 15 and answer = spanish list at the same index, answer is correct
                if (colour == englishList[count])
                {
                    MessageBox.Show("Answer: " + spanishList[count]); 
                }

            }
        }


        //method for getting the hint. 
        private void Button5_Click(object sender, EventArgs e)
        {
            for (int count = 0; count < size; count++)

            {
                //if englishlist and spanish list is at the same postion, output the first letter of the spanish word
                if (colour==englishList[count])
                {
                    MessageBox.Show("First Letter: " + spanishList[count].Substring(0, 1));

                    points = points - 5; 
                }
                

            }
        }
    }
}

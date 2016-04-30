// Author: Jonathan Spalding
// Assignment: Project 8
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 3/26/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        // create a DiceClass object
        DiceClass objectRef;
        public Form1()
        {
            InitializeComponent();
            objectRef = new DiceClass();
        }
        // The aboutToolStripMenuItem_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Spalding\nCS1400\nProject 08");
        }
        // The exitToolStripMenuItem1_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
        // The rollEm_Click method
        // Purpose: checks the combo box to see if what method was chosen, then assigns that method in the SetMethod method.
        // Parameters: The sending object, and the event arguments
        // returns: none
        private void rollEm_Click(object sender, EventArgs e)
        {
            //Set the specialMessage to blank.
            specialMessage.Text = "";
            // Call Your Class
            objectRef.RollEm();
            // Set values for first and second dice that will be displayed as the string.
            string firstDie = "";
            string secondDie = "";
            // call back the results of the first and second die strings.
            objectRef.GetResult(ref firstDie, ref secondDie);
            // get the result of the first and second die integers
            die1.Text = firstDie;
            die2.Text = secondDie;
            // if statement for box cars
            if (objectRef.BoxCars())
            {
                specialMessage.Text = "BOX CARS!!!";
            }
            //else for snake eyes. 
            else
            {
                if (!objectRef.SnakeEyes())
                    return;
                specialMessage.Text = "SNAKE EYES!!!";
            }
        }
    }
}

// Author: Jonathan Spalding
// Assignment: Project 08
// Instructor Roger deBry
// Clas: CS 1400
// Date Written: 3/5/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class DiceClass
    {
        // create strings for what the dice will look like
        private static string nL = Environment.NewLine;
        string one = nL + " l ";
        string two = "l" + nL + nL + "  l";
        string three = "l l" + nL + nL + "l l";
        string four = "l l" + nL + nL + "l l";
        string five = "l l" + nL + " l " + nL + "l l";
        string six = "l l" + nL + "l l" + nL + "l l";
        // state constants because I can't have magic numbers. And I can't name my magic numbers "ONE = 1"
        const int SNAKE = 1;
        const int ONELESSTHANTHREE = 2;
        const int TWOLESSTHANFIVE = 3;
        const int ONEGREATERTHANTHREE = 4;
        const int BETWEENFOURANDSIX = 5;
        const int BOX = 6;
        const int MAX = 7;
        // State the data members of the class.
        private int firstDie;
        private int secondDie;
        // create random number generator
        Random randomNums = new Random();
        // The default constructor
        // Purpose: It sets all declared variables (data members of the class) to what they need to be.
        // Parameters: None
        // Returns: None
        public DiceClass()
        {
            firstDie = 0;
            secondDie = 0;
        }
        // The RollEm method
        // Purpose: Gets the random number for each die from the randomNums generator, and assigns a variable to them.
        // Parameters: None
        // Returns: none
        public void RollEm()
        {
            firstDie = randomNums.Next(SNAKE, MAX);
            secondDie = randomNums.Next(SNAKE, MAX);
        }
        // The BoxCars method
        // Purpose: Finds out if the result was BoxCars.
        // Parameters: None
        // Returns: firstDie && secondDie
        public bool BoxCars()
        {
            return firstDie == BOX && secondDie == BOX;
        }
        // The SnakeEyes method
        // Purpose: Finds out if the result was snakeEyes.
        // Parameters: None
        // Returns: firstDie && secondDie
        public bool SnakeEyes()
        {
            return firstDie == SNAKE && secondDie == SNAKE;
        }
        // The SnakeEyes method
        // Purpose: assigns the string first and second to the correct string depending on the result of randomNums.
        // Parameters: ref string first, ref string second
        // Returns: none
        public void GetResult(ref string first, ref string second)
        {
            //if else statements to find what was rolled in the randomNums, and assign the correct corresponding string.
            if (firstDie == SNAKE)
                first = one;
            else if (firstDie == ONELESSTHANTHREE)
                first = two;
            else if (firstDie == TWOLESSTHANFIVE)
                first = three;
            else if (firstDie == ONEGREATERTHANTHREE)
                first = four;
            else if (firstDie == BETWEENFOURANDSIX)
                first = five;
            else if (firstDie == BOX)
                first = six;
            //if else statements again for second die.
            if (secondDie == SNAKE)
                second = one;
            else if (secondDie == ONELESSTHANTHREE)
                second = two;
            else if (secondDie == TWOLESSTHANFIVE)
                second = three;
            else if (secondDie == ONEGREATERTHANTHREE)
                second = four;
            else if (secondDie == BETWEENFOURANDSIX)
                second = five;
            else if (secondDie == BOX)
                second = six;
        }
    }
}

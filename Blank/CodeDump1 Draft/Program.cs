﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDump1_Draft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, Player! Press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Please enter your first name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("Welcome " + playerName + "!");
            Console.ReadLine();

            if (playerName == "Jarrett")
                {
                //TO BE CONTINUED
                }

            Console.WriteLine("Please enter your age.");
            bool userTF1;
            int playerAge;
            string userInput = Console.ReadLine();
            userTF1 = int.TryParse(userInput, out playerAge);


            if (playerAge > 18)
            {
                Console.WriteLine("Thank you for your submission. You are " + playerAge + " years old!. It seems you are old enough to play this game.");
                Console.ReadLine();
                Console.WriteLine("You have passed the first test! Now then, time for question number two!");
            }

            else
            {
                Console.WriteLine("Thank you for your submission. You are " + playerAge + " years old!. It seems you are not yet old enough to play this game.");
                Console.ReadLine();
                Console.WriteLine("My teacher is definitely over 18 years old, so I don't know how you got your hands on this program! Consider the identity test failed!");
                Console.ReadLine();
                Console.WriteLine("Goodbye.");
                Console.ReadLine();

            }

            Console.WriteLine("What is a boolean variable?");
            Console.ReadLine();

            //CREATE ARRAY HERE 


            string optionA = "1.) A type of bowling ball with a varying number of finger holes in it.";
            string optionB = "2.) The hip, new way to boil soup.";
            string optionC = "3.) A data type that can only be stored in one of two states, 'true' or 'false'.";
            Console.WriteLine(optionA);
            Console.WriteLine(optionB);
            Console.WriteLine(optionC);
            Console.WriteLine(" ");
            Console.WriteLine("Please enter '1', '2', or '3'!");
            bool userTF2;
            int playerAnswer1;
            string userInput2 = Console.ReadLine();
            userTF2 = int.TryParse(userInput2, out playerAnswer1);

            int[] mcAnswers1 = new int[4];

            mcAnswers1[0] = 0;
            mcAnswers1[1] = playerAnswer1;
            mcAnswers1[2] = playerAnswer1;
            mcAnswers1[3] = playerAnswer1;

            if (playerAnswer1 == 3)
            {
                Console.WriteLine("You have chosen '" + optionC + "'!");
                Console.WriteLine("That is correct!");
                Console.ReadLine();
                Console.WriteLine("As someone who is clearly an expert coder, you have passed the identity test.");
                Console.ReadLine();
                Console.WriteLine("In addition, I now dub thee 'Quiz Wiz'.");
                Console.ReadLine();
                playerName = "Quiz Wiz";
                Console.WriteLine("Congratulations, " + playerName + "!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("You have chosen poorly.");
                Console.ReadLine();
                Console.WriteLine("Our instructor is a coding wizard, so he would definitely know the correct answer to that question.");
                Console.ReadLine();
                Console.WriteLine("Unless...");
                Console.ReadLine();
                Console.WriteLine("I was the one who messed up that definition, and you chose the wrong answer as an act of rebellion!");
                Console.ReadLine();
                Console.WriteLine("I see your game, Player...");
                Console.ReadLine();
                Console.WriteLine("And I respect it. Very well, you may continue.");
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}

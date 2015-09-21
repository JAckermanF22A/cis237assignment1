﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        public string userInput;
        public string foundWine;

        public void PrintMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("--------------------");
            Console.WriteLine("Commands: load .csv" + " | " + "print list" + " | " + "search" + " | " + "add wine" + " | " + "exit");
            Console.WriteLine("Pick a command, if you would.");

            Console.WriteLine("--------------------");
        }

       

        public void GetInput()
        {
            userInput = Console.ReadLine();
        }

        public void PrintTheList()
        {
            int counter = 0;
            int alreadyDisplayed = 0;

            bool exitBool = false;



            while(Program.wineItemCollection.lengthOfArray > alreadyDisplayed && exitBool == false)
            {
                if(counter != 200)
                {
                    Console.WriteLine(Program.wineItemCollection.wineItemArray[alreadyDisplayed].ToString());
                    counter++;
                    alreadyDisplayed++;
                }
                else
                {
                    userInput = "";
                    while(userInput != "y" && exitBool != true)
                    {
                        Console.WriteLine(alreadyDisplayed + " bottles of wine have been printed and there are " + (Program.wineItemCollection.lengthOfArray - alreadyDisplayed) + " wine bottles left" +
                            ", would you like to continue?");
                        Console.WriteLine("y/n?");

                        userInput = Console.ReadLine();

                        if (userInput == "y")
                        {
                            counter = 0;
                        }
                        else if (userInput == "n")
                        {
                            exitBool = true;
                        }
                        else
                        {
                            Console.WriteLine("Error: Please enter y or n");
                        }
                    }
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                }
                
                
            }
        }

        public void SearchDialogue()
        {
            Console.WriteLine("Please input the 5 digit wine ID you would like to search for. Make sure all letters are capatalized.");
        }

        public void FoundDialogue()
        {
            Console.WriteLine("");
            Console.WriteLine(foundWine);
        }

        public void NothingFoundDialogue()
        {
            Console.WriteLine("");
            Console.WriteLine("Sorry, no wine with the ID " + Program.userInterface.userInput + " was found.");
        }

        public void AddDialogueID()
        {
            Console.WriteLine("First, input the new wine's 5 digit ID");
        }

        public void AddDialogueDescription()
        {
            Console.WriteLine("Please enter a description of the wine");
        }

        public void AddDialoguePack()
        {
            Console.WriteLine("Finally, enter what pack the wine is");
        }
    }
}

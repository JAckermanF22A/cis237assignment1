using System;
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
            Console.WriteLine("Commands: display menu " + " | " + "load .csv" + " | " + "print list" + " | " + "search" + " | " + "add wine" + " | " + "exit");

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



            while(Program.wineItemCollection.lengthOfArray > alreadyDisplayed && exitBool == false) //4000 elements and only a certain amount of the bottom elements showing up? No problem!
            {                                                                                       //Just display them in chunks.
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
            Console.WriteLine("A Wine with that ID has been found:");
            Console.WriteLine(foundWine);
        }

        public void NothingFoundDialogue()
        {
            Console.WriteLine("");
            Console.WriteLine("Sorry, no wine with the ID " + Program.userInterface.userInput + " was found.");
        }

        public void AddDialogueID()
        {
            Console.WriteLine("");
            Console.WriteLine("First, input the new wine's 5 digit ID");
        }

        public void AddDialogueDescription()
        {
            Console.WriteLine(""); 
            Console.WriteLine("Please enter a description of the wine");
        }

        public void AddDialoguePack()
        {
            Console.WriteLine("");
            Console.WriteLine("Finally, enter what pack the wine is");
        }

        public void AddDialogueIDErrorMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Sorry, your input was not 5 characters long. Please input a 5 character ID.");
        }

        public void UserInputError()
        {
            Console.WriteLine("");
            Console.WriteLine("Invalid input: Please make sure your command was entered completely in lower case.");
        }

        public void CSVLoaded()
        {
            Console.WriteLine("");
            Console.WriteLine("The .csv has been succesfuly loaded.");
        }

        public void PickSomethingDammit()
        {
            Console.WriteLine("");
            Console.WriteLine("Pick a command, if you would.");
        }

        
    }
}

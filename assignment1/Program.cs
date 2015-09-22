using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


//Assignment #1 CIS237 -- Jacob Ackerman
//9-22-2015 


namespace assignment1
{
    class Program
    {
        static bool CSVloaded; //Used for determining if the CSV file has been loaded.

        //It took me longer than I'd like to admit to figure out that I could make a public instance of a class that I could access from anywhere...
        public static CSVProcessor CSVprocessor = new CSVProcessor();
        public static WineItemCollection wineItemCollection = new WineItemCollection();
        public static UserInterface userInterface = new UserInterface();

        static void Main(string[] args)
        {
            
            Console.SetWindowSize(150, 40); //Expands the console for easier viewing!

            CSVloaded = false; //CSV obviously hasn't been loaded in on program start-up so it should be false.
            userInterface.PrintMenu();
            userInterface.PickSomethingDammit();
            MainLoop();

            
            
        }

        static void MainLoop()
        {
            while (userInterface.userInput != "exit") //Until the user enters exit they can't escape the Matrix. 
            {
                userInterface.GetInput();
                switch (userInterface.userInput) 
                {
                    case "load .csv":
                        LoadCSV();
                        userInterface.PickSomethingDammit();
                        break;

                    case "print list":
                        userInterface.PrintTheList();
                        userInterface.PrintMenu(); //I figure that after the massive list of wine that's going to get printed out the menu probably should be reprinted
                        userInterface.PickSomethingDammit();
                        break;

                    case "search":
                        SearchFunction();
                        userInterface.PickSomethingDammit();
                        break;

                    case "add wine":
                        AddWine();
                        userInterface.PickSomethingDammit();
                        break;
                    case "exit":
                        //Abort, abort, abort!
                        break;
                    case "display menu":
                        userInterface.PrintMenu();
                        break;
                    default:
                        userInterface.UserInputError();
                        userInterface.PickSomethingDammit();
                        break;
                }
            }
        }

        static void LoadCSV()
        {
            if (CSVloaded == true)
            {
                Console.WriteLine("The .csv file has already been loaded.");
            }
            else
            {
                CSVprocessor.OpenTheGates();
                CSVloaded = true;
                userInterface.CSVLoaded();
            }
                        
        }

        static void SearchFunction()
        {
            userInterface.SearchDialogue();
            wineItemCollection.SearchTheArray();
            if (wineItemCollection.wineFound == true)
            {
                userInterface.FoundDialogue();
            }
            else
            {
                userInterface.NothingFoundDialogue();
            }
        }

        static void AddWine()
        {
            string tempID;
            string tempDescription;
            string tempPack;
            bool validationBool = false;

            //Okay, so this loop is way more ridiculous than it should be because at the last minute I remembered user's could enter blanks for the description and pack...
            //So sorry about this mess. 
            while (validationBool == false)
            {
                userInterface.AddDialogueID();
                userInterface.GetInput();

                if (userInterface.userInput.Length == 5)
                {
                    validationBool = true;
                    tempID = userInterface.userInput;

                    bool validation2Bool = false;
                    
                    while(validation2Bool == false)
                    {
                        userInterface.AddDialogueDescription();
                        userInterface.GetInput();

                        if(userInterface.userInput.Trim() == "")
                        {
                            Console.WriteLine("Your input was blank. Please enter a description");
                        }
                        else
                        {
                            tempDescription = userInterface.userInput;
                            validation2Bool = true;
                            bool validation3Bool = false;

                            while( validation3Bool == false)
                            {
                                userInterface.AddDialoguePack();
                                userInterface.GetInput();

                                if(userInterface.userInput.Trim() == "")
                                {
                                    Console.WriteLine("Your input was blank. Please enter a description");
                                }
                                else
                                {
                                    tempPack = userInterface.userInput;
                                    validation3Bool = true;

                                    wineItemCollection.AddWine(new WineItem(tempID, tempDescription, tempPack));
                                }
                            }
                        }
                    }
                    
                }
                else
                {
                    userInterface.AddDialogueIDErrorMessage();
                }
            }
        }
    }
}

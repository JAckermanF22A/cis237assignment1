using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            
            Console.SetWindowSize(150, 40); //Expands the console so that the data will fit. 

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
                        userInterface.PrintMenu();
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


            while (validationBool == false)
            {
                userInterface.AddDialogueID();
                userInterface.GetInput();


                if (userInterface.userInput.Length == 5)
                {
                    validationBool = true;
                    tempID = userInterface.userInput;

                    userInterface.AddDialogueDescription();
                    userInterface.GetInput();
                    tempDescription = userInterface.userInput;

                    userInterface.AddDialoguePack();
                    userInterface.GetInput();
                    tempPack = userInterface.userInput;

                    wineItemCollection.AddWine(new WineItem(tempID, tempDescription, tempPack));
                }
                else
                {
                    userInterface.AddDialogueIDErrorMessage();
                }
            }
        }
    }
}

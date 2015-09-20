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
        static bool CSVloaded;

        public static CSVProcessor CSVprocessor = new CSVProcessor();
        public static WineItemCollection wineItemCollection = new WineItemCollection();
        public static UserInterface userInterface = new UserInterface();

        static void Main(string[] args)
        {
            CSVloaded = false;
            MainLoop();

            
            
        }

        static void MainLoop()
        {
            


            while (userInterface.userInput != "exit")
            {
                
                
                
                userInterface.PrintMenu();
                userInterface.GetInput();
                switch (userInterface.userInput)                //Decides what to do based on user input
                {
                    case "load .csv":
                        if(CSVloaded == true)
                        {
                            Console.WriteLine("The .CSV file has already been loaded.");
                        }
                        else
                        {
                            CSVprocessor.GottaOpenTheFile();
                            CSVloaded = true;
                        }
                        
                        break;
                    case "print list":
                        userInterface.PrintTheList();
                        
                        break;
                    case "3":
                        
                        break;
                    case "4":
                        
                        break;
                    case "exit":
                        //Abort abort abort! Exits the loop and therefor exits the program.
                        break;
                }
            }
        }
    }
}

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

        public void PrintMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("--------------------");
            Console.WriteLine("Commands: load .csv" + " | " + "print list" + " | ");

            Console.WriteLine("--------------------");
        }

       

        public void GetInput()
        {
            userInput = Console.ReadLine();
        }

        public void PrintTheList()
        {
            WineItemCollection wineItemCollection = new WineItemCollection();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        public WineItem[] wineItemArray;
        public int arrayCounter;
        public int lengthOfArray;
        public bool wineFound;

        //Constructor
        public WineItemCollection()
        {
                wineItemArray = new WineItem[4500];
                arrayCounter = 0;
        }

        
        //Methods
        public void populateArray(WineItem wineItem)
        {
            wineItemArray[arrayCounter] = wineItem;
            arrayCounter++;
        }

        public void AddWine(WineItem wineItem)
        {
            int winePosition = wineItemArray.Count(x => x != null) + 1; //Finds the length of the array minus all the null slots.

            if(wineItemArray[winePosition-1] == null) //This is a failsafe incase the .CSV hasn't been loaded in. 
            {                                         //Without it, the added wine would end up in slot 1 with slot 0 being null still, causing problems.
                winePosition = winePosition - 1;
            }

            lengthOfArray++;

            wineItemArray[winePosition] = wineItem;
        }

        public void SearchTheArray()
        {
            arrayCounter = 0;
            lengthOfArray = wineItemArray.Count(x => x != null);
            wineFound = false;

            Program.userInterface.GetInput();

            while(arrayCounter < lengthOfArray && wineFound == false)
            {
                if(Program.userInterface.userInput == wineItemArray[arrayCounter].ID)
                {
                    wineFound = true;
                    Program.userInterface.foundWine = Program.wineItemCollection.wineItemArray[arrayCounter].ToString();
                }
                else
                {
                    arrayCounter++;
                }
            }    
        }



        
        
    }
}

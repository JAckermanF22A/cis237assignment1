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
        public bool arrayInitialized;

        public WineItemCollection()
        {
            if(arrayInitialized != true)
            {
                wineItemArray = new WineItem[4500];
                arrayCounter = 0;
                arrayInitialized = true;
            }
        }

        
        public void populateArray(WineItem wineItem)
        {
            wineItemArray[arrayCounter] = wineItem;
            arrayCounter++;
        }



        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        


        public void GottaOpenTheFile()
        {
            try
            {
                var reader = new StreamReader(File.OpenRead("WineList.CSV"));
                //OpenTheFile = File.OpenRead("WineList.CSV");

                try
                {
                    WineItemCollection wineItemCollection = new WineItemCollection();

                    while (!reader.EndOfStream)
                    {
                        
                        var line = reader.ReadLine();
                        var fields = line.Split(',');

                        WineItem WineItem = new WineItem(fields[0], fields[1], fields[2]);

                        wineItemCollection.populateArray(WineItem);
                    }

                    wineItemCollection.lengthOfArray = wineItemCollection.arrayCounter;
                }
                catch
                {
                    Console.WriteLine("It broke... I don't know why but it broke.");
                }

            }
            catch
            {
                Console.WriteLine("Could not open WineList.CSV. Please place or create WineList.CSV and place it in the debug folder.");
            }
        }




    }
}

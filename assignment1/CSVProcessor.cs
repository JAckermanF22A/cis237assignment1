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
        


        public void OpenTheGates()
        {
            try
            {
                var reader = new StreamReader(File.OpenRead("WineList.csv"));

                Program.wineItemCollection.arrayCounter = Program.wineItemCollection.wineItemArray.Count(x => x != null);

                try
                {
                    while (!reader.EndOfStream)
                    {
                        
                        var line = reader.ReadLine();
                        var fields = line.Split(',');

                        WineItem WineItem = new WineItem(fields[0], fields[1], fields[2]);

                        Program.wineItemCollection.populateArray(WineItem);
                    }

                    Program.wineItemCollection.lengthOfArray = Program.wineItemCollection.wineItemArray.Count(x => x != null);
                }
                catch
                {
                    Console.WriteLine("It broke... I don't know why but it broke.");
                }

            }
            catch
            {
                Console.WriteLine("Could not open WineList.csv. Please place or create WineList.csv and place it in the debug folder.");
            }
        }




    }
}

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
        static StreamReader OpenTheFile;

        

        static List<WineItem> wineItemList = new List<WineItem>();

        static void Main(string[] args)
        {
            GottaOpenTheFile();
            CanWeOutput();

            Console.WriteLine("End");
            
        }

        static void GottaOpenTheFile()
        {
            try
            {
                var reader = new StreamReader(File.OpenRead("WineList.CSV"));
                //OpenTheFile = File.OpenRead("WineList.CSV");

                try
                {
                    while (!reader.EndOfStream)
                    {
                        //readWine = OpenTheFile.ReadLine();

                        //var fields = readWine.Split(',');

                        var line = reader.ReadLine();
                        var fields = line.Split(',');

                        wineItemList.Add(new WineItem
                        {
                            ID = fields[0],
                            description = fields[1],
                            pack = fields[2],
                        });
                    }
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

            //string readWine = OpenTheFile.ReadLine();

            
        }

        static void CanWeOutput()
        {
            int sizeOfList = wineItemList.Count;
            int counter = 0;

            while (counter < sizeOfList)
            {
                Console.WriteLine(wineItemList[counter].ID);
                counter++;
            }
        }
    }
}

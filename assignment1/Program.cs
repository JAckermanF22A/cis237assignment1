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

        static void Main(string[] args)
        {
            GottaOpenTheFile();
        }

        static void GottaOpenTheFile()
        {
            try
            {
                var reader = new StreamReader(File.OpenRead("WineList.CSV"));
                //OpenTheFile = File.OpenRead("C:\Users\Jacob\Desktop\My Stuff\KVCC\Advanced C#\cis237assignment1\assignment1\bin");
            }
            catch
            {
                Console.WriteLine("Could not open WineList.CSV. Please place or create WineList.CSV and place it in the debug folder.");
            }
        }
    }
}

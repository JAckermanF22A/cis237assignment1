using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        public string ID;
        public string description;
        public string pack;

        //My Generic Constructor
        public WineItem()
        {

        }

        //3 Parameter Constructor
        public WineItem(string ID, string description, string pack)
        {
            this.ID = ID;
            this.description = description;
            this.pack = pack;
        }

        public string WineID
        {
            get { return this.ID; }
            set { this.ID = value; }
        }

        public string WineDescription
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public string WinePack
        {
            get { return this.pack; }
            set { this.pack = value; }
        }

        public override string ToString()
        {
            string returnString = this.ID + " | " + this.description + " | " + this.pack + " | ";
            return returnString;
        }

        

        //Public Methods



    }
}

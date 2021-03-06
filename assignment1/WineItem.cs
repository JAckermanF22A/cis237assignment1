﻿using System;
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


        //Public Method
        public override string ToString()
        {
            string returnString = this.ID.PadRight(8) + " | " + this.description.PadRight(60) + " | " + this.pack.PadLeft(5);
            return returnString;
        }



    }
}

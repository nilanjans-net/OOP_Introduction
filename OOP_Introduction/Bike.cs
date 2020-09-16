using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace OOP_Introduction
{
    class Bike : Vehicle
    {
        // make, type, numberOfGears;

        
        public override bool verifyRegistrationNumber()
        {
            return getRegistration_number() > 1000;
        }

        private string make;
        private string type;
        private int numberOfGears;

        private string newvar;

        public void setMake(string newMake)
        {
            this.make = newMake;
        }
        public string getMake()
        {
            return this.make;
        }
        
        public void setType(string newType)
        {
            this.type = newType;
        }
        public string getType()
        {
            return this.type;
        }

        

        public void setNumberOfGears(int gears)
        {
            this.numberOfGears = gears;
        }
        public int getNumberOfGears()
        {
            return this.numberOfGears;
        }


    }
}

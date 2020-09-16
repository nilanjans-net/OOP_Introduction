using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Introduction
{
    class Car : Vehicle
    {
        // make, type, ModelYear, numberOfDoors;

        public Boolean isAntic()
        {
            return modelYear < 1980;
        }

        private string make;
        private string type;
        private int modelYear;
        private int numberOfDoors;

        public void setMake(string make)
        {
            this.make = make;
        }
        public string getMake()
        {
            return this.make;
        }
        

        public string getType()
        {
            return this.type;
        }

        public void setType(string newType)
        {
            this.type = newType;
        }

        

        public int getModelYear()
        {
            return this.modelYear;
        }
        public void setModelYear(int newModelYear)
        {
            this.modelYear = newModelYear;
        }
       
    }
}

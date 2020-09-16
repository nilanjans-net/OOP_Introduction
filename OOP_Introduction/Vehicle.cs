using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Introduction
{
    
    class Vehicle
    {
        private string color;
        private float registration_number;
        public MyPerson Owner { get; set; }

        public void changeOwner(MyPerson newOwner)
        {
            this.Owner = newOwner;
        }

        
        public virtual bool verifyRegistrationNumber()
        {
            return this.registration_number > 100;
        }

        public string getColor()
        {
            return this.color;
        }

        public void setColor(string color)
        {
            this.color = color;                 
        }

        public float getRegistration_number()
        {
            return this.registration_number;
        }
        public void setRegistration_number(float registrationNumber)
        {
            this.registration_number = registrationNumber;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Introduction
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Problem statement 1");
            // Problem statement 1
            Bike mybike = new Bike();

            mybike.setNumberOfGears(6);
            Console.WriteLine("Is my bike registered : " + mybike.verifyRegistrationNumber());
           
            Car mycar = new Car();
            mycar.setModelYear(1979);

            Console.WriteLine("Is my car antic : " + mycar.isAntic());

            Console.WriteLine();
            Console.WriteLine("Problem statement 2");
            // Problem statement 2

            mycar.Owner = new MyPerson("Alex", "Zhideev");

            Console.WriteLine("Current owner : " + mycar.Owner.getOwnerName());

            mycar.changeOwner(new MyPerson("Daniel", "Smith"));
            
            Console.WriteLine("New owner : " + mycar.Owner.getOwnerName());

            Console.ReadKey();

           
        }
    }
}

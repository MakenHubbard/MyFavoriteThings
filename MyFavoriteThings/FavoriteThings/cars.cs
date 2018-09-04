using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    class Cars
    {
        public string Model { get; set; }

        string model = "";

        public void modelOfCar ()
        {
            Console.WriteLine("What is your favorite model of car?");
            model = Console.ReadLine().ToLower();

            if (model == "")
            {
                Console.WriteLine("please choose a vehicle");
            }
            else
            {
                Console.WriteLine($@" a {model}!!!??? Really???");
            }

            var make = "";
            Console.WriteLine($"What make of {model} do you like best");
            make = Console.ReadLine().ToLower();
            
            if (model == "ford")
            {
                Console.WriteLine("Some people would call you queer for that.");
            }
            else if ( model == "chevy" || model == "chevrolet")
            {
                Console.WriteLine("Ewww I know ford lovers that would think that was dumb");
            }
            else
            {
                Console.WriteLine($"Having a {model} {make} would be pretty cool I guess...");
            }
        }
    }
}

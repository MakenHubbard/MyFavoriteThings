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
            Console.WriteLine("What id your favorite model of car?");
            model = Console.ReadLine();

            if (model == "")
            {
                Console.WriteLine("please choose a vehicle");
            }
            else
            {
                Console.WriteLine($@"{model} is a really cool Kar");
            }
        }
    }
}

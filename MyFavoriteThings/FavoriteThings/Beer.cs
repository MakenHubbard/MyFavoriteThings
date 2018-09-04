using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    class Beer
    {
        public string Type { get; set; }

        string typeOfBeer = "";

        public void whatType()
        {
            Console.WriteLine("what type of beer is your favorite?");
            typeOfBeer = Console.ReadLine().ToLower();

            if (typeOfBeer.ToLower() == "pale ale")
            {
                Console.WriteLine("That is Cool");
            }
            else 
            {
                Console.WriteLine("you are gross");
            }

            int howMany = 1;
            Console.WriteLine("how many beers would you say you drink on average?");
            howMany = Convert.ToInt32(Console.ReadLine());

            if (howMany > 3)
            {
                Console.WriteLine($"{howMany}! Alright you alcoholic!");
            }
            else
            {
                Console.WriteLine($"Only {howMany}!?! Pussay!!!!");
            }

        }

    }
}

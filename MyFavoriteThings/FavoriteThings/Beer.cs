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
            typeOfBeer = Console.ReadLine();

            if (typeOfBeer.ToLower() == "pale ale")
            {
                Console.WriteLine("That is Cool");
            }
            else 
            {
                Console.WriteLine("you are gross");
            }

        }

    }
}

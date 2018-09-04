using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    class Games
    {
        public string What { get; set; }

        string whatNewVideoGame = "";

        public void newGames ()
        {
            Console.WriteLine("Out of the Following Video Games Which one is your favorite");
            Console.WriteLine("Red Dead, D2, FallOut 76, Last Of Us 2");
            whatNewVideoGame = Console.ReadLine().ToLower();

            if (whatNewVideoGame == "Red Dead")
            {
                Console.WriteLine("Hell Me to super Pumped about it");
            }
            else if (whatNewVideoGame == "D2")
            {
                Console.WriteLine("Thats cool but I dont have that game anymore so cant relate");
            }
            else if (whatNewVideoGame == "FallOut 76")
            {
                Console.WriteLine("That's what syrup");
            }
            else if (whatNewVideoGame == "Last Of Us 2")
            {
                Console.WriteLine("That game looks intense and it turns me on");
            }
            else if (whatNewVideoGame == "")
            {
                Console.WriteLine("Please choose a game above!");
            }
        }

    
    }
}

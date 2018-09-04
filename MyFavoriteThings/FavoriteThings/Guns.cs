using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    class Guns
    {
        public string Type { get; set; }

        string typeOfGun = "";

        public void whatKind ()
        {
            Console.WriteLine("Would you choose a pistol, assault rifle, or an RPG to target shoot with?");
            typeOfGun = Console.ReadLine().ToLower();

            if(typeOfGun == "pistol")
            {
                Console.WriteLine("pew pew");
            }
            else if (typeOfGun == "assault rifle")
            {
                Console.WriteLine("bang bang");
            }
            else if (typeOfGun == "RPG")
            {
                Console.WriteLine("so destructive I like it.");
            } 
            else if (typeOfGun == "")
            {
                Console.WriteLine("hell yeah no guns are cool too");
            }

            var calliber = "";
            Console.WriteLine($"What calliber would you prefer to shoot out of that {typeOfGun}?");
            calliber = Console.ReadLine().ToLower();
            Console.WriteLine($"You are Shooting a {typeOfGun} with a {calliber} calliber bullet at the target.");
        }
    }
}

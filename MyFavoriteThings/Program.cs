using System;
using MyFavoriteThings.FavoriteThings;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var beer = new Beer();
            var gun = new Guns();
            var game = new Games();
            var cars = new Cars();

            beer.whatType();
            gun.whatKind();
            game.newGames();
            cars.modelOfCar();



            Console.ReadLine();
        }
    }
}

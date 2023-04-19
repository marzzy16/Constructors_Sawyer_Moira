using System;

namespace Constructors_Sawyer_Moira
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Prints the title and genre of the game.
            Game myGame = new Game("CS:GO", "FPS");
            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game!");

            Game myOtherGame = new Game();

            // Prints the title and genre of the OtheerGame.
            Console.WriteLine($"My other favorite game is {myOtherGame.title}and it is a {myOtherGame.genre} game!");
        }
    }
}

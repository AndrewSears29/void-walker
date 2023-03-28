using System;


// create a loop for game

namespace Voidwalker
{
    public class Program
    {
        static void Main()
        {
            Game.GameTitle();
            Game.StartGame();
            Console.WriteLine("Press Any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You hear a voice in the back of your head...");
            Game.Dialog(Game.CharacterName + ", wake up... It is time...", "red");
            Console.WriteLine();
            Game.Choice();
            Console.ReadKey();
            Console.WriteLine();
            Game.Dialog("Here... Take this.", "red");
            Console.WriteLine();
            Item.PlayerItems.Add("flashlight");
            Console.WriteLine("You got a Flashlight!");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            Console.Clear();
            Game.SecondChoice();
            Console.ReadKey();

        }

    }
   
}
    
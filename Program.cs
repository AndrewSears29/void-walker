using System;




namespace Voidwalker
{
    public class Program
    {
        public static void Main()
        {
            Game.GameTitle();
            Game.StartGame();
            Console.WriteLine();
            Game.Choice();
            Console.ReadKey();
            Console.WriteLine();
            Game.Dialog("Here... Take this.", "red");
            Console.WriteLine();
            Game.PlayerItems.Add("flashlight");
            Console.WriteLine("You got a Flashlight!");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            Console.Clear();
            Game.SecondChoice();
            Game.FinalBattle();
            
        }

    }
   
}
    
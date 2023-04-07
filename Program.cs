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
            Console.WriteLine(Game.Choice());
            Console.ReadKey();
            Console.WriteLine();
            Game.Dialog("Here... Take this.", "red");
            Item flashlight = new Item();
            flashlight.Weight = 5;
            flashlight.Power = 1;
            Console.WriteLine();
            Game.PlayerItems.Add(flashlight);
            Console.WriteLine("You got a Flashlight!");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            Console.Clear();
            Weapon knife = new Weapon();
            knife.Weight = 2;
            knife.Power = 8;
            knife.Durability = 4;
            Game.SecondChoice(knife);
            Game.FinalBattle(knife);
        }

    }
   
}
    
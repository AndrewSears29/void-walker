using System;


// Game class contains all methods for game mechanics 

namespace Voidwalker
{
    public class Game
    {

        

        // StartGame method introduces player to the game 
        // as well as calls the method to name a character

        public static string CharacterName = ("Andrew Sears");
        public static void StartGame()
        {
            Console.WriteLine("Welcome...");
            NameCharacter();
            Console.WriteLine("Press Any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You hear a voice in the back of your head...");
            Dialog(CharacterName + ", wake up... It is time...", "red");

        }

        // GameOver contains all of the end of game content and a way for the player to
        // restart or end the game

        public static void GameOver()
        {
            string EndTitle = @"

 _____   ___  ___  ___ _____   _____  _   _ ___________ 
|  __ \ / _ \ |  \/  ||  ___| |  _  || | | |  ___| ___ \
| |  \// /_\ \| .  . || |__   | | | || | | | |__ | |_/ /
| | __ |  _  || |\/| ||  __|  | | | || | | |  __||    / 
| |_\ \| | | || |  | || |___  \ \_/ /\ \_/ / |___| |\ \ 
 \____/\_| |_/\_|  |_/\____/   \___/  \___/\____/\_| \_|
                                                        
                                                        
";
            Console.Title = EndTitle;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(EndTitle);
            Console.ResetColor();

            string input = "";
            Console.WriteLine("Press 1 to restart or 2 to end...");
            input = Console.ReadLine();

            if (input == "1")
            {
                PlayerItems.Clear();
                Console.Clear();
                Program.Main();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        // opening title 

        public static void GameTitle()
        {
            string Title = @" _                      _                                  
- - _-            |\   - - /, /,       ,, ,,               
  )-  )        '   \\    )/ )/ )   _   || ||               
  )___)  /'\\ \\  / \\   )__)__)  < \, || ||/\  _-_  ,._-_ 
 ~)___) || || || || ||  ~)__)__)  /-|| || ||_< || \\  ||   
  )  )  || || || || ||   )  )  ) (( || || || | ||/    ||   
 /-_/   \\,/  \\  \\/   /-_/-_/   \/\\ \\ \\,\ \\,/   \\,

";
            Console.Title = Title;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Title);
            Console.ResetColor();
            Console.WriteLine("Press enter to start");
            Console.ReadKey();
            Console.Clear();

        }

        // allows player to name a character and saves the character name

        public static void NameCharacter()
        {
            Console.WriteLine("What is your name?");
            CharacterName = Console.ReadLine();
            Console.WriteLine(CharacterName + "? That sounds familiar...");

        }

        // this is an array of scenarios that the player will experience or not based on choices

        public static string[] PartOne =
        {
            "You turn on the flashlight and see you are not in your house.\n There is a door in front of you.\n You hear knocking.\n Will you answer? Y/N",
            "You open the door.\n A long hallway with flickering flourescent lights appears.\n",
            "The knocking continues.\n You look around and find a hole in the wall big enough to crawl through.",
            "You begin to feel a strange familiarity with this place.\n Have you been here before?",
            "You begin to walk down the hallway.",
            "You look into the hole using your Flashlight. \n You see something glimmer against the light. You reach in and find a knife.",
            "A foul stench begins to fill the air around you. \n It is almost unbearable. \n You continue... fearing what you might find."

        };

        // this is a way to create dialog text in several colors

        public static void Dialog(string message, string color)
        {
            if (color == "red")
            { Console.ForegroundColor = ConsoleColor.DarkRed; }
            else if (color == "blue")
            { Console.ForegroundColor = ConsoleColor.Blue; }
            else if (color == "yellow")
            { Console.ForegroundColor = ConsoleColor.DarkYellow; }
            else
            { Console.ForegroundColor = ConsoleColor.White; }

            Console.Write(message);
            Console.ResetColor();
        }

        // this is a way to color the ascii art in the program

        public static void Visuals(string message, string color)
        {
            if (color == "green")
            { Console.ForegroundColor = ConsoleColor.Green; }
            else if (color == "red")
            { Console.ForegroundColor = ConsoleColor.DarkRed; }
            else if (color == "blue")
            { Console.ForegroundColor = ConsoleColor.Blue; }
            else
            { Console.ForegroundColor = ConsoleColor.White; }

            Console.Write(message);
            Console.ResetColor();
        }

        // this method is the choice to wake up or not

        public static string Choice()
        {
            string input = "";
            Console.WriteLine("Wake up? Y/N");
            input = Console.ReadLine();
            input = input.ToUpper();




            if (input == "Y")
            {
                return "Good, so you are not a coward.";
            }
            else 
            {
                return "Enjoy your slumber...COWARD!";
                
            }


        }

        // this method contains all of the functionality to take the player through
        // the paths contained in PartOne array

        public static void SecondChoice(Item knife)
        {
            string input = "";
            Game.Visuals(@"
            __________
           |  __  __  |
           | |  ||  | |
           | |  ||  | |
           | |__||__| |
           |  __  __()|
           | |  ||  | |
           | |  ||  | |
           | |  ||  | |
           | |  ||  | |
           | |__||__| |
	   |__________|

", "green");

            Console.WriteLine(PartOne[0]);
            input = Console.ReadLine();
            input = input.ToUpper();

            if (input == "Y")
            {
                Console.Clear();

                Game.Visuals(@"
 _____________________________________________
|.'',                                     ,''.|
|.'.'',                                 ,''.'.|
|.'.'.'',                             ,''.'.'.|
|.'.'.'.'',                         ,''.'.'.'.|
|.'.'.'.'.|                         |.'.'.'.'.|
|.'.'.'.'.|===;                 ;===|.'.'.'.'.|
|.'.'.'.'.|:::|',             ,'|:::|.'.'.'.'.|
|.'.'.'.'.|---|'.|, _______ ,|.'|---|.'.'.'.'.|
|.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
|,',',',',|---|',|'|???????|'|,'|---|,',',',',|
|.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
|.'.'.'.'.|---|','   /%%%\   ','|---|.'.'.'.'.|
|.'.'.'.'.|===:'    /%%%%%\    ':===|.'.'.'.'.|
|.'.'.'.'.|%%%%%%%%%%%%%%%%%%%%%%%%%|.'.'.'.'.|
|.'.'.'.','       /%%%%%%%%%\       ','.'.'.'.|
|.'.'.','        /%%%%%%%%%%%\        ','.'.'.|
|.'.','         /%%%%%%%%%%%%%\         ','.'.|
|.','          /%%%%%%%%%%%%%%%\          ','.|
|;____________/%%%%%%%%%%%%%%%%%\____________;|


", "blue");
                Console.WriteLine(PartOne[1]);
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadKey();

            }
            else
            {
                Console.Clear();
                Console.WriteLine(@"");

                Console.WriteLine(PartOne[2]);
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadKey();
                Console.Clear();
            }


            Console.WriteLine(PartOne[3]);
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();


            if (input == "Y")
            {
                Console.WriteLine(PartOne[4]);
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadKey();

            }
            else
            {
                Console.Clear();

                Game.Visuals(@"
       .---.
       |---|
       |---|
       |---|
   .---^ - ^---.
   :___________:
      |  |//|
      |  |//|
      |  |//|
      |  |//|
      |  |//|
      |  |//|
      |  |.-|
      |.-'**|
       \***/
        \*/
         V

", "green");

                
                PlayerItems.Add(knife);
                ; Console.WriteLine(PartOne[5]);
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadKey();
                Console.Clear();
                Game.Visuals(@"
 _____________________________________________
|.'',                                     ,''.|
|.'.'',                                 ,''.'.|
|.'.'.'',                             ,''.'.'.|
|.'.'.'.'',                         ,''.'.'.'.|
|.'.'.'.'.|                         |.'.'.'.'.|
|.'.'.'.'.|===;                 ;===|.'.'.'.'.|
|.'.'.'.'.|:::|',             ,'|:::|.'.'.'.'.|
|.'.'.'.'.|---|'.|, _______ ,|.'|---|.'.'.'.'.|
|.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
|,',',',',|---|',|'|???????|'|,'|---|,',',',',|
|.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
|.'.'.'.'.|---|','   /%%%\   ','|---|.'.'.'.'.|
|.'.'.'.'.|===:'    /%%%%%\    ':===|.'.'.'.'.|
|.'.'.'.'.|%%%%%%%%%%%%%%%%%%%%%%%%%|.'.'.'.'.|
|.'.'.'.','       /%%%%%%%%%\       ','.'.'.'.|
|.'.'.','        /%%%%%%%%%%%\        ','.'.'.|
|.'.','         /%%%%%%%%%%%%%\         ','.'.|
|.','          /%%%%%%%%%%%%%%%\          ','.|
|;____________/%%%%%%%%%%%%%%%%%\____________;|


", "blue");


                Console.WriteLine(PartOne[1]);
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadKey();

            }

            Console.WriteLine(PartOne[6]);
            Console.ReadLine();
            Console.Clear();
        }

        // this method initiates the final battle in which the player will win or lose based on if
        // the PlayerItems list contains "knife"

        public static void FinalBattle(Weapon knife)
            {
                Console.WriteLine("A gruesome figure appears. It looks dead but it isn't.");
                Console.ReadKey();
                Game.Visuals(@"

               _.---._
             .'       `.
             :)       (:
             \ (@) (@) /
              \   A   /
               )     (
               \""""""/
                `._.'
                 .=.
         .---._.-.=.-._.---.
        / ':-(_.-: :-._)-:` \
       / /' (__.-: :-.__) `\ \
      / /  (___.-` '-.___)  \ \
     / /   (___.-'^`-.___)   \ \
    / /    (___.-'=`-.___)    \ \
   / /     (____.'=`.____)     \ \
  / /       (___.'=`.___)       \ \
 (_.;       `---'.=.`---'       ;._)
 ;||        __  _.=._  __        ||;
 ;||       (  `.-.=.-.'  )       ||;
 ;||       \    `.=.'    /       ||;
 ;||        \    .=.    /        ||;
 ;||       .-`.`-._.-'.'-.       ||;
.:::\      ( ,): O O :(, )      /:::.
|||| `     / /'`--'--'`\ \     ' ||||
''''      / /           \ \      ''''
         / /             \ \
        / /               \ \
       / /                 \ \
      / /                   \ \
     / /                     \ \
    /.'                       `.\
   (_)'                       `(_)
    \\.                       .//
     \\.                     .//
      \\.                   .//
       \\.                 .//
        \\.               .//
         \\.             .//
    	   \\.           .//
          ///)         (\\\
        ,///'           `\\\,
       ///'               `\\\
      """"'                   '""""
                
           ", "red");

                Console.WriteLine("THE FIGURE ATTACKS!");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadKey();

                if (PlayerItems.Contains(knife))
                {
                    Console.WriteLine("You defeat the figure with your newly found knife. Congratulations, you have survived....For now.. Press Enter to continue..");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Thank you for playing!");
                    Game.GameOver();



                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Unfortunatley you had nothing to defend yourself...");
                    Game.GameOver();


                }
           
    }

        // list of items the player acquires
        public static List<Item> PlayerItems = new List<Item>();
    }

}

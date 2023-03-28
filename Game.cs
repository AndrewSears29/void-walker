using System;



namespace Voidwalker
{
    public static class Game
    {

        public static string CharacterName = ("Andrew Sears");
        public static void StartGame()
        {
            Console.WriteLine("Welcome...");
            NameCharacter();


        }

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
            Console.WriteLine("Press Enter to end...");
        }

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

        public static void NameCharacter()
        {
            Console.WriteLine("What is your name?");
            CharacterName = Console.ReadLine();
            Console.WriteLine(CharacterName + "? That sounds familiar...");

        }

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
        public static void Choice()
        {
            string input = "";
            Console.WriteLine("Wake up? Y/N");
            input = Console.ReadLine();
            input = input.ToUpper();

            if (input == "Y")
            {
                Game.Dialog("Good, So you are not a coward.", "red");
            }
            else if (input == "N")
            {
                Game.Dialog("Enjoy your slumber...COWARD!", "red");
                Console.WriteLine();
                Console.WriteLine("Press Any key to EXIT...");
                Console.ReadKey();
                Environment.Exit(0);
            }


        }

        public static void SecondChoice()
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

","green");

                Item.PlayerItems.Add("knife");
;                Console.WriteLine(PartOne[5]);
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


","blue");


                Console.WriteLine(PartOne[1]);
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadKey();
                
            }

            Console.WriteLine(PartOne[6]);
            Console.ReadLine();
            Console.Clear();

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
                
           ","red");

            Console.WriteLine("THE FIGURE ATTACKS!");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();

            if (Item.PlayerItems.Contains("knife"))
            {
                Console.WriteLine("You defeat the figure with your newly found knife. Congratulations, you have survived....For now..");


            }
            else
            {
                Console.Clear();
                Console.WriteLine("Unfortunatley you had nothing to defend yourself...");
                Game.GameOver();
                

            }
        }

    }


}

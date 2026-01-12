using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medaillesopdr
{
    internal class NummerTwee
    {
        public void  twee()
        {
          
                bool dead = false;

                Console.WriteLine("Welcome! You are currently in the living room. Choose: Kitchen, Hallway, or Outside (case sensitive):");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "Kitchen":
                        Console.WriteLine("You are now in the kitchen, You see an old butterscotch pie from earlier, Eat it?");

                        break;
                    case "Hallway":
                        Console.WriteLine("You are now in the hallway.. You suddenly feel extremely tired... better go to bed. Options: Restroom, Outside, Upstairs");
                        break;

                    case "Outside":
                        Console.WriteLine("Did I forget to mention the outside was poisonous? My bad. You got radiation poisoning and died. HA loser."); //the illusion of choice.
                        dead = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;

                }
                if (dead) Environment.Exit(0);
                string choice2 = Console.ReadLine();

                switch (choice2)
                {
                    case "Restroom":
                        Console.WriteLine("you died of explosive diarrhea, wow...");
                        break;

                    case "Outside":
                        Console.WriteLine("Did I forget to mention the outside was poisonous? My bad. You got radiation poisoning and died. HA loser.");
                        dead = true;
                        break;
                    case "Upstairs":
                        Console.WriteLine("Where to next? Options: My room, Attic, Bathroom");
                        break;
                    case "Yes":
                        Console.WriteLine("Oh no it was toriel's, she came in and beat you up, gg you died");
                        dead = true;
                        break;
                    case "No":
                        Console.WriteLine("Damn you starved and died, gg");
                        dead = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;

                }
                if (dead) Environment.Exit(0);
                string choice3 = Console.ReadLine();
                switch (choice3)
                {
                    case "Attic":
                        Console.WriteLine("GHOST ATTACK! gg you died");
                        dead = true;
                        break;

                    case "My room":
                        Console.WriteLine("you went to bed peacefully. you survived another day");
                        break;
                    case "Bathroom":
                        Console.WriteLine("You threw up till you died.. gross..");
                        dead = true;
                        break;
                }
                if (dead) Environment.Exit(0);
            }
        }
    }
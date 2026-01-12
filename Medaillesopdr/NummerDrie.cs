using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Medaillesopdr
{
    internal class NummerDrie
    {
   
        public void drie()
        {
            
            Console.WriteLine("Hey wat voor weer is het? Zonnig, Regen of Bewolkt? (Case sensitive)");
            string geblabber = Console.ReadLine();
            if(geblabber == "Zonnig")
            {
                Console.WriteLine("Okay, en wat is de temperatuur?");
                String temp = Console.ReadLine();
                if (int.TryParse(temp, out int number))
                {
                    if (number > 20)
                    {
                        Console.WriteLine("Damn, doe een jas aan!");
                    }
                    else
                    {
                        Console.WriteLine("Oh, lekker, zonnen vanavond");
                    }
                } else
                {
                    Console.WriteLine("Not a number dumbass.");
                }
                
                
                
            } if (geblabber == "Regen")
            {
                Console.WriteLine("Dus.. Regen jas aan, Hoeveel graden is het?");
               String temperatuur = Console.ReadLine();
                if (int.TryParse(temperatuur, out int number))
                {
                    if (number > 20)
                    {
                        Console.WriteLine("eh you should be fine, hf getting wet");
                    }
                    else
                    {
                        Console.WriteLine("gg bro, gg.");
                    }
                }
                else
                {
                    Console.WriteLine("Not a number dumbass.");
                }


            }
            if (geblabber == "Bewolkt") 
            {
                Console.WriteLine("Okay, Okay, And the temperature?");
                    String temperatuur = Console.ReadLine();
                    if (int.TryParse(temperatuur, out int number))
                    {
                        if (number > 20)
                        {
                            Console.WriteLine("not too bad ig");
                        }
                        else
                        {
                            Console.WriteLine("gonna be cold, atleast  wear a hoodie or a jacket c:");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not a number dumbass.");
                    }
                


                }




            }

        }
    }





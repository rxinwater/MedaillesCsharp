using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medaillesopdr
{
    internal class Nummereen
    {
        public void een()
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            String age = Console.ReadLine();
            Console.WriteLine("Your name is " + name + " and you are " + age + " years old.");
        }
    }
}

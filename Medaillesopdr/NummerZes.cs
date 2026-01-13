using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medaillesopdr
{
    internal class NummerZes
    {
        private int frequencyGuessed = 0;
        private bool correct = false;
      
        public void nummerzes()
        {
           
            Random YIPPIE = new Random();
            int randomNumber = YIPPIE.Next(1, 26);
            Console.WriteLine("Guess a number between 1 and 25, Numbers only.");
            string guessedNumber = Console.ReadLine();
            while (correct == false)
            {
                
                if (int.TryParse(guessedNumber, out int number))
                {
                    if (number > randomNumber && number > 0 && number < 26 )
                    {
                        frequencyGuessed = frequencyGuessed + 1;
                        Console.WriteLine("Lowerr, guessed amounts: " + frequencyGuessed);
                       guessedNumber = Console.ReadLine();
                    }
                    if (number < randomNumber && number > 0 && number < 26)
                    {
                        frequencyGuessed = frequencyGuessed + 1;
                        Console.WriteLine("Higher!, guessed amounts: " + frequencyGuessed);
                        guessedNumber = Console.ReadLine();
                    }
                    if (number == randomNumber)
                    {
                        correct = true;
                        Console.WriteLine("Nice, you got it in " + frequencyGuessed + " attempts!"); //can only guess once so far, fix.
                    }
                    if (number > 25 || number < 1)
                    {
                        Console.WriteLine("Between 1 and 25, dumbass.");
                        guessedNumber = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, numbers only nerd");
                }
            }
        }
    }
}

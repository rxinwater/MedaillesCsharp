using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medaillesopdr
{
    internal class NummerZeven
    {
        public void Nummerzeven()
        {
            Random rndm = new Random();
            int number = rndm.Next(1, 7);
            Console.WriteLine("Dice thrown!, You threw a " + number);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medaillesopdr
{
    internal class NummerAcht
    {
        public class Player
        {
            private string Name;
            private int Level;
            public Player(string name, int lvl)
            {
                Name = name;
                Level = lvl;
            }
            public void ShowStats() {
                Console.WriteLine("your character is called " + Name + " and you are level " + Level);
            }


        }


    }
}

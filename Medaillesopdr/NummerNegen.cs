using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medaillesopdr
{
    internal class NummerNegen
    {
        public class Weapons
        {

            private string Name;
            private int Damage;
           



            public Weapons(string name, int dmg)
            {
                Name = name;
                Damage = dmg;
                
            }
            public void ShowStats()
            {
                Console.WriteLine("Weapon is called " + Name + " and does " + Damage + " damage.");
            }
        }
    }
}


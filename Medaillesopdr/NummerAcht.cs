using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medaillesopdr
{
    internal class NummerAcht
    {
        private List<Player> players = new List<Player>();
        public void AddPlayer(Player a)
        {
            players.Add(a);
        }
        public class Player
        {

            private string _name;
            private int level;
            private int lives;

           

            public Player(string name, int lvl, int lives)
            {
                _name = name;
                level = lvl;
                this.lives = lives;
            }
            

            public void ShowStats()
            {
              Console.WriteLine("You're called " + _name + ". You're level " + level + " with " + lives + " Lives remaining");
            }
            
           

        }
        public void ShowAll()
        {
            foreach (Player p in players)
            {
                p.ShowStats();
            }
        }


    }
}

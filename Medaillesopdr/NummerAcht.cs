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

            private string Name;
            private int Level;
            private int Lives;

           

            public Player(string name, int lvl, int lives)
            {
                Name = name;
                Level = lvl;
                Lives = lives;
            }
            

            public void ShowStats()
            {
              Console.WriteLine("You're called " + Name + ". You're level " + Level + " with " + Lives + " Lives remaining");
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

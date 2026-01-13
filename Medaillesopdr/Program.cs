using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Medaillesopdr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //NummerZes zes = new NummerZes();
            //zes.nummerzes();
            //NummerZeven zeven = new NummerZeven();
            //zeven.Nummerzeven();

            NummerAcht.Player zxro = new NummerAcht.Player("Zxro", 1);
            NummerAcht.Player ducky = new NummerAcht.Player("Duck", 999);
            zxro.ShowStats();
            ducky.ShowStats();

        }
    }
}



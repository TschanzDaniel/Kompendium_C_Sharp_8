using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompendium_C_Sharp_8
{
    public class Spielfeld
    {
        public void CreateSpielfeld()
        {
            string[,] spielfeld = new string[4,4];

                spielfeld[0, 0] = "  ";
                spielfeld[0, 1] ="1 ";
                spielfeld[0, 2] ="2 ";
                spielfeld[0, 3] ="3 ";
                spielfeld[1, 0] = "A|";
                spielfeld[1, 1] = "_|";
                spielfeld[1, 2] = "_|";
                spielfeld[1, 3] = "_|";
                spielfeld[2, 0] = "B|";
                spielfeld[2, 1] = "_|";
                spielfeld[2, 2] = "_|";
                spielfeld[2, 3] = "_|";
                spielfeld[3, 0] = "C|";
                spielfeld[3, 1] = "_|";
                spielfeld[3, 2] = "_|";
                spielfeld[3, 3] = "_|";

            Console.WriteLine(spielfeld[0, 0] + spielfeld[0, 1] + spielfeld[0, 2] + spielfeld[0, 3]);
            Console.WriteLine(spielfeld[1, 0] + spielfeld[1, 1] + spielfeld[1, 2] + spielfeld[1, 3]);
            Console.WriteLine(spielfeld[2, 0] + spielfeld[2, 1] + spielfeld[2, 2] + spielfeld[2, 3]);
            Console.WriteLine(spielfeld[3, 0] + spielfeld[3, 1] + spielfeld[3, 2] + spielfeld[3, 3]);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class intro
    {
        fonts f = new fonts();
        public void run()
        {
            f.sixtyone();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t                         A TWO-PLAYER GAME");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t****************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t                           INSTRUCTIONS:");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t\t\t\t       >>   ONE PLAYER PLAY WITH X AND THE OTHER PLAY WITH 0.");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t           IN THIS GAME WE HAVE A BOARD CONSISTING OF A 3X3 GRID.");  
            Console.WriteLine("\t\t\t\t\t\t\t\t\t           ONLY ONE PLAYER CAN PLAY AT A TIME. IF ANY OF THE PLAYERS");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t           HAVE FILLED A SQUARE THEN THE OTHER PLAYER AND THE SAME PLAYER");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t           CANNOT OVERRIDE THAT SQUARE. THE PLAYER THAT SUCCEDS IN PLACING");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t           THREE RESPECTIVE MARKS (X OR O) IN A HORIZONTAL, VERTICAL, OR");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t           DIAGONAL WINS THE GAME!!");
            Console.WriteLine(); 
            Console.WriteLine("\t\t\t\t\t\t\t\t\t*****************************************************************************");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t\t\t\t                     PRESS ANY KEY TO CONTINUE...");
        }
    }
}

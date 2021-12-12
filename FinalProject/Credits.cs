using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Credits
    {
        public string choice { get; set; }
        fonts fn = new fonts();

        public void showCredits()
        {

            fn.fiftyfive();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t                                                                                      ____________________________________");
            Console.WriteLine("\t\t\t\t\t\t                                                                                     |               SOURCES              |");
            Console.WriteLine("\t\t\t\t\t\t                                                                                     |____________________________________|");
            Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|     CODE                        NAMES                                      CODE    |     1. STAR WARS THEME MUSIC       |");
            Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      1                        JHON ERIC ATON                                1      |     2. STACKOVERFLOW               |");
            Console.WriteLine("\t\t\t\t\t\t|      2                        KIAN RUIZ                                     2      |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      3                        JONAS RESSURECCION                            3      |     3. YOUTUBE                     |");
            Console.WriteLine("\t\t\t\t\t\t|      4                        RIOHEART SANTOS                               4      |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      5                        RUTH FRANCISCO                                5      |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|____________________________________________________________________________________|____________________________________|");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

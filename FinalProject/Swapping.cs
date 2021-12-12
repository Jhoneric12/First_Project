using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Swapping
    {
        //Global Variables
        public string choice { get; set; }
        public string word1 { get; set; }
        public string word2 { get; set; }
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double swapperNum { get; set; }
        public string swapperWords { get; set; }
        public string swapAgain { get; set; }

        fonts FON = new fonts();

        // Swapping main menu
        public void swap()
        {
         start:
            //do
            //{
                Console.Clear();
                FON.sixth();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t                                                                                      ____________________________________");
                Console.WriteLine("\t\t\t\t\t\t                                                                                     |                                    |");
                Console.WriteLine("\t\t\t\t\t\t                                                                                     |____________________________________|");
                Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
                Console.WriteLine("\t\t\t\t\t\t|     CODE                          MENU                               CODE          |                                    |");
                Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
                Console.WriteLine("\t\t\t\t\t\t|      1                           WORDS                                1            |         PROF. ALKING SUNGA         |");
                Console.WriteLine("\t\t\t\t\t\t|                                                                                    |                                    |");
                Console.WriteLine("\t\t\t\t\t\t|      2                           NUMBERS                              2            |                                    |");
                Console.WriteLine("\t\t\t\t\t\t|____________________________________________________________________________________|____________________________________|");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("\t\t\t\t\t\t\t\t\t\t\t     >> ENTER CHOICE : ");
                choice = Console.ReadLine();
                Console.WriteLine();

                if (choice.Equals("WORDS", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("1"))
                {
                    Console.Write("\t\t\t\t\t\t\t\t\t\t\t     >> ENTER FIRST WORDS   : ");
                    word1 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t\t     >> ENTER SECOND WORDS  : ");
                    word2 = Console.ReadLine();
                    Console.WriteLine();

                    swapperWords = word1;
                    word1 = word2;
                    word2 = swapperWords;

                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t     >> SWAPPED WORDS");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t     >> FIRST WORDS   : " + word1);
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t     >> SECOND WORDS  : " + word2);

                }
                else if (choice.Equals("NUMBERS", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("2"))
                {
                    Console.Write("\t\t\t\t\t\t\t\t\t\t\t     >> ENTER FIRST NUMBERS   : ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\t\t\t\t\t\t\t\t\t\t\t     >> ENTER SECOND NUMBERS  : ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    swapperNum = num1;
                    num1 = num2;
                    num2 = swapperNum;

                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t     >> SWAPPED NUMBERS");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t     >> FIRST NUMBERS   : " + num1);
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t     >> SECOND NUMBERS  : " + num2);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    FON.sixteenth();
                    System.Threading.Thread.Sleep(1000);
                    goto start;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t\t\t\t\t >> DO YOU WANT TO USE SWAPPING FUNCTION AGAIN? PRESS (YES OR NO)  : ");
                swapAgain = Console.ReadLine();

                if (swapAgain == "")
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    FON.sixteenth();
                    System.Threading.Thread.Sleep(1000);   
                }
                else if (swapAgain.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || swapAgain.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                {
                    goto start;
                }
                else if (swapAgain.Equals("no", StringComparison.CurrentCultureIgnoreCase) || swapAgain.Equals("n", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >> THANK YOU!!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    FON.sixteenth();
                    System.Threading.Thread.Sleep(1000);
                    goto start;
                }


            //} while (swapAgain.Equals("") || swapAgain.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || swapAgain.Equals("y", StringComparison.CurrentCultureIgnoreCase));
        }
    }
}

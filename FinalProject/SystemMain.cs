using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class SystemMain
    {
        public string choice1 { get; set; }

        //class intances
        Credits c = new Credits();
        HighestNum hn = new HighestNum();
        fonts fents = new fonts();
        Swapping sw = new Swapping();
        MDAS md = new MDAS();
        LogInNSignUp log = new LogInNSignUp();
        public void menu()
        {
            //System main menu
            Console.Clear();
            fents.twenty();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t                                                                                      ____________________________________");
            Console.WriteLine("\t\t\t\t\t\t                                                                                     |                                    |");
            Console.WriteLine("\t\t\t\t\t\t                                                                                     |____________________________________|");
            Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|     CODE                   MENU                                      CODE          |                                    |");
            Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      1                   BASIC                                        1            |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      2                   INTERMEDIATE                                 2            |         PROF. ALKING SUNGA         |");
            Console.WriteLine("\t\t\t\t\t\t|      3                   ENTERTAINMENT                                3            |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      4                   CREDITS                                      4            |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      5                   EXIT                                         5            |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|____________________________________________________________________________________|____________________________________|");
            Console.WriteLine();
            Console.WriteLine();
        }
        public void basicMenu()
        {
            //For Basic menu
            Console.Clear();
            fents.twentyfour();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t                                                                                      ____________________________________");
            Console.WriteLine("\t\t\t\t\t\t                                                                                     |                                    |");
            Console.WriteLine("\t\t\t\t\t\t                                                                                     |____________________________________|");
            Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|     CODE                   MENU                                      CODE          |                                    |");
            Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      A                   SWAPPING                                     A            |         PROF. ALKING SUNGA         |");
            Console.WriteLine("\t\t\t\t\t\t|      B                   MDAS CALCULATOR                              B            |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      C                   HIGHEST NUMBER FINDER                        C            |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      D                   BACK                                         D            |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|____________________________________________________________________________________|____________________________________|");
            Console.WriteLine();
            Console.WriteLine();
        }
        public void intermediateMenu()
        {
            //For Intermediate menu
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            fents.thirtywo();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t                                                                                      ____________________________________");
            Console.WriteLine("\t\t\t\t\t\t                                                                                     |                                    |");
            Console.WriteLine("\t\t\t\t\t\t                                                                                     |____________________________________|");
            Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|     CODE                   MENU                                      CODE          |                                    |");
            Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      A                   STUDENT PROFILE                              A            |         PROF. ALKING SUNGA         |");
            Console.WriteLine("\t\t\t\t\t\t|      B                   GRADE CALCULATOR                             B            |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      C                   SALES TRANSACTION                            C            |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      D                   BACK                                         D            |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|____________________________________________________________________________________|____________________________________|");
            Console.WriteLine();
            Console.WriteLine();
        }
        public void entertainmentMenu()
        {
            //Entertainment menu
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            fents.thirtythree();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t                                                                                      ____________________________________");
            Console.WriteLine("\t\t\t\t\t\t                                                                                     |                                    |");
            Console.WriteLine("\t\t\t\t\t\t                                                                                     |____________________________________|");
            Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|     CODE                   MENU                                      CODE          |                                    |");
            Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      A                    GAME                                        A            |         PROF. ALKING SUNGA         |");
            Console.WriteLine("\t\t\t\t\t\t|      B                    CCS HANDBOOK                                B            |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      C                    BACK                                        C            |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|____________________________________________________________________________________|____________________________________|");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

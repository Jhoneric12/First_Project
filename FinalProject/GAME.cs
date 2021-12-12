using System;

using System.Threading;


namespace FinalProject
{

    class GAME
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int player = 1;

        static string ans;

        static int choice;

        static int flag = 0;

        fonts f = new fonts();

        intro myIntro = new intro();

        public void Game()
        {
            Console.Clear();
            myIntro.run();
            Console.ReadKey();
        start:
            try
            {
                do
                {
                    Console.Clear();
                    f.sixtyone();
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t      >>  Player1:X and Player2:O");
                    Console.WriteLine("");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t      >>  Choose and type the NUMBER you want");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t    to replace in the square and click enter.");
                    Console.WriteLine("\n");
                    if (player % 2 == 0)
                    {
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t      >>  Player 2 Chance");
                    }
                    else
                    {
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t      >>  Player 1 Chance");
                    }
                    Console.WriteLine("\n");
                    Board();
                    Console.WriteLine("\n\n");
                    Console.Write("\t\t\t\t\t\t\t\t\t\t      >>  CHOICE  :    ");
                    choice = int.Parse(Console.ReadLine());//Taking users choice
                    Console.WriteLine();

                    if (arr[choice] != 'X' && arr[choice] != 'O')
                    {
                        if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  
                        {
                            arr[choice] = 'O';
                            player++;
                        }
                        else
                        {
                            arr[choice] = 'X';
                            player++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t   >>  Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                        Console.WriteLine("\n");
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t   >>  Please wait 5 seconds board is loading again.....");
                        Thread.Sleep(5000);
                    }

                    flag = CheckWin();
                } while (flag != 1 && flag != -1);
            }
            catch (FormatException)
            {
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>   Invalid input. Please choose a number. \nPress any key to continue...");
                Console.ReadKey();
                goto start;
            }
            Console.Clear();
            if (flag == 1)
            {
                f.sixtyone();
                Console.WriteLine("\n\n\n");
                Board();
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>    Player {0} has won. Congratulations!", (player % 2) + 1);
            }
            else
            {

                f.sixtyone();
                Console.WriteLine("\n\n\n");
                Board();
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  Draw");
            }
            Console.WriteLine("\n\n\n");
            Console.Write("\t\t\t\t\t\t\t\t\t\t  >>   PRESS ANY KEY TO EXIT       ");
           

        }

        private static void Board()
        {

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t     |     |      ");

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t_____|_____|___ ");

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t     |     |      ");

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t_____|_____|___ ");

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t     |     |      ");

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t     |     |      ");

        }

        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }

        }

    }

}

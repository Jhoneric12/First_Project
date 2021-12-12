using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class HighestNum
    {
        //Global Variable
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double num3 { get; set; }
        public string choice { get; set; }


        fonts fs = new fonts();
        public void Highest_Number()
        {
          //  do
            //{
            start:
            try
            {
                Console.Clear();
                fs.twentyfive();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t\t\t\t\t\t  >> INPUT NUMBER  :    ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t\t\t\t\t\t  >> INPUT NUMBER  :    ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t\t\t\t\t\t  >> INPUT NUMBER  :    ");
                num3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                if (num1 == num2 )
                {
                    if (num1 == num3)
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
                        fs.fiftyone();
                        System.Threading.Thread.Sleep(1000);
                    }
                    else if (num2 == num3)
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
                        fs.fiftyone();
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                else if (num1 > num2)
                {
                    if (num1 > num3)
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
                        fs.twentysix();
                        System.Threading.Thread.Sleep(1000);
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
                        fs.twentyeight();
                        System.Threading.Thread.Sleep(1000);
                    }
                }

                else
                {
                    if (num2 > num3)
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
                        fs.twentyseven();
                        System.Threading.Thread.Sleep(1000);
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
                        fs.twentyeight();
                        System.Threading.Thread.Sleep(1000);
                    }
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t\t\t      >> DO YOU WANT TO USE HIGHEST NUMBER FINDER AGAIN?  PRESS (YES OR NO)  :  ");
                choice = Console.ReadLine();

                if (choice.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                {
                    goto start;
                }
                else if (choice.Equals("n", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("\t\t\t\t\t\t\t\t      >>  THANK YOU");
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
                    fs.sixteenth();
                    System.Threading.Thread.Sleep(1000);
                    goto start;
                }
            }
            catch (FormatException x)
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
                fs.seventeenth(); ;
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t >>  " + x.Message);
                System.Threading.Thread.Sleep(1000);
                goto start;
            }

            //} while (choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FinalProject
{
    class MDAS
    {
        //Global Variables
        public double num1 { get; set; }
        public double num2 { get; set; }
        public string operation { get; set; }
        public string cont { get; set; }
        public double total { get; set; }

        fonts F = new fonts();

        //MDAS Main menu
        public void welcomeMDAS()
        {
            F.fifth();
        }
        public void menuOperation()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t                                                                                      ____________________________________");
            Console.WriteLine("\t\t\t\t\t\t                                                                                     |                                    |");
            Console.WriteLine("\t\t\t\t\t\t                                                                                     |____________________________________|");
            Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|     CODE                           OPERATION                             CODE      |                                    |");
            Console.WriteLine("\t\t\t\t\t\t=====================================================================================|                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      +                            ADDITION                                +        |         PROF. ALKING SUNGA         |");
            Console.WriteLine("\t\t\t\t\t\t|      -                            SUBTRACTION                             -        |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      *                            MULTIPLICATION                          *        |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|      /                            DIVISION                                /        |                                    |");
            Console.WriteLine("\t\t\t\t\t\t|____________________________________________________________________________________|____________________________________|");
            Console.WriteLine();
        }

        //Creating Choices
        public void cOperation()
        {
        start:
            try
            {
               // do
               // {
                    Console.Clear();
                    welcomeMDAS();
                    menuOperation();
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t >> ENTER FIRST NUMBER  : ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\t\t\t\t\t\t\t\t\t\t >> ENTER OPERATOR      : ");
                    operation = Console.ReadLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t >> ENTER SECOND NUMBER : ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();

                    //Validating Choices
                    switch (operation)
                    {
                        case "+":
                            total = add(num1, num2);
                            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t >> " + num1 + " + " + num2 + " = " + total);
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t >> THE SUM IS " + total);
                            break;
                        case "-":
                            total = subtract(num1, num2);
                            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t >> " + num1 + " - " + num2 + " = " + total);
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t >> THE DIFFERENCE IS " + total);
                            break;
                        case "*":
                            total = multiply(num1, num2);
                            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t >>" + num1 + " x " + num2 + " = " + total);
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t >> THE PRODUCT IS " + total);
                            break;
                        case "/":
                            total = divide(num1, num2);
                            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t >>" + num1 + " / " + num2 + " = " + total);
                            Console.WriteLine();
                            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t >> THE QOUTIENT IS " + total);
                            break;
                        default:
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
                            F.fifteenth();
                            System.Threading.Thread.Sleep(2000);
                            goto start;
                    }

                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t >> DO YOU WANT TO CALCULATE AGAIN? PRESS (YES OR NO)  : ");
                    cont = Console.ReadLine();

                    if (cont == "")
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
                        F.sixteenth();
                        System.Threading.Thread.Sleep(2000);
                    }
                    else if (cont.Equals("y", StringComparison.CurrentCultureIgnoreCase) || cont.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                    {
                        goto start;
                    }
                    else if (cont.Equals("n", StringComparison.CurrentCultureIgnoreCase) || cont.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t >> THANK YOU!!");
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
                        F.sixteenth();
                        System.Threading.Thread.Sleep(2000);
                        goto start;
                    }

                //} while (cont.Equals("") || cont.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || cont.Equals("Y", StringComparison.CurrentCultureIgnoreCase));
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
                F.seventeenth(); ;
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t >>  " + x.Message);
                System.Threading.Thread.Sleep(2000);
                goto start;
            }
            catch (DivideByZeroException G)
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
                F.sixteenth();
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t" + G);
                System.Threading.Thread.Sleep(2000);
                goto start;
            }
        }


        // Functions
        static double add(double a, double b)
        {
            return a + b;
        }

        static double subtract(double a, double b)
        {
            return a - b;
        }
        static double multiply(double a, double b)
        {
            return a * b;
        }
        static double divide(double a, double b)
        {
            return a / b;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class SalesTransaction
    {
        public string choice { get; set; }
        public double productPrice { get; set; }
        public double discountPrice { get; set; }

        fonts f = new fonts();

        public void salesMenu()
        {
        start:
            try
            {
                //do
               // {
                    Console.Clear();
                    f.thirty();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t                                                                                      ________________________________________________________ ");
                    Console.WriteLine("\t\t\t\t\t                                                                                     |    CODE               DISCOUNT COUPON                  |");
                    Console.WriteLine("\t\t\t\t\t                                                                                     |________________________________________________________|");
                    Console.WriteLine("\t\t\t\t\t=====================================================================================|     0               NASA STAFF - 50% OFF               |");
                    Console.WriteLine("\t\t\t\t\t|     CODE                   MENU                                       PRICE        |                                                        |");
                    Console.WriteLine("\t\t\t\t\t=====================================================================================|     1               SENIOR ALIEN - 20% OFF             |");
                    Console.WriteLine("\t\t\t\t\t|      0                   SPACES SHIP                                $100.000       |                                                        |");
                    Console.WriteLine("\t\t\t\t\t|      1                   SPACE SUIT                                 $10.000        |     2               ALIEN WITH DISABILITY - 60% OFF    |");
                    Console.WriteLine("\t\t\t\t\t|      2                   ALIEN PET                                  $1000          |                                                        |");
                    Console.WriteLine("\t\t\t\t\t|                                                                                    |     3               NORMAL CITIZEN - 1% OFF            |");
                    Console.WriteLine("\t\t\t\t\t|____________________________________________________________________________________|________________________________________________________|");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    int maxOrder = 1;
                    string[] productName = { "SPACE SHIP", "SPACE SUIT", "ALIEN PET" };
                    string[] discoutnName = { "NASA STAFF - 50% OFF", "SENIOR ALIEN - 20% OFF", "ALIEN WITH DISABILITY - 60% OFF", "NORMAL CITIZEN - 1% OFF" };
                    double[] productPrice = { 100000, 10000, 1000 };
                    double[] discountCoupon = { 0.5, 0.2, 0.6, 0.01 };
                    int[] order = new int[maxOrder];
                    int[] quantity = new int[maxOrder];
                    int[] discount = new int[maxOrder];
                    double[] tPrice = new double[maxOrder];
                    double[] gPrice = new double[maxOrder];
                    double[] change = new double[maxOrder];
                    double[] cash = new double[maxOrder];
                    double[] calDisc = new double[maxOrder];
                    double[] totalSum = new double[maxOrder];



                    for (int i = 0; i < order.Length; i++)
                    {
                        Console.Beep();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t__________________________________________");
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t   ORDER  ");
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t__________________________________________");
                        Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  ENTER ORDER CODE             :    ");
                        order[i] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (order[i] > 2)
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
                            f.seventeenth();
                            System.Threading.Thread.Sleep(1000);
                            salesMenu();
                        }

                        Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  HOW MANY                     :    ");
                        quantity[i] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  ENTER DISCOUNT COUPON CODE   :    ");
                        discount[i] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (discount[i] > 3)
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
                            f.seventeenth();
                            System.Threading.Thread.Sleep(1000);
                            salesMenu();
                        }
                        Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  ENTER CASH                   :    ");
                        cash[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        tPrice[i] = productPrice[order[i]] * quantity[i];
                        calDisc[i] = tPrice[i] * discountCoupon[discount[i]];
                        gPrice[i] = tPrice[i] - calDisc[i];
                        change[i] = cash[i] - gPrice[i];
                        totalSum[i] = totalSum[i] + gPrice[i];

                        if (cash[i] < gPrice[i])
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
                            f.thirtfive();
                            System.Threading.Thread.Sleep(1000);
                            salesMenu();
                        }
                    }

                    Console.Clear();

                    for (int i = 0; i < order.Length; i++)
                    {
                        Console.Beep();
                        f.fiftyfour();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();  
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t                                       "             );
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t********************************************************");
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t   ORDER             :    " + productName[order[i]]);
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t   PRODUCT PRICE     :    " + "$ " + productPrice[order[i]] );
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t   PRODUCT QUANTITY  :    " + quantity[i] + " PIECE(S)");
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t   DISCOUNT COUPON   :    " + discoutnName[order[i]] + " COUPON");
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t   TOTAL AMOUNT      :    " + "$ " + tPrice[i]);
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t   DISCOUNT          :    " + "$ " + calDisc[i]);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t   GRAND TOTAL       :    " + "$ " + gPrice[i]);
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t   CASH PAYMENT      :    " + "$ " + cash[i]);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t*********************************************************");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t   CHANGE            :    " + "$ " + change[i]);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t____________________________________________________");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t >> DO  YOU WANT TO ORDER AGAIN? PRESS (YES OR NO)   :  ");
                    choice = Console.ReadLine();

                    if (choice.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                    {
                        goto start;
                    }
                    else if (choice.Equals("n", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("no", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t >>  THANK YOU!!");
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
                        f.sixteenth();
                        System.Threading.Thread.Sleep(1000);
                        goto start;
                    }


               // } while (choice.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase));
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
                f.seventeenth();
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  " + x.Message);
                System.Threading.Thread.Sleep(1000);
                salesMenu();
 
            }
        }
    }
}

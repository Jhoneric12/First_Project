using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class GradeComputation
    {
        public string choice { get; set; }
        public string rem { get; set; }
        public string rem1 { get; set; }

        fonts fn = new fonts();
        public void computeGrade()
        {
            try
            {
            start:
                // do
                //  {
                    int maximum = 2;
                    int i;
                    string[] stfName = new string[maximum];
                    string[] stmName = new string[maximum];
                    string[] stlName = new string[maximum];
                    string[] subject = new string[maximum];
                    string[] studentId = new string[maximum];
                    string[] course = new string[maximum];
                    string[] yrNsec = new string[maximum];
                    double[] prelimMath = new double[maximum];
                    double[] prelimPc = new double[maximum];
                    double[] prelimFil = new double[maximum];
                    double[] prelimSelf = new double[maximum];
                    double[] prelimComprog = new double[maximum];
                    double[] midtermMath = new double[maximum];
                    double[] midtermPc = new double[maximum];
                    double[] midtermFil = new double[maximum];
                    double[] midtermSelf = new double[maximum];
                    double[] midtermComprog = new double[maximum];
                    double[] finalMath = new double[maximum];
                    double[] finalPc = new double[maximum];
                    double[] finalFil = new double[maximum];
                    double[] finalSelf = new double[maximum];
                    double[] finalComprog = new double[maximum];
                    double[] prelim = new double[maximum];
                    double[] midterm = new double[maximum];
                    double[] finals = new double[maximum];
                    double[] aver = new double[maximum];
                    string[] remarks = new string[maximum];

                    for (i = 0; i < stfName.Length; i++)
                    {
                        Console.Clear();
                        fn.thiryone();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t _________________________________________________________________________");
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t                               STUDENT'S GRADE  # " + (i+1));
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t _________________________________________________________________________");
                        Console.WriteLine();  
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> ENTER FIRST NAME                         :    ");
                        stfName[i] = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> ENTER MIDDLE NAME                        :    ");
                        stmName[i] = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> ENTER LAST NAME                          :    ");
                        stlName[i] = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> ENTER STUDENT ID NUMBER                  :    ");
                        studentId[i] = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> ENTER COURSE                             :    ");
                        course[i] = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> ENTER YEAR AND SECTION                   :    ");
                        yrNsec[i] = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> PRELIM MATHEMATICS GRADE                 :    ");
                        prelimMath[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> PRELIM PURPOSIVE COMMUNICATION GRADE     :    ");
                        prelimPc[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> PRELIM FILIPINO 1 GRADE                  :    ");
                        prelimFil[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> PRELIM UNDERSTANING SELF GRADE           :    ");
                        prelimSelf[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> PRELIM COMPUTER PROGRAMMING GRADE        :    ");
                        prelimComprog[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> MIDTERM MATHEMATICS GRADE                :    ");
                        midtermMath[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> MIDTERM PURPOSIVE COMMUNICATION GRADE    :    ");
                        midtermPc[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> MIDTERM FILIPINO 1 GRADE                 :    ");
                        midtermFil[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> MIDTERM UNDERSTANING SELF GRADE          :    ");
                        midtermSelf[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> MIDTERM COMPUTER PROGRAMMING GRADE       :    ");
                        midtermComprog[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> FINALS MATHEMATICS GRADE                 :    ");
                        finalMath[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> FINALS PURPOSIVE COMMUNICATION GRADE     :    ");
                        finalPc[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> FINALS FILIPINO 1 GRADE                  :    ");
                        finalFil[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> FINALS UNDERSTANING SELF GRADE           :    ");
                        finalSelf[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >> FINALS COMPUTER PROGRAMMING GRADE        :    ");
                        finalComprog[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        prelim[i] = (prelimMath[i] + prelimPc[i] + prelimFil[i] + prelimSelf[i] + prelimComprog[i]) / 5;
                        midterm[i] = (midtermMath[i] + midtermPc[i] + midtermFil[i] + midtermSelf[i] + midtermComprog[i]) / 5;
                        finals[i] = (finalMath[i] + finalPc[i] + finalFil[i] + finalSelf[i] + finalComprog[i]) / 5;
                        aver[i] = (prelim[i] + midterm[i] + finals[i]) / 3;

                        if (aver[i] > 5)
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
                            Console.WriteLine();
                            fn.fiftytwo();
                            System.Threading.Thread.Sleep(1000);
                            goto start;
                        }




                        if (aver[i] < 3.0)
                        {
                            
                            remarks[i] =  "YOU PASSED THIS SEMESTER";
                        }
                        else
                        {
                            
                            remarks[i] = "YOU FAILED THIS SEMESTER";
                        }

                    }
                    Console.Clear();

                    for (i = 0; i < stfName.Length; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t_________________________________________________________________________");
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t  >>                          ID NUMBER         :    " + studentId[i]);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t_________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t  >> FULL NAME          :    " + stlName[i].ToUpper() + ", " + stfName[i].ToUpper() + " " + stmName[i].ToUpper());
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t  >> COURSE             :    " + course[i].ToUpper());
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t  >> YEAR AND SECTION   :    " + yrNsec[i]);
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t  >> PRELIM GRADE       :    " + prelim[i]);
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t  >> MIDTERM GRADE      :    " + midterm[i]);
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t  >> FINALS GRADE       :    " + finals[i]);
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t  >> SEMESTER AVERAGE   :    " + (aver[i]));
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t  >> REMARKS            :    " + remarks[i]);
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t ________________________________________________________________________");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t  >> DO YOU WANT TO USE STUDENT GRADE CALCULATOR AGAIN? PRESS (YES OR NO)  :    ");
                    choice = Console.ReadLine();

                    if (choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                    {
                        goto start;
                    }
                    else if (choice.Equals("no", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("n", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  THANK YOU!!");
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
                        fn.sixteenth();
                        System.Threading.Thread.Sleep(1000);
                        goto start;
                    }

               // } while (choice.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase));
            }
            catch (FormatException f)
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
                fn.seventeenth();
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >> " + f.Message);
                System.Threading.Thread.Sleep(1000);
                computeGrade();
            }
        }
    }
}

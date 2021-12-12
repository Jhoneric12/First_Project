using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class StudentProfile
    {
        public string choice { get; set; }

        fonts f = new fonts();

        public void studentData()
        {
        start:
            try
            {
                //do
               // {
                int maxLength = 2;
                int i;
                string[] fName = new string[maxLength];
                string[] mName = new string[maxLength];
                string[] lName = new string[maxLength];
                string[] stId = new string[maxLength];
                string[] course = new string[maxLength];
                string[] yearNSec = new string[maxLength];
                int[] age = new int[maxLength];
                string[] address = new string[maxLength];
                string[] school = new string[maxLength];
                string[] guardian = new string[maxLength];
                long[] contactNum = new long[maxLength];
                string[] emailAdd = new string[maxLength]; 

                for (i = 0; i < stId.Length; i++)
                {
                    Console.Clear();
                    f.twentynine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t ________________________________________________");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t                   STUDENT DATA # " + (i +1));
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t ________________________________________________");
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t  >> ENTER STUDENT ID NUMBER    :    ");
                    stId[i] = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t  >> ENTER FIRST NAME           :    ");
                    fName[i] = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t  >> ENTER MIDDLE NAME          :    ");
                    mName[i] = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t  >> ENTER LAST NAME            :    ");
                    lName[i] = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t  >> ENTER AGE                  :    ");
                    age[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t  >> ENTER COURSE               :    ");
                    course[i] = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t  >> ENTER YEAR AND SECTION     :    ");
                    yearNSec[i] = Console.ReadLine(); ;
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t  >> ENTER ADDRESS              :    ");
                    address[i] = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t  >> ENTER YOUR SCHOOL          :    ");
                    school[i] = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t  >> ENTER YOUR GUARDIAN NAME   :    ");
                    guardian[i] = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t  >> ENTER CONTACT NUMBER       :    ");
                    contactNum[i] = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t  >> ENTER EMAIL ADDRESS        :    ");
                    emailAdd[i] = Console.ReadLine();
                }

                Console.Clear();

                for (i = 0; i < stId.Length; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine();            
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t____________________________________________________________________");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>    STUDENT ID NUMBER         :    " + stId[i]);
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t____________________________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >> STUDENT'S FIRST NAME         :    " + fName[i].ToUpper());
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >> STUDENT'S MIDDLE NAME        :    " + mName[i].ToUpper());
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >> STUDENT'S LAST NAME          :    " + lName[i].ToUpper());
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >> STUDENT'S AGE                :    " + age[i]);
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >> STUDENT'S COURSE             :    " + course[i].ToUpper());
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >> STUDENT'S YEAR AND SECTION   :    " + yearNSec[i]);
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >> STUDENT'S ADDRESS            :    " + address[i].ToUpper());
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >> STUDENT'S SCHOOL             :    " + school[i].ToUpper());
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >> STUDENT'S GUARDIAN NAME      :    " + guardian[i].ToUpper());
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >> STUDENT'S CONTACT NUMBER     :    " + contactNum[i]);
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >> STUDENT'S EMAIL ADDRESS      :    " + emailAdd[i]);
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t____________________________________________________________________");
                    Console.WriteLine();
                }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("\t\t\t\t\t\t\t\t\t\t  >> DO YOU WANT TO USE STUDENT PROFILE AGAIN? PRESS (YES OR NO)   :    ");
                    choice = Console.ReadLine();

                if (choice == "")
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
                    f.sixteenth();
                    System.Threading.Thread.Sleep(1000);
                }
                else if (choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("y", StringComparison.CurrentCultureIgnoreCase))
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
                    f.sixteenth();
                    System.Threading.Thread.Sleep(1000);
                    goto start;
                }
              //  } while(choice.Equals("") || choice.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice.Equals("yes", StringComparison.CurrentCultureIgnoreCase));

            }
            catch (FormatException FX)
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
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t" + FX.Message);
                System.Threading.Thread.Sleep(2000);
                studentData();
            }
             
        }
    }
}

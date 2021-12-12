using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class LogInNSignUp
    {
        //Global variables
        public string fName {get; set;}
        public string mName {get; set;}
        public string lName {get; set;}
        public string birth { get; set; }
        public string age   {get; set;}
        public string sex   { get; set; }
        public int index    { get; set; }
        public string pass  { get; set; }
        public string pass1 { get; set; }
        public string pass2 { get; set; }
        public int doubleWord { get; set; }

        // Arrays for usernames
        string[] userNames = {"user23@galactech.com", "hiuser123@galactech.com", "wtfisthat@galactech.com",
                                    "iLoverestaurant@galactech.com", "EatHappygalactech.com", "TheHotDish@galactech.com",
                                    "PackagedPantry@galactech.com",  "DeliciousFoodiePix@galactech.com", "DelightfulVegan@galactech.com",
                                    "SweetSaltLive@galactech.com", "DelishDelights@galactech.com"};

        fonts F = new fonts();
        //Obtaining user's names
        public void signUp()
        {
            do
            {
                Console.Clear();
                F.first();

                Console.WriteLine( );
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t\t\t\t           >>  ENTER FIRST NAME    :    ");
                fName = Console.ReadLine();                
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t\t\t\t           >>  ENTER MIDDLE NAME   :    ");
                mName = Console.ReadLine();
                if (mName.Contains(" "))
                {
                    
                }
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t\t\t\t           >>  ENTER LAST NAME     :    ");
                lName = Console.ReadLine();

                Console.WriteLine();
                
                //Validating the names entered by users
                if (fName == "" || mName == "" || lName == "")
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
                    F.eighteenth();
                    System.Threading.Thread.Sleep(1000);
                }
            } while (fName == "" || mName == "" || lName == "");
        }

        // Selecting usernames
        public void makingUser()
        {
            try
            {
                do
                {
                    Console.Clear();
                    F.first();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  CHOOSE YOUR WANTED USERNAME BELOW");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  0.  user23@galactech.com");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  1.  hiuser12@galactech.com");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  2.  ilovemekdonalds@galactech.com");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  3.  iLoverestaurant@galactech.com");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  4.  EatHappy@galactech.com");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  5.  TheHotDish@galactech.com");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  6.  PackagedPantry@galactech.com");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  7.  DeliciousFoodiePix@galactech.com");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  8.  DelightfulVegan@galactech.com");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  9.  SweetSaltLive@galactech.com");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  10. DelishDelights@galactech.com");
                    Console.WriteLine();

                    Console.Write("\t\t\t\t\t\t\t\t\t\t >>  NUMBER : ");
                    index = Convert.ToInt32(Console.ReadLine());

                    if (index > 10 || index.Equals(""))
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
                        System.Threading.Thread.Sleep(1000);
                    }
                } while (index > 10);
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
                F.sixteenth();
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t" + f.Message);
                System.Threading.Thread.Sleep(1000);
                makingUser();
            }
        }

        // Creating a passwords
        public void makingPass()
        {
            do
            {
                Console.Clear();
                F.first();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t\t\t\t\t   >>  MAKE PASSWORD        :     ");
                pass = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t\t\t\t\t   >>  RE - ENTER PASSWORD  :     ");
                pass1 = Console.ReadLine();
                Console.WriteLine();

                // Validating the passwords entered by users
             
                if (pass == "" || pass1 == "")
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
                    F.seventeenth();
                    System.Threading.Thread.Sleep(1000);
                }
                else if (pass.Length < 8 || pass1.Length < 8)
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
                     F.twentytwo();
                     System.Threading.Thread.Sleep(1000);
                     makingPass();
                 }
                 else if (pass != pass1)
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
                     F.ninth();
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
                     F.tenth();
                     System.Threading.Thread.Sleep(1000);
                 }
            } while (pass1 != pass || pass == "" || pass1 == "");
        }

        //Log In
        public void logIn()
        {
            int counter = 0;
            do
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
                F.third();
                doubleWord = mName.IndexOf(" ") + 1;
                Console.WriteLine();
                Console.WriteLine();
                if (mName.Contains(" "))
                {
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t          GOOD DAY " + fName.ToUpper() + " " + mName.ToUpper()[0] + "." + mName.ToUpper()[doubleWord] + ". " + lName.ToUpper());
                }
                else
                {
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t          GOOD DAY " + fName.ToUpper() + " " + mName.ToUpper()[0] + ". " + lName.ToUpper());
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t >>  USERNAME   : " + userNames[index]);
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\t\t\t\t\t >>  PASSWORD   :  ");
                pass2 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                if (pass2 == pass1)
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
                    F.sixty();

                    break;
                }
                else
                {
                    counter++;
                    if (counter == 3)
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
                        F.seventh();
                        System.Threading.Thread.Sleep(3000);
                        System.Environment.Exit(0); 
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
                        F.eighth();
                        System.Threading.Thread.Sleep(1000);
                    }
                }

            } while (counter < 3);
        }     
    }
}

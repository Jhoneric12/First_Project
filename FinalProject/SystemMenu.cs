using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace FinalProject
{
    class SystemMenu
    {
        public string choice   { get; set; }
        public string choice1  { get; set; }
        public string choice2  { get; set; }
        public string choice3  { get; set; }
        public string choice4  { get; set; }
        public string choice5  { get; set; }
        public string choice6  { get; set; }
        public string choice7  { get; set; }
        public string choice8  { get; set; }
        public string choice9  { get; set; }
        public string choice10 { get; set; }
        public string choice11 { get; set; }
        public string choice12 { get; set; }

        public void galactechSystem()
        {
            //Program p = new Program();
            Opening op = new Opening();
            HighestNum hn = new HighestNum();
            fonts fents = new fonts();
            MDAS md = new MDAS();
            GAME g = new GAME();
            Swapping sw = new Swapping();
            SystemMain sm = new SystemMain();
            LogInNSignUp ls = new LogInNSignUp();
            StudentProfile sp = new StudentProfile();
            GradeComputation gc = new GradeComputation();
            SalesTransaction st = new SalesTransaction();
            Credits c = new Credits();
            Freestyle fl = new Freestyle();
            SoundPlayer sound = new SoundPlayer(soundLocation: @"C:\Users\Karl\Desktop\C#_Aton\FinalProject\FinalProject\bin\Debug\Star Wars Main Theme (Full).wav");
            SoundPlayer sound1 = new SoundPlayer(soundLocation: @"C:\Users\Karl\Desktop\C#_Aton\FinalProject\FinalProject\bin\Debug\Itachi Uchiha - Amaterasu Sound Effect.wav");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            try
            {
                
                    // OPENING 
                    sound1.Play();
                    op.loading();
                    sound.Play();
                    // CREATING AND LOG IN ACCOUNT
                    ls.signUp();
                    ls.makingUser();
                    ls.makingPass();
                    ls.logIn();

                //do
                //{
                start:
                    // SYSTEM MAIN MENU
                    sm.menu();
                    Console.Write("\t\t\t\t\t\t\t\t\t  >>  ENTER CODE    :    ");
                    choice = Console.ReadLine();
                    
                    if (choice.Equals("1") || choice.Equals("basic", StringComparison.CurrentCultureIgnoreCase))
                    {
                    found1:
                        sm.basicMenu();
                        Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  ENTER CODE    :    ");
                        choice1 = Console.ReadLine();
                        if (choice1.Equals("a", StringComparison.CurrentCultureIgnoreCase) || choice1.Equals("swapping", StringComparison.CurrentCultureIgnoreCase))
                        {
                        found2:
                            // SWAPPING
                            sw.swap();
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
                            fents.thirtysix();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  TO BACK, PRESS YES AND TO EXIT, PRESS NO    :    ");
                            choice2 = Console.ReadLine();
                            if (choice2.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice2.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.Clear();
                                fents.sixty();
                                goto start;
                            }
                            else if (choice2.Equals("no", StringComparison.CurrentCultureIgnoreCase) || choice2.Equals("n", StringComparison.CurrentCultureIgnoreCase))
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
                                fents.fifty();
                                Console.Write("\t\t\t\t\t\t\t\t\t\t\t  >>  PRESS ANY KEY TO EXIT");
                                Console.ReadKey();
                                System.Environment.Exit(0);
                                goto found2;
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
                                fents.sixteenth();
                                System.Threading.Thread.Sleep(1000);
                                goto found2;
                            }
                        }
                        else if (choice1.Equals("b", StringComparison.CurrentCultureIgnoreCase) || choice1.Equals("mdas calculator", StringComparison.CurrentCultureIgnoreCase))
                        {
                        found3:
                            // MDAS
                            md.cOperation();
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
                            fents.thirtysix();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  TO BACK, PRESS YES AND TO EXIT, PRESS NO    :    ");
                            choice3 = Console.ReadLine();
                            if (choice3.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice3.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.Clear();
                                fents.sixty();
                                goto start;
                            }
                            else if (choice3.Equals("no", StringComparison.CurrentCultureIgnoreCase) || choice3.Equals("n", StringComparison.CurrentCultureIgnoreCase))
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
                                fents.fifty();
                                Console.Write("\t\t\t\t\t\t\t\t\t\t\t  >>  PRESS ANY KEY TO EXIT");
                                Console.ReadKey();
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
                                fents.sixteenth();
                                System.Threading.Thread.Sleep(1000);
                                goto found3;
                            }
                        }
                        else if (choice1.Equals("c", StringComparison.CurrentCultureIgnoreCase) || choice1.Equals("highest number finder", StringComparison.CurrentCultureIgnoreCase))
                        {
                        found4:
                            // HIGHEST NUMBERS
                            hn.Highest_Number();
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
                            fents.thirtysix();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  TO BACK, PRESS YES AND TO EXIT, PRESS NO    :    ");
                            choice4 = Console.ReadLine();
                            if (choice4.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice4.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.Clear();
                                fents.sixty();
                                goto start;
                            }
                            else if (choice4.Equals("no", StringComparison.CurrentCultureIgnoreCase) || choice4.Equals("n", StringComparison.CurrentCultureIgnoreCase))
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
                                fents.fifty();
                                Console.Write("\t\t\t\t\t\t\t\t\t\t\t  >>  PRESS ANY KEY TO EXIT");
                                Console.ReadKey();
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
                                fents.sixteenth();
                                System.Threading.Thread.Sleep(1000);
                                goto found4;
                            }
                        }
                        else if (choice1.Equals("d", StringComparison.CurrentCultureIgnoreCase) || choice1.Equals("back", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.Clear();
                            fents.sixty();
                            goto start;
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
                            fents.sixteenth();
                            System.Threading.Thread.Sleep(1000);
                            goto found1;
                        }
                    }
                    else if (choice.Equals("2") || choice.Equals("intermediate", StringComparison.CurrentCultureIgnoreCase))
                    {
                    found:
                        // FOR INTERMEDIATE MENU
                        sm.intermediateMenu();
                        Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  ENTER CODE    :    ");
                        choice5 = Console.ReadLine();
                        if (choice5.Equals("a", StringComparison.CurrentCultureIgnoreCase) || choice5.Equals("student profile", StringComparison.CurrentCultureIgnoreCase))
                        {
                        found5:
                            // STUDENT PROFILE
                            sp.studentData();
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
                            fents.thirtysix();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  TO BACK, PRESS YES AND TO EXIT, PRESS NO    :    ");
                            choice6 = Console.ReadLine();
                            if (choice6.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice6.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.Clear();
                                fents.sixty();
                                goto start;
                            }
                            else if (choice6.Equals("no", StringComparison.CurrentCultureIgnoreCase) || choice6.Equals("n", StringComparison.CurrentCultureIgnoreCase))
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
                                fents.fifty();
                                Console.Write("\t\t\t\t\t\t\t\t\t\t\t  >>  PRESS ANY KEY TO EXIT");
                                Console.ReadKey();
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
                                fents.sixteenth();
                                System.Threading.Thread.Sleep(1000);
                                goto found5;
                            }
                        }
                        else if (choice5.Equals("b", StringComparison.CurrentCultureIgnoreCase) || choice5.Equals("grade calculator", StringComparison.CurrentCultureIgnoreCase))
                        {
                        found6:
                            //GRADE COMPUTATION
                            gc.computeGrade();
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
                            fents.thirtysix();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  TO BACK, PRESS YES AND TO EXIT, PRESS NO    :    ");
                            choice7 = Console.ReadLine();
                            if (choice7.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice7.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.Clear();
                                fents.sixty();
                                goto start;
                            }
                            else if (choice7.Equals("no", StringComparison.CurrentCultureIgnoreCase) || choice7.Equals("n", StringComparison.CurrentCultureIgnoreCase))
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
                                fents.fifty();
                                Console.Write("\t\t\t\t\t\t\t\t\t\t\t  >>  PRESS ANY KEY TO EXIT");
                                Console.ReadKey();
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
                                fents.sixteenth();
                                System.Threading.Thread.Sleep(1000);
                                goto found6;
                            }

                        }
                        else if (choice5.Equals("c", StringComparison.CurrentCultureIgnoreCase) || choice5.Equals("sales transaction", StringComparison.CurrentCultureIgnoreCase))
                        {
                        found7:
                            // SALES TRANSACTION
                            st.salesMenu();
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
                            fents.thirtysix();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  TO BACK, PRESS YES AND TO EXIT, PRESS NO    :    ");
                            choice8 = Console.ReadLine();
                            if (choice8.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice8.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.Clear();
                                fents.sixty();
                                goto start;
                            }
                            else if (choice8.Equals("no", StringComparison.CurrentCultureIgnoreCase) || choice8.Equals("n", StringComparison.CurrentCultureIgnoreCase))
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
                                fents.fifty();
                                Console.Write("\t\t\t\t\t\t\t\t\t\t\t  >>  PRESS ANY KEY TO EXIT");
                                Console.ReadKey();
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
                                fents.sixteenth();
                                System.Threading.Thread.Sleep(1000);
                                goto found7;   
                            }
                        }
                        else if (choice5.Equals("d", StringComparison.CurrentCultureIgnoreCase) || choice5.Equals("back", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.Clear();
                            fents.sixty();
                            goto start;
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
                            fents.sixteenth();
                            System.Threading.Thread.Sleep(1000);
                            goto found;
                        }
                    }
                    else if (choice.Equals("3") || choice.Equals("entertainment", StringComparison.CurrentCultureIgnoreCase))
                    {
                    found11:
                        // FOR ENTERTAINMENT MENU
                        sm.entertainmentMenu();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t  >>  ENTER CODE    :    ");
                        choice9 = Console.ReadLine();
                        if (choice9.Equals("a", StringComparison.CurrentCultureIgnoreCase) || choice9.Equals("game", StringComparison.CurrentCultureIgnoreCase))
                        {
                        found8:
                            //GAME
                            g.Game();
                            Console.ReadKey();
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
                            fents.thirtysix();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  TO BACK, PRESS YES AND TO EXIT, PRESS NO    :    ");
                            choice10 = Console.ReadLine();
                            if (choice10.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice10.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.Clear();
                                fents.sixty();
                                goto start;
                            }
                            else if (choice10.Equals("no", StringComparison.CurrentCultureIgnoreCase) || choice10.Equals("n", StringComparison.CurrentCultureIgnoreCase))
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
                                fents.fifty();
                                Console.Write("\t\t\t\t\t\t\t\t\t\t\t  >>  PRESS ANY KEY TO EXIT");
                                Console.ReadKey();
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
                                fents.sixteenth();
                                System.Threading.Thread.Sleep(1000);
                                goto found8;   
                            }
                        }
                        else if (choice9.Equals("b", StringComparison.CurrentCultureIgnoreCase) || choice9.Equals("ccs handbook", StringComparison.CurrentCultureIgnoreCase))
                        {
                        found9:
                            //FREESTYLE
                            Console.Clear();
                            fl.galactechApp();
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
                            fents.thirtysix();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  TO BACK, PRESS YES AND TO EXIT, PRESS NO    :    ");
                            choice11 = Console.ReadLine();
                            if (choice11.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice11.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                            {
                                Console.Clear();
                                fents.sixty();
                                goto start;
                            }
                            else if (choice11.Equals("no", StringComparison.CurrentCultureIgnoreCase) || choice11.Equals("n", StringComparison.CurrentCultureIgnoreCase))
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
                                fents.fifty();
                                Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  PRESS ANY KEY TO EXIT    :    ");
                                Console.ReadKey();
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
                                fents.sixteenth();
                                System.Threading.Thread.Sleep(1000);
                                goto found9;
                            }
                        }
                        else if (choice9.Equals("c", StringComparison.CurrentCultureIgnoreCase) || choice9.Equals("back", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.Clear();
                            fents.sixty();
                            goto start;
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
                            fents.sixteenth();
                            System.Threading.Thread.Sleep(1000);
                            goto found11;
                        }
                    }
                    else if (choice.Equals("4") || choice.Equals("credits", StringComparison.CurrentCultureIgnoreCase))
                    {
                    found10:
                        //CREDITS
                        Console.Clear();
                        c.showCredits();
                        Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  PRESS ANY KEY TO EXIT");
                        Console.ReadKey();
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
                        fents.thirtysix();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("\t\t\t\t\t\t\t\t\t\t  >>  TO BACK, PRESS YES AND TO EXIT, PRESS NO    :    ");
                        choice12 = Console.ReadLine();
                        if (choice12.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice12.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.Clear();
                            fents.sixty();
                            goto start;
                        }
                        else if (choice12.Equals("no", StringComparison.CurrentCultureIgnoreCase) || choice12.Equals("n", StringComparison.CurrentCultureIgnoreCase))
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
                            fents.fifty();
                            Console.Write("\t\t\t\t\t\t\t\t\t\t\t  >>  PRESS ANY KEY TO EXIT");
                            Console.ReadKey();
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
                            fents.sixteenth();
                            System.Threading.Thread.Sleep(1000);
                            goto found10;
                        }
                    }
                    else if (choice.Equals("5") || choice.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
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
                        fents.fifty();
                        Console.Write("\t\t\t\t\t\t\t\t\t\t\t  >>  PRESS ANY KEY TO EXIT");
                        Console.ReadKey();
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
                        fents.sixteenth();
                        System.Threading.Thread.Sleep(1000);
                        goto start;
                    }
                //} while (choice2.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice2.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice3.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice3.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice4.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice4.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice6.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice6.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice7.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice7.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice8.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice8.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice10.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice10.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice11.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice11.Equals("yes", StringComparison.CurrentCultureIgnoreCase) || choice12.Equals("y", StringComparison.CurrentCultureIgnoreCase) || choice12.Equals("yes", StringComparison.CurrentCultureIgnoreCase));
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
                fents.seventeenth();
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  >>  " + x.Message);
                System.Threading.Thread.Sleep(1000);
                galactechSystem();
            }
        }
    }
}

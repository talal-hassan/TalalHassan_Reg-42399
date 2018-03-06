using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    

    
   
    public class Display
    {
        public void MainScreen()
        {
            //Changing Console colors
            Console.Title = "Student Profile";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();    // For implementing colors for whole of the console screen
                                //Console.WriteLine("\nThis is my first console application in C#");

            //Welcome Screen
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            Console.Write("--------------------------------------------------------------------------------");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("-%%%%%%%%%%%%%%%                STUDNET  PROFILE                %%%%%%%%%%%%%%%-");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("-%%%%     (L)og In    %%    (S)ign Up    %%    (H)elp    %%    (E)xit      %%%%-");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("--------------------------------------------------------------------------------");
            Console.Write("                   Username : admin         Password: admin                     ");
        }
        public void LogIN()
        {
            
            Console.Write("--------------------------------------------------------------------------------");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("-%%%%%%%%%%%%%%%                STUDNET  PROFILE                %%%%%%%%%%%%%%%-");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("-%%%% (C)reate %% (D)elete %% (S)earch %% (A)ttendence %% (V)iew %% (E)xit %%%%-");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("--------------------------------------------------------------------------------");
        }
    }

   

    class Program
    {
        static void Main(string[] args)
        {
 
            //string path1;           
            //path1 = args[0];
            //  Console.Write(path1);
            
                Display display = new Display();
                display.MainScreen();

            //string path = path1;
            string path = @"StudentProfile.txt";
                //Login Screen
                ConsoleKeyInfo choice;
                choice = Console.ReadKey(true);
                if (choice.Key == ConsoleKey.L)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n\n");
                    Console.Write("\t\t\t      UserName: ________________\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    string user;
                    user = Console.ReadLine();
                    //user = "admin";
                    Console.Write("\n\n\t\t\t      Password: ________________\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    //string pass = "admin";

                    string pass = "";
                    ConsoleKeyInfo key;

                    do
                    {
                        key = Console.ReadKey(true);
                        // Backspace Should Not Work
                        if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                        {
                            pass += key.KeyChar;
                            Console.Write("*");
                        }
                        else
                        {
                            if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                            {
                                pass = pass.Substring(0, (pass.Length - 1));
                                Console.Write("\b \b");
                            }
                        }
                    }
                    while (key.Key != ConsoleKey.Enter);
                    Console.Clear();
                
                    DateTime today = DateTime.Now;
                    if (user == "admin" && pass == "admin")
                    {
                        ConsoleKeyInfo decision;
                        do
                        {
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n");
                        Console.Write("\t\t\t\t\t\t\t" + today);
                        Console.WriteLine("\t\t\t \t\t\t \t\t  Welcome " + user);
                        display.LogIN();
                        ConsoleKeyInfo choice1;
                        choice1 = Console.ReadKey(true);
                        if (choice1.Key == ConsoleKey.C)
                        {
                            NewStudent student = new NewStudent();
                        }
                        else if (choice1.Key == ConsoleKey.D)
                        {
                            //deletion
                        }

                        else if (choice1.Key == ConsoleKey.S)
                        {
                            ReadFile reader = new ReadFile(path);
                            //reader = new ReadFile(path);
                            reader.searchStudent();
                            Console.WriteLine("\n\n\t\t\t  Show All Students(Y/N)");
                            ConsoleKeyInfo choice2 = Console.ReadKey(true);
                            if (choice2.Key == ConsoleKey.Y)
                            {
                                reader.Print();
                            }
                        }
                        else if (choice1.Key == ConsoleKey.A)
                        {
                            Console.Clear();
                            Console.Write("\n\t\t\t::::::  << ATTANDANCE >>  ::::::");
                            Console.Write("\n\n\t\t           Enter Department: ____\b\b\b\b");
                            string dept = Console.ReadLine().ToUpper();
                            Console.Write("\n\t\t             Enter Semester: ____\b\b");
                            string semester = Console.ReadLine().ToUpper();
                            ReadFile reader = new ReadFile(path);
                            //reader = new ReadFile(path);
                            reader.MarkAttendance(dept, semester);

                            // StreamWriter attendance = new StreamWriter("@:Attendance.txt");
                            Console.WriteLine("\n\t Attendance Marked");
                            Console.WriteLine(today);
                            //  reader.WriteFile();
                        }
                        // Console.WriteLine("CONGRATULATIONS");

                        else if (choice1.Key == ConsoleKey.V)
                        {
                            TTS tts = new TTS();
                            tts.topStudent(path);

                        }
                        else if (choice1.Key == ConsoleKey.E)
                            Environment.Exit(0);
                        else
                            Console.WriteLine("\n\t\t Wrong Choice");
                        Console.WriteLine("\n\t Do you want to continue (Y/N)");
                        decision = Console.ReadKey(true);
                         } while (decision.Key == ConsoleKey.Y) ;
                    }
                    else
                        Console.WriteLine("Sorry! Try Again");
                 
            } 
            Console.Read();
        }
    }
}

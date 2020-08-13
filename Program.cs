using System;
using System.Reflection.Metadata;
//using Microsoft.Office.Interop.Word;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
namespace AnswerConverter
{
    class Program// z C:\Internship\TEST Q.txt| C:\Internship\TEST A.txt
    {
        public static string Alocation = "";
        public static string Qlocation = "";
        public static string A = "";
        public static string Q = "";
        public static string space = "=----------------------=";
        static void Main(string[] args)
        {
            Update.Title(0,0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            miscellaneous.centerText("Answer converter by Dustin");
            Console.ResetColor();
            miscellaneous.centerText("Version 0.1");
            Thread.Sleep(1000);
            while (true)
            {


                Console.WriteLine("Please enter the location of the questions");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{Environment.MachineName}@{Environment.UserName} > ");
                Console.ResetColor();
                Qlocation = Console.ReadLine().ToString();
                Q = IO.attemptOpen(Qlocation);
                Update.Title(0, 0);
                Console.WriteLine("Please enter the location of the answers");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{Environment.MachineName}@{Environment.UserName} > ");
                Console.ResetColor();
                Alocation = Console.ReadLine().ToString();
                A = IO.attemptOpen(Alocation);
                Console.WriteLine();
                Update.Title(Count.countLines(Q), Count.countLines(A));
                //
                for (int i = 0; i <10;i++ )//math.less(Count.countLines(Q)+2,Count.countLines(A))+2; i++)
                {
                    Thread.Sleep(20);
                    working();
                }
                Console.ReadLine();
            }
        }
        public static void working()
        {
            Console.WriteLine(space);
            // Console.WriteLine();
            Console.WriteLine(Grab.grabquestion(Q));
            Console.WriteLine();
            Console.WriteLine($"~{Grab.grabAnswerExplination(A)}");//A
            Console.WriteLine(Grab.graboptions(Q).Replace(Grab.grabAnswerLetter(A), '*' + Grab.grabAnswerLetter(A))); //Q
            Q = Q.Replace(Grab.grabAll(Q), "");
            A = A.Replace(Grab.grabAll(A), "");
        }
        }
}

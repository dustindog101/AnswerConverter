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
                Globalvariables.Qlocation = Console.ReadLine().ToString();
                Globalvariables.Q = IO.attemptOpen(Globalvariables.Qlocation);
                Update.Title(0, 0);
                Console.WriteLine("Please enter the location of the answers");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{Environment.MachineName}@{Environment.UserName} > ");
                Console.ResetColor();
                Globalvariables.Alocation = Console.ReadLine().ToString();
                Globalvariables.A = IO.attemptOpen(Globalvariables.Alocation);
                Console.WriteLine();
                Update.Title(Count.countLines(Globalvariables.Q), Count.countLines(Globalvariables.A));
                //
                for (int i = 0; i <math.greater(Count.countLines(Globalvariables.Q)+3,Count.countLines(Globalvariables.A)+3); i++)
                {
                    Thread.Sleep(20);
                    work();
                }
                Console.ReadLine();
            }
        }
        public static void work()
        {
            Console.WriteLine(Globalvariables.space);
            // Console.WriteLine();
            Console.WriteLine(Grab.grabquestion(Globalvariables.Q));
            Console.WriteLine();
            Console.WriteLine($"~{Grab.grabAnswerExplination(Globalvariables.A)}");//A
            Console.WriteLine(Grab.graboptions(Globalvariables.Q).Replace(Grab.grabAnswerLetter(Globalvariables.A), '*' + Grab.grabAnswerLetter(Globalvariables.A))); //Q
            Globalvariables.Q = Globalvariables.Q.Replace(Grab.grabAll(Globalvariables.Q), "");
            Globalvariables.A = Globalvariables.A.Replace(Grab.grabAll(Globalvariables.A), "");
        }
        }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace AnswerConverter
{
    class IO
    {
         public static string attemptOpen(string inp)
        {
            string outp ="";
            try
            {

            using (StreamReader sr = new StreamReader(inp))
            {
                outp = sr.ReadToEnd();
            }

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRROOOOOOOOOOOO: "+ex.Message);
                Console.ResetColor();
            }
            return outp;
        }
    }
}

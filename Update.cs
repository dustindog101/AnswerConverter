using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AnswerConverter
{
    class Update
    {
        public static void Title(int QC,int AC)
        {
            Console.Title = $"Answer Converter by Dustin | Questions loaded:{QC} | Answers Loaded{AC}";
        }
            
    }
}

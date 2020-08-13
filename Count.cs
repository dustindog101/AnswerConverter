using System;
using System.Collections.Generic;
using System.Text;

namespace AnswerConverter
{
    class Count
    {
public static int countLines(string inp)
        {
            int outp = 0;
            foreach (string newline in inp.Split(new[] { '_' }))
            {
                int index = Globalvariables.Q.IndexOf(Environment.NewLine);
                //   Program.Q = Program.Q.Substring(index + Environment.NewLine.Length);
                outp++;

                
            }
            return outp;
        }
    }
}

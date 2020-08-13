using System;
using System.Collections.Generic;
using System.Text;

namespace AnswerConverter
{
   public static class Grab
    {
       
        public static string grabAll(string inp)
        {
            string outp = null;
            foreach (string newline in inp.Split(new[] { '_' }))
            {
                int index = Globalvariables.Q.IndexOf(Environment.NewLine);
                //   Program.Q = Program.Q.Substring(index + Environment.NewLine.Length);
                outp = newline.ToString() + "_";

                break;
            }
            return outp;
        }
        public static string grabAnswerExplination(string inp)
        {
            string outp = null;
            foreach (string newline in inp.Split(new[] { '?' }))
            {
                int index = inp.IndexOf(Environment.NewLine);
              //  Program.A = Program.A.Substring(index + Environment.NewLine.Length);
                string[] split = newline.ToString().Split('.'); //ω
                string[] rea = newline.ToString().Split('_');
                  outp = rea[0].Replace(split[0] + "." +split[1] + ". ","");
                // outp = outp.Replace(split[0],"").Replace(split[1],"").Replace(split[2],"");
              //  outp = split[0] + ". " + split[1] + ".";
                break;
            }
            return outp;
        }
        public static string grabAnswerLetter(string inp)
        {
string outp = null;
            foreach (string newline in inp.Split(new[] { '?' }))
            {
                int index = inp.IndexOf(Environment.NewLine);
              //  inp = inp.Substring(index + Environment.NewLine.Length);
                string[] split = newline.ToString().Split('.');
                outp = split[1].Replace(" ","")+".";
                break;
            }
            return outp;
        }
       public static string grabquestion(string inp)
        {
            string outp = null;
            foreach (string newline in inp.Split(new[] { '?' }))
            {
                int index = Globalvariables.Q.IndexOf(Environment.NewLine);
             //   Program.Q = Program.Q.Substring(index + Environment.NewLine.Length);
                outp = newline.ToString() + "?";

                break;
            }
            return outp;

        }
        public static string graboptions(string inp)
        {
            string question = grabquestion(inp);
            string outp = null;
            foreach (string newline in inp.Split(new[] {'_'}))
            {
                int index = inp.IndexOf(Environment.NewLine);
             //   Program.Q = Program.Q.Substring(index + Environment.NewLine.Length);
                outp = newline.ToString() + "";

                break;
            }
            return outp.Replace(question, "");

        }
    }
}

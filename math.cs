using System;
using System.Collections.Generic;
using System.Text;

namespace AnswerConverter
{
    class math
    {
        public static int greater(int a,int b)
        {
            if (a>b)
            {
                return a;
            }
            if (a<b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        public static int less(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}

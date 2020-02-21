using System;
using static System.Console;

namespace A.WarmLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -70;
            //bool isOdd = (i % 2 == -1) || (i % 2 == 1);

            while (i < 10)
            {
                bool isOdd = (i % 2 == -1) || (i % 2 == 1);
                if (isOdd)
                {
                    Write($"{i}, ");
                   
                }
                i++;
            }
        }
    }
}

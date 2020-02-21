using System;
using static System.Console;

namespace Repeat2digitLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<=9; i++)
            {
                for(int j = 0; j<=9; j++)
                {
                    for(int k = 0; k <= 9; k++)
                    {
                        if (((i == j) || (i==k)) || (j==k))
                        {
                            if (!((i == j) && (j == k)))
                            {
                                Write($"{i}{j}{k}, ");
                            }
                        }
                    }
                }

            } 
        }
    }
}

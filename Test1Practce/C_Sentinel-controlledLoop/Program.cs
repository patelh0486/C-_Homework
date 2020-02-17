using System;
using static System.Console;

namespace C_Sentinel_controlledLoop
{
    class Program
    {
        static void Main(string[] args)
        {
           // WriteLine("enter a number:");
           // int num = Convert.ToInt32(ReadLine());
            int prev = 10;
            int total = 0;
            int count = 0;
            int largest = int.MinValue;

            for(; ; )
            {
                WriteLine("Enter a number : ");
                int num = Convert.ToInt32(ReadLine());
                total += num;
                count += 1;
                if ( (prev < 10 && prev >=-9) && (num < 10 && num >= -9))
                {
                   
                    break;
                }
                if (num > largest)
                {
                    largest = num;
                }
                prev = num; ;
            }
            WriteLine("largest number: " + largest);
            double average = (double)total / count;
            WriteLine("Average : " + average);
        }
    }
}

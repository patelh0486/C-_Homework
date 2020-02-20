using System;
using static System.Console;

namespace D.NestedLoopswithChar
{
    class Program
    {
        static void Main(string[] args)
        {

            for (char a = 'M'; a <= 'W'; a++)
            {
                for (char b = (char)(a + 1); b <= 'W'; b++)
                {

                    if (a == 'Q' && b=='U')
                    {
                        Write("," + a + b );
                    }
                    if (a == 'O')
                    {
                        Write("," + a + b);
                    }
                    if (a != 'O' && b=='O')
                    {
                        Write("," + a + b);
                    }
                    if (a == 'U')
                    {
                        Write("," + a + b);
                    }
                    if (a != 'U' && b == 'U')
                    {
                        Write("," + a + b);
                    }

                    for (char c = (char)(b + 1); c <= 'W'; c++)
                    {
                        if (a == 'Q' && b == 'U')
                        {
                            Write("," + a + b + c);
                        }
                        if (b == 'Q' && c == 'U')
                        {
                            Write("," + a + b + c);
                        }
                        if (a != 'O' && b != 'O' && c == 'O')
                        {
                            Write("," + a + b + c);
                        }
                        if (a != 'O' && b == 'O' && c != 'O')
                        {
                            Write("," + a + b + c);
                        }
                        if (a == 'O' && b != 'O' && c != 'O')
                        {
                            Write("," + a + b + c);
                        }
                        if (a != 'U' && b != 'U' && c == 'U')
                        {
                            Write("," + a + b + c);
                        }
                        if (a != 'U' && b == 'U' && c != 'U')
                        {
                            Write("," + a + b + c);
                        }
                        if (a == 'U' && b != 'U' && c != 'U')
                        {
                            Write("," + a + b + c);
                        }

                    }
                }
                for (char b = (char)(a - 1); b >= 'M'; b--)
                {
                    if (a == 'Q' && b == 'U')
                    {
                        Write("," + a + b);
                    }
                    if (a == 'O')
                    {
                        Write("," + a + b);
                    }
                    if (a != 'O' && b == 'O')
                    {
                        Write("," + a + b);
                    }
                    if (a == 'U')
                    {
                        Write("," + a + b);
                    }
                    if (a != 'U' && b == 'U')
                    {
                        Write("," + a + b);
                    }

                    for (char c = (char)(b - 1); c >='M'; c--)
                    {

                        if (a != 'O' && b != 'O' && c == 'O')
                        {
                            Write("," + a + b + c);
                        }
                        if (a != 'O' && b == 'O' && c != 'O')
                        {
                            Write("," + a + b + c);
                        }
                        if (a == 'O' && b != 'O' && c != 'O')
                        {
                            Write("," + a + b + c);
                        }
                        if (a != 'U' && b != 'U' && c == 'U')
                        {
                            Write("," + a + b + c);
                        }
                        if (a != 'U' && b == 'U' && c != 'U')
                        {
                            Write("," + a + b + c);
                        }
                        if (a == 'U' && b != 'U' && c != 'U')
                        {
                            Write("," + a + b + c);
                        }
                    }
                }
            }   
         }
           
     }
 }

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 3;
            var b = 6;
            var c = 9;
                        
            var s1 = Stopwatch.StartNew();

            for (int i = 1; i < 3000; i++)
            {

                if (a == 0)
                {
                    a = 9;
                }

                if (b == 0)
                {
                    b = 9;
                }

                if (c == 0)
                {
                    c = 9;
                }

                a = --a;
                b = --b;
                c = --c;

                Trace.WriteLine($"{i}{a} {i}{b} {i}{c} { (a == 0 ? $"{i}9" : "")}");

                if (a == 0)
                {
                    a = b;
                    b = c;
                    c = 9;
                }

            }

            s1.Stop();        

        }
    }
}

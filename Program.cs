using System;

namespace Oskars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int naem = int.Parse(Console.ReadLine());

            double statuetki = naem * 0.7;
            double ketaring = statuetki * 0.85;
            double ozvuchavane = ketaring / 2;

            double totalsum = naem + statuetki + ozvuchavane + ketaring;
            Console.WriteLine($"{totalsum:f2}");  
        }
    }
}

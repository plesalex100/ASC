using System;
using System.Runtime.InteropServices;

namespace Moores_Law
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N = ?");
            try
            {
                int n = int.Parse(Console.ReadLine());

                double months = Math.Log(n, 2) * 18;
                Console.WriteLine($"Vom avea procesoare de {n} ori mai puternice la acelasi pret in {Math.Floor(months / 12)} ani si {Math.Floor(months % 12)} luni");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

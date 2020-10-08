using System;

/// <summary>
/// Conform legii lui Moore (puterea de calcul se dublează la fiecare 18 luni iar prețul rămâne același), putem observa ca puterea de calcul creste exponential in baza 2 la fiecare 18 luni, astfel
/// obtinem formula Log in baza 2 din n inmultit cu 18 pentru a obtine lunile necesare cresterii de n ori a puterii de calcul.
/// </summary>

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

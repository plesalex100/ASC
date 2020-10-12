using System;

namespace LearningExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduceti un numar Natural format din 2 cifre");
            string line = Console.ReadLine();
            
            try
            {
                int number;
                if(!int.TryParse(line, out number))
                {
                    throw new Exception("Nu ati introdus un numar");
                }

                if(number < 10 || number > 99)
                {
                    throw new Exception("Numarul nu este format din 2 cifre !");
                }

                Console.WriteLine($"Numarul este {number} si este format din 2 cifre");

            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

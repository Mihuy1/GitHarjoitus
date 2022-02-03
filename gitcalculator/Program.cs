using System;

namespace gitcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ensimmäinen numero: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toinen numero: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            int sum = input + input1;

            Console.WriteLine("Vastaus: " + sum);
        }
    }
}

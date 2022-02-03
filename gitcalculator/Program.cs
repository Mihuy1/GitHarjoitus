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

            Console.WriteLine("Jos haluat summan paina 1 ja jos haluat erotuksen paina 2");
            int vastaus = Convert.ToInt32(Console.ReadLine());

             if (vastaus == 1) 
            {
                int sum = input + input1;
                Console.WriteLine("Vastaus: " + sum);
            } else 
            {
                int erotus = input - input1;
                Console.WriteLine("Erotus: " + erotus);
            }
           
        }
    }
}

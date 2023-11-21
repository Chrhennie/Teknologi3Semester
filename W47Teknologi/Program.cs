using System;

namespace W47Teknologi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" Indtast et tal for at tjekke om det er et primtal ");

                uint input = Convert.ToUInt32(Console.ReadLine());

                if (IsPrime(input))
                {
                    Console.WriteLine(IsPrime(input));
                }
                else
                    Console.WriteLine(IsPrime(input));
            }
        }

        public static bool IsPrime(uint number)
        {
            if (number == 0) return false;

            for (uint i = 2; i < number; i++)
                if (number % i == 0)
                    return false;
            return true;

        }
    }
}
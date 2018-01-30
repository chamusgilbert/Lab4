using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            long factor = 1;
            Factoring(factor);
        }
        public static void Factoring(long factor)
        {
            Console.WriteLine("Give me a number between 1 and 10.");

            bool goodNum = Int64.TryParse(Console.ReadLine(), out long userNum);
            if (goodNum == false)
            {
                Console.WriteLine("Try again");
                Factoring(factor);
            }
            else if (userNum >= 10 || userNum <= 1)
            {
                Console.WriteLine("Try again");
                Factoring(factor);
            }
            else
            {
                int i = 1;
                while (i <= userNum)
                {
                    factor = i * factor; // factor *= i;
                    Console.WriteLine(factor);
                    i++;
                }
                Console.WriteLine("The factor of your number is: " + factor);


            }
        }
    }
}

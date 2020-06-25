using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,sum=0,m;
            Console.WriteLine("Enter a four digit number");
            number = int.Parse(Console.ReadLine());

            while(number>0)
            {
                m = number % 10;
                sum = sum + m;
                number = number/10;
            }

            Console.WriteLine("The Sum of the digits {0} is {1}", number, sum);


        }
    }
}

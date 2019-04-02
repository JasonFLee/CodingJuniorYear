using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForPrimeRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("what number do you want to check?");
             int number = int.Parse(Console.ReadLine());
            bool result = CheckForPrime(number);

            if (result == true)
            {
                Console.WriteLine("it is prime");
            }
            if (result == false)
            {
                Console.WriteLine("it is not prime");
            }
            Console.ReadLine();
        }
        static bool CheckForPrime(int n, int divisor = 2)
        {
            if (n % divisor == 0)
            {
                return false;
            }
            if (divisor == n - 1)
            {
                return true;
            }
            return CheckForPrime(n, divisor + 1);

        }

    }
}

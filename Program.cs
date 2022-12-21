using System;

namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the lower and upper bounds
            Console.WriteLine("Enter the lower bound (n1): ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the upper bound (n2): ");
            int n2 = int.Parse(Console.ReadLine());

            // Find the perfect numbers between n1 and n2
            Console.WriteLine("Perfect numbers between {0} and {1}:", n1, n2);
            for (int i = n1; i <= n2; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Returns true if the given number is a perfect number, false otherwise
        static bool IsPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }
    }
}



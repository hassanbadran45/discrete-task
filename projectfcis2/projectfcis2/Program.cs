using System;

namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter n2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsPerfect(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum == n;
        }
    }
}
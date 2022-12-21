using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int[] array = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                Random random = new Random();
                array[i] = random.Next(1000);
            }
            int maxArray = OtherFunctions.FindMax(array);
            Console.WriteLine(maxArray);
            bool[] isPrime = new bool[maxArray + 1];
            CheckPrimeNumber.SieveOfEratosthenes(maxArray, ref isPrime);
            for (int i = 0; i < maxArray + 1; i++)
            {
                Console.Write(i + "" + isPrime[i] + " ");
            }
            Console.WriteLine(FindNearestPrimeNumber.FindNearest(isPrime, 50));
            Console.ReadKey();
        }
    }
}

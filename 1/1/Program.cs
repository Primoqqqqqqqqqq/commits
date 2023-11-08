using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace рекурсивные_ф_и
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];
            int[] a1 = new int[20];

            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);
                a1[i] = a[i];

                Console.Write(a[i] + " ");
            }
            Console.WriteLine("\n");


            int min = a1[0];
            int max = a1[0];
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < a1.Length; i++)
            {
                if (a1[i] < min)
                {
                    min = a1[i];
                    minIndex = i;
                }

                if (a1[i] > max)
                {
                    max = a1[i];
                    maxIndex = i;
                }
            }

            int t = a1[minIndex];
            a1[minIndex] = a1[maxIndex];
            a1[maxIndex] = t;

            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write($"{a1[i]} ");
            }
            Console.WriteLine();
        }
    }
}

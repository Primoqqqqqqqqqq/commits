using System;
using System.Collections.Generic;
using System.IO;
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
            Random random = new Random();
            int[] a = new int[40];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(20)-10;
            }

            Array.Sort(a);
            Array.Reverse(a);

            using (StreamWriter writer = new StreamWriter("d:\\F1.txt"))
            {
                foreach (int num in a)
                {
                    writer.WriteLine(num);
                }
            }

            Array.Sort(a);

            using (StreamWriter writer = new StreamWriter("d:\\F2.txt"))
            {
                foreach (int num in a)
                {
                    writer.WriteLine(num);
                }
            }

            Console.WriteLine("ready");
        }
    }
}

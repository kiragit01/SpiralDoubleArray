using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SpiralDoubleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {


            const int n = 5;

            int[,] a = new int[n, n];

            int g = 1;
            int f = 0;
            int e = 1;

            for (int p = 0; p <= n / 2; p++)
            {
                for (int i = f; i < n - f; i++)
                {
                    a[f, i] = g++;
                }
                for (int j = e; j < n - f; j++)
                {
                    a[j, n - e] = g++;
                }
                for (int k = e; k < n - f; k++)
                {
                    a[n - e, n - e - k + f] = g++;
                }
                f++;
                for (int d = f; d < n - f; d++)
                {
                    a[n - e - d + f - 1, f - 1] = g++;
                }
                e++;
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i,j]+"\t");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}

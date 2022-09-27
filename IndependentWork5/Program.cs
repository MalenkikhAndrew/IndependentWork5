using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение N");
            int n=Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) 
                {
                    int k = n / 2; 
                    array[i, j] = ((i == j) || (i + j == n - 1)|| ((i == k) && (j == 0))|| ((i == k) && (j == n-1))) ? 1 : 0;
                    Console.Write("{0} ", array[i, j]);
                   
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

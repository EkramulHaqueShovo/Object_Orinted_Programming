using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];

            Console.WriteLine("Enter elements of the 2D array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Element({0},{1}): ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The array is:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The sum of each row is:");
            for (int i = 0; i < 3; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < 3; j++)
                {
                    rowSum += arr[i, j];
                }
                Console.WriteLine("Row {0}: {1}", i, rowSum);
            }

            Console.WriteLine("The sum of each column is:");
            for (int i = 0; i < 3; i++)
            {
                int columnSum = 0;
                for (int j = 0; j < 3; j++)
                {
                    columnSum += arr[j, i];
                }
                Console.WriteLine("Column {0}: {1}", i, columnSum);
            }

            Console.ReadKey();
        }
    }
}
    




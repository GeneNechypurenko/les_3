using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr2d = new int[2,3];
            //Random rand = new Random();

            //for (int i = 0; i < arr2d.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2d.GetLength(1); j++)
            //    {
            //        arr2d[i,j] = rand.Next(-10, 10);
            //        Console.Write(arr2d[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            const int size = 10;
            int[] arr = new int[size] { 7, 6, 5, 4, 3, 7, 6, 5, 4, 3 };

            Console.Write("enter 1 number: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("enter 2 number: ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("enter 3 number: ");
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine("looking for coincidence...");

            int count = 0;
            int n = 0;

            while(n < size)
            {
                if (arr[n] == first)
                {
                    n++;

                    if (arr[n] == second)
                    {
                        n++;

                        if (arr[n] == third)
                        {
                            count++;
                        }
                        else
                        {
                            n++;
                        }
                    }
                    else
                    {
                        n++;
                    }
                }
                else
                {
                    n++;
                }
            }

            Console.WriteLine("coincidence count is " + count);
        }
    }
}

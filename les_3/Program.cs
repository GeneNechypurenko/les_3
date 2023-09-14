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

            //    const int size = 10;
            //    int[] arr = new int[size] { 7, 6, 5, 4, 3, 7, 6, 5, 4, 3 };

            //    Console.Write("enter 1 number: ");
            //    int first = int.Parse(Console.ReadLine());

            //    Console.Write("enter 2 number: ");
            //    int second = int.Parse(Console.ReadLine());

            //    Console.Write("enter 3 number: ");
            //    int third = int.Parse(Console.ReadLine());

            //    Console.WriteLine("looking for coincidence...");

            //    int count = 0;
            //    int n = 0;

            //    while(n < size)
            //    {
            //        if (arr[n] == first)
            //        {
            //            n++;

            //            if (arr[n] == second)
            //            {
            //                n++;

            //                if (arr[n] == third)
            //                {
            //                    count++;
            //                }
            //                else
            //                {
            //                    n++;
            //                }
            //            }
            //            else
            //            {
            //                n++;
            //            }
            //        }
            //        else
            //        {
            //            n++;
            //        }
            //    }

            //    Console.WriteLine("coincidence count is " + count);

            int size = 10;
            int[] arrFirst = new int[size];
            int[] arrSecond = new int[size];

            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                arrFirst[i] = rand.Next(0, 9);
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(arrFirst[i] + " ");
            }
            Console.WriteLine();


            for (int i = 0; i < size; i++)
            {
                arrSecond[i] = rand.Next(0, 9);
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(arrSecond[i] + " ");
            }
            Console.WriteLine();


            int[] arrUnique = new int[size * 2];
            int countUnique = 0;

            for (int i = 0; i < size; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < countUnique; j++)
                {
                    if (arrFirst[i] == arrUnique[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    arrUnique[countUnique] = arrFirst[i];
                    countUnique++;
                }

                isDuplicate = false;

                for (int j = 0; j < size; j++)
                {
                    if (arrSecond[j] == arrUnique[countUnique])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    arrUnique[countUnique] = arrSecond[i];
                    countUnique++;
                }
            }

            for (int i = 0; i < countUnique; i++)
            {
                Console.Write(arrUnique[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

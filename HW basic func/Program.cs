using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_basic_func
{
    class Program
    {
        private static void PrintNumberName(int num)
        {
            if (num < 1 || num > 10)
            {
                Console.WriteLine("Number out of range!");
                return;
            }
            string[] num_names = {"One", "Two", "Three", "Four", "Five",
            "Six", "Seven", "Eight", "Nine", "Ten"};
            Console.WriteLine(num_names[num - 1]);
        }

        private static bool PrintNumbers(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            return num > 0 && num <= 10;
        }

        private static void PrintNumbersRe(int num)
        {
            if (num >= 10)
            {
                Console.WriteLine(num);
                return;
            }
            Console.Write(num + ", ");
            PrintNumbersRe(num + 1);
        }

        private static int IsPrime(int num)
        {
            if (num <= 1)
            {
                return 0;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }

        private static void IsPrimeArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0, -2} --> {1} prime.", arr[i], IsPrime(arr[i]) == 0 ? "Not" : "Is");
            }
        }


        private static int IsArray1Bigger(int[] arr1, int[] arr2)
        {
            int sum1 = arr1.Sum();
            int sum2 = arr2.Sum();

            if (sum1 > sum2)
            {
                return 1;
            }
            else if (sum1 < sum2)
            {
                return -1;
            }
            return 0;
        }

        private static int[,] CreateRandomMatrix()
        {
            Random rnd = new Random();
            int[,] mat = new int[10, 10];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = rnd.Next(1, 101);
                }
            }
            return mat;
        }

        private static void CheckIfExist(int[,] mat)
        {
            Console.Write("Enter a number to check: ");
            int num = int.Parse(Console.ReadLine());

            bool exist = false;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    exist = mat[i, j] == num;
                    if (exist)
                    {
                        break;
                    }
                }
                if (exist)
                {
                    break;
                }
            }
            if (exist)
            {
                Console.WriteLine("Exist!");
            }
            else
            {
                Console.WriteLine("Missing!");
            }
        }

        private static int[] SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //like arr.Min()
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }

        private static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        private static int[] CreateRandomArray(int len)
        {
            int[] arr = new int[len];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-25, 26);
            }
            return arr;
        }


        static void Main(string[] args)
        {
            //ex8
            PrintNumberName(5);

            //ex9
            PrintNumbers(5);
            //test Console.WriteLine(PrintNumbers(5));

            //ex10
            PrintNumbersRe(1);

            //ex11
            Console.Write("Enter a number to check: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));

            //ex12
            int[] arr = { 2, 4, 9, 13, 17 };
            IsPrimeArr(arr);

            //ex13
            int[] arr1 = { 1, 5, 7 };
            int[] arr2 = { 3, 5, 1 };
            int result = IsArray1Bigger(arr1, arr2);
            Console.WriteLine(result);

            //ex14
            int[,] mat = CreateRandomMatrix();
            for (int i = 0; i < 10; i++)
            {
                CheckIfExist(mat);
            }

            //ex15
            int[] random_arr = CreateRandomArray(10);
            PrintArray(random_arr);
            PrintArray(SortArray(random_arr));



            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

            //by: t.me/yehuda100
        }

    }
}

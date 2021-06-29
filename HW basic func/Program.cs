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
                Console.WriteLine("{0, -2} --> {1}.", arr[i], IsPrime(arr[i]) == 1 ? "Prime" : "Not prime");
            }
        }


        static void Main(string[] args)
        {
            //ex8
            //PrintNumberName(5);

            //ex9
            //PrintNumbers(5);
            // test Console.WriteLine(PrintNumbers(5));

            //ex10
            //PrintNumbersRe(1);

            //ex11
            //Console.Write("Enter a number to check: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(IsPrime(num));

            //ex12
            //int[] arr = { 2, 4, 9, 13, 17 };
            //IsPrimeArr(arr);




            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

            //byt.me/yehuda100
        }

    }
}

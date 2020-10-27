using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics;

namespace Talor_s_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            int n, counter = 0;
            double Epsilon;
            ref int Xcounter = ref counter;


            Console.Write("Enter x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter n: ");
            n = Convert.ToInt32(Console.ReadLine());


            double result = talorSqrt(x, n);
            double epsilon;

            Console.WriteLine("\n\n\n" + "result is: " + result);

            epsilon = Math.Sqrt(1 + x) - result;
            Console.WriteLine("Epsilon is: " + epsilon);

            Console.WriteLine("\n\n\n part 2\n\n");

            Console.WriteLine("Enter epsilon");
            Epsilon = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\n\nResult is: " + talorSqrtEps(Epsilon, x, ref Xcounter) 
                    + "\nCount of summunds is: " + Xcounter);
        }

        static double talorSqrt(double x, int n)
        {

            double result = 0;
            double comp = Math.Sqrt(1 + x);

            while (x > 1 || x < -1) {

                Console.Out.WriteLine("Wrong x! Enter another value");
                x = Convert.ToDouble(Console.ReadLine());
            }
            while (n < 10) {

                Console.Out.WriteLine("N number should be more than 10! Enter another value");
                n = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++) {

                double temp = ((Math.Pow(-1, i) * fact(2 * i))
                           / ((1 - (2 * i) * Math.Pow(fact(i), 2) * Math.Pow(4, i))))
                           * Math.Pow(x, i);
                result += temp;

                Console.Out.WriteLine(result + "     " + temp + "    " + comp);
            }

            return result;
        }

        static double talorSqrtEps(double Epsilon, double x, ref int i) {


            while (x > 1 || x < -1)
            {

                Console.Out.WriteLine("Wrong x! Enter another value");
                x = Convert.ToDouble(Console.ReadLine());
            }
            while (Epsilon < 0)
            {

                Console.Out.WriteLine("Epsilon should be more than 0! Enter another value");

            }

            double result = 0;
            double temp = 0;
            double comp = Math.Sqrt(1 + x);
            i = 0;
            do
            {           
                temp = ((Math.Pow(-1, i) * fact(2 * i))
                               / ((1 - (2 * i) * Math.Pow(fact(i), 2) * Math.Pow(4, i))))
                               * Math.Pow(x, i);
                result += temp;
                i++;

                Console.Out.WriteLine(result + "     " + temp + "    " + comp);

            } while (Math.Abs(temp) > Epsilon);

                return result;
        }

        static int fact(int n) {

            if (n == 0 || n == 1) { return 1; };
            if (n == 2) { return 2; }
            else
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {

                    result *= i;
                }
                return result;
            }
        }
    }
}

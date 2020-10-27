using System;
using System.Buffers;

namespace task_2_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int toStart;
            do
            {
                int n;
                Console.WriteLine("enter array size:");
                n = Convert.ToInt32(Console.ReadLine());
                getIntcheck(ref n, 10, 10000);

                int[] randInts = new int[n];
                randIntArr(randInts, -100, 100);

                Console.WriteLine("Answer is: " + task(randInts));

                Console.WriteLine("\n\n\nto start app again enter 1\n\n\n\n");
                toStart = Convert.ToInt32(Console.ReadLine());

            } while (toStart == 1);
        }

        static void randIntArr(int[] array, int st, int end) {
            var rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(st, end);
                while (array[i] == 0) { 
                    array[i] = rand.Next(st, end);
                }
            }
        }

        static void getIntcheck(ref int n, int dpS, int dpE) {

            while (n < dpS || n > dpE)
            {
                Console.WriteLine("enter another number from {0} to {1}\nEnter here: ", dpS, dpE);
                n = Convert.ToInt32(Console.ReadLine());
            }
        }

        static int task(int[] array) {

            int ctr;

            for (ctr = 0; ctr < (array.Length - 1); ctr++)
            {
                if (array[ctr] > 0 && array[ctr + 1] < 0) 
                {
                    Console.WriteLine("counter: " + ctr + "  value: " + array[ctr]);
                    continue; 
                }
                else if (array[ctr] < 0 && array[ctr + 1] > 0) 
                {
                    Console.WriteLine("counter: " + ctr + "  value: " + array[ctr]); 
                    continue; 
                }
                else 
                {
                    Console.WriteLine("counter: " + ctr + "  value: " + array[ctr] +  "\nnext is: " + array[ctr + 1]); 
                    return ctr + 1;
                }          
            }

            return 0;                
        }
    }
}

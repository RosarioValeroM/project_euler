using System;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem2();
        }

        //Problem 1
        public static void Problem1()
        {
            int a, b, sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                a = i % 3;
                b = i % 5;

                if (a == 0 || b == 0)
                {
                    sum = sum + i;
                }
                else { }
            }
            Console.WriteLine("\n The sum of the multiples of 3 or 5 below 1ooo : {0}", sum);
            Console.Read();
        }

        //Problem 2

        public static void Problem2()
        {
            int a = 1;
            int b = 2;
            int aux;
            int suma = 0;    
            while (b <= 4000000)
            {
                aux = a + b;
                a = b;
                b = aux;
                

                if ( a % 2 == 0)
                {
                suma += a;
                }
            }

            Console.WriteLine(suma);
            Console.Read();
        }
    }
}

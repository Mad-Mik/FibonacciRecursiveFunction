using System;

namespace FibonacciRecursiveFunction
{
    class Program
    {

        //f(n) = f(n-1) + f(n-2)
        //1, 1, 2, 3, 5, 8, 13, 21, 34, 55...
        // F(0) = 0; F(1) = 1;
        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return n;

            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            int x = Fibonacci(7); //13

            Console.WriteLine(x);
            Console.WriteLine(Fibonacci(1));   //1
            Console.WriteLine(Fibonacci(2));   //1
            Console.WriteLine(Fibonacci(3));   //2
            Console.WriteLine(Fibonacci(4));   //3
            Console.WriteLine(Fibonacci(5));   //5
            Console.WriteLine(Fibonacci(6));   //8
            Console.WriteLine(Fibonacci(7));   //13
            Console.WriteLine(Fibonacci(8));   //21
            Console.WriteLine(Fibonacci(9));   //34
            Console.WriteLine(Fibonacci(10));  //55
            Console.ReadKey();
        }


    }

}


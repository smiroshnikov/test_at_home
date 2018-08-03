using System;

namespace testCLI
{
    public static class Fibonacci
    {
        private static long Fib(long n)
        {
            long result;

            if (n == 1 || n == 2)
            {
                result = 1;
                return result;
            }

            result = Fib(n - 1) + Fib(n - 2);


            //Console.WriteLine(result);
            return result;
        }

        public static void Main()
        {
            Fib(9);
            Console.WriteLine(Fib(117));
        }
    }
}
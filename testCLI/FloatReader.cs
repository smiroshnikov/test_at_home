using System;
using System.Runtime.InteropServices;

namespace testCLI
{
    public static class FloatReader
    {
        private static float ReadFloat(string input)
        {
            try
            {
                var result = float.Parse(input);
                Console.WriteLine(result);
                return result;
            }
            catch
            {
                Console.WriteLine("this is not a number !");
                return 0;
            }
        }

        private static double ReadDouble(string input)
        {
            try
            {
                double result = double.Parse(input);
                Console.WriteLine(result);
                return result;
            }
            catch
            {
                Console.WriteLine("No a floating point number ...");
                return 0;
            }
        }

        private static void Main(string[] args)
        {
            ReadFloat("5,0000000000000005");
            ReadFloat("hello!");
            ReadFloat(null);
            ReadDouble("5.5");
            ReadDouble("0,300000000000005");
        }
    }
}
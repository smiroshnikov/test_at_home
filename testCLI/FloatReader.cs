using System;
using System.Runtime.InteropServices;

namespace testCLI
{
    public static class FloatReader
    {
        private static float ReadFloat(string input)
        {
            if (input == null) throw new InvalidOleVariantTypeException("input");
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

        private static void Main(string[] args)
        {
            ReadFloat("5,0000000000000005");
            ReadFloat("hello!");
            ReadFloat(null);
        }
    }
}
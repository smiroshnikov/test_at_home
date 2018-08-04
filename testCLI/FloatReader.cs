using System;
using System.Linq;

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
                var result = double.Parse(input);
                Console.WriteLine(result);
                return result;
            }
            catch
            {
                Console.WriteLine("No a floating point number ...");
                return 0;
            }
        }

        private static void Main()
        {
            Console.WriteLine(ReadFloat("5,0000000000000005"));
            ReadFloat("hello!");
            ReadFloat(null);
            ReadDouble("5.5");
            Console.WriteLine(ReadDouble("0,300000000000005"));
            var s1 = "abcdefg";
            char[] c = {'a', 'b'};
            char[] c2 = { };
            s1 = s1 + 'a';

            var s2 = new string(s1.ToCharArray().Reverse().ToArray());
            Console.Out.WriteLine("s2 = {0}", s2);
        }
    }
}
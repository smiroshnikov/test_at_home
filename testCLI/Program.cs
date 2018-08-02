using System;
using System.Collections.Generic;
using System.Globalization;

namespace testCLI
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Privet Kroka ! ");
            var x = 10.54;
            var y = 1.2234234f;
            var sum = x + y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("Sum is {0}", sum.ToString(CultureInfo.InvariantCulture));

            if (sum > 10)
            {
                Console.WriteLine("The sum is larger than 10, i will change that  ");
                x += 1.01;
                y += 0.00001f;
            }
            else
            {
                x = 0;
                y = 0;
            }

            Console.WriteLine(x.ToString(CultureInfo.InvariantCulture),
                y.ToString(CultureInfo.InvariantCulture));

            var counter = 0;
            while (counter < 6)
            {
                counter += 1;
            }

            Console.WriteLine("Counter is {0}", counter.ToString());

            List<string> fruits = new List<string>();

            fruits.Add("apple");
            fruits.Add("lemon");
            fruits.Add("grapefruit");
            fruits.Add("melon");
            fruits.Add("watermelon");
            fruits.Add("orange");
            fruits.Add("grapes");
            fruits.Add("banana");


            Console.WriteLine("\n-----------------------------------------------------------------");
            var i = 0;
            var value = 0;

            foreach (var item in fruits)
            {
                i += 1;
                Console.WriteLine("{0} ->{1}", i.ToString(), item);
                
//                if (i % 2 != 0) continue;
//                try
//                {
//                    // statements causing exception
//                    fruits.Remove(fruits[i]);
//                }
//                catch (Exception e1)
//                {
//                    // error handling code
//                    Console.WriteLine("Fuck you ! {0}", e1);
//                    value = 13;
//                    throw new ArgumentNullException("Blah Blah exception ! ");
//                }
//                finally
//                {
//                    // statements to be executed
//                    Console.WriteLine("WILL EXECUTE IN ANY CASE ....{0}", value.ToString());
//                }                
            }
            fruits.Sort();
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            
        }
    }
}
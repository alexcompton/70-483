using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParametersByReference
{
    class Program
    {
        /// <summary>
        /// notice the methods have different names, you can't overload methods by out and ref
        /// they are the same in the IL and can't tell the difference between them.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // x is unintialized y is
            Int32 x, y = 5;

            // pass by reference using out
            GetValX(out x);
            Console.WriteLine(x);

            // pass by reference using ref
            GetValY(ref y);
            Console.WriteLine(y);

            String s1 = "alex";
            String s2 = "compton";

            // variables that are passed by reference must match what the method expects
            Console.WriteLine(s1 + " " + s2);
            Swap(ref s1, ref s2);
            Console.WriteLine(s1 + " " + s2);

            // same as before just with ints
            Console.WriteLine(x + " " + y);
            Swap(ref x, ref y);
            Console.WriteLine(x + " " + y);

            Console.WriteLine("\n\npress any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// you can use generics to swap any object type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        private static void Swap<T>(ref T t1, ref T t2)
        {
            T temp = t2;
            t2 = t1;
            t1 = temp;
        }

        /// <summary>
        /// out means the method might take an uninitialized parameter
        /// </summary>
        /// <param name="x"></param>
        private static void GetValX(out int x)
        {
            x = 10;
        }

        /// <summary>
        /// ref means the variable should already be initailized
        /// </summary>
        /// <param name="x"></param>
        private static void GetValY(ref int x)
        {
            x += 10;
        }
    }
}
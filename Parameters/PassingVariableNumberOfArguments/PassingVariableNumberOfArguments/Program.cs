using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingVariableNumberOfArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            // thanks to this ability all these will now work in the add method
            Console.WriteLine(Add());
            Console.WriteLine(Add(1, 1, 1, 12, 2, 21, 0));
            Console.WriteLine(Add(null));
            Console.WriteLine(Add(new Int32[] { 1, 1, 4, 6 }));

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// this method can take in any number of parameters this 
        /// can be done with any object type. Notice that this causes
        /// a preformance hit using params so you might want to overload
        /// a few methods with for common uses and have the params be a 
        /// last resort
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        static Int32 Add(params Int32[] values)
        {
            // create a spot to hold the sum of the values
            Int32 sum = 0;

            // if there are no values in the method then return 
            if (values == null) return 0;

            // add up all the values in the values array
            for (Int32 x = 0; x < values.Length; x++)
            {
                sum += values[x];
            }

            return sum;
        }
    }
}

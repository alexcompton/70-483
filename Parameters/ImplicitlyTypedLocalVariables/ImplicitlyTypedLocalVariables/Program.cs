using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Jeff";
            ShowVariableType(name);

            // var n = null; // this throws and error can't assign null to an implicitly-typed local variable

            var x = (String)null; // this is ok to do but not very useful same to String x = null;
            ShowVariableType(x); 

            var numbers = new Int32[] { 1, 2, 3, 4 };
            ShowVariableType(numbers);

            // saves some typing for complex types
            var collection = new Dictionary<String, Single>() { { "Alex", 4.0f }, { "bill", 5.0f } };
            ShowVariableType(collection);

            foreach (var item in collection)
            {
                ShowVariableType(item);
            }

            Console.WriteLine("\n\npress any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// shows the type of the variable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        private static void ShowVariableType<T>(T t)
        {
            Console.WriteLine(typeof(T));
        }
    }
}

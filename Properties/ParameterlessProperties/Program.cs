using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterlessProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a good example of why to use data ecapsulation
            BadPerson bp = new BadPerson();
            GoodPerson gp = new GoodPerson();

            // you can interact with both the same way
            bp.Name = "billy";
            gp.Name = "bob";
            bp.Age = 5;
            gp.Age = 5;

            Console.WriteLine(bp.Name + " is " + bp.Age + " years old.");
            Console.WriteLine(gp.Name + " is " + gp.Age + " years old.");           

            // this is where they are different there is a check put in place
            // to maintain the state information
            bp.Age = -5;
            Console.WriteLine(bp.Name + " is " + bp.Age + " years old.");
            gp.Age = -5; // throws error you never get to see the code below
            Console.WriteLine(gp.Name + " is " + gp.Age + " years old.");

            Console.WriteLine("\n\npress any key to continue...");
            Console.ReadKey();
        }
    }
}

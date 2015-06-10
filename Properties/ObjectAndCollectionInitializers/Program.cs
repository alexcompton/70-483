// this is to use the good person class i created in another assembly
// to save typing
using Person = ParameterlessProperties.GoodPerson;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectAndCollectionInitializers
{
    /// <summary>
    /// this sample class is to show what you can do if a property's type
    /// implements the IEnumberable or IEnumberable<T> interface
    /// </summary>
    public sealed class Classroom
    {
        private List<String> m_students = new List<string>();
        public List<String> Students { get { return m_students; } }

        public Classroom() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // this is common syntax for setting some of an objects
            // public properties
            Person p = new Person() { Name = "alex", Age = 25 };

            // the code above is the same as the code below
            Person _tempPerson = new Person();
            _tempPerson.Age = 25;
            _tempPerson.Name = "alex";
            Person p2 = _tempPerson;

            // the benifit is you can luse the object initializer syntax to code in 
            // and expression context, permitting composability of functions. This
            // increases code readability with less lines
            String str = new Person() { Name = "alex", Age = 25 }.ToString().ToUpper();
            Console.WriteLine(str);

            // using the classroom object you can quickly initialize the students as follows
            // but the class needs an add function for this to work
            Classroom classroom = new Classroom
            {
                Students = { "phil", "mark", "matt", "alex" }
            };

            // display results
            foreach (var student in classroom.Students)
                Console.WriteLine(student);

            // you can also do this with objects whose add takes multiple arguments
            var table = new Dictionary<string, int>
            {
                { "phil",1},{ "mark",2}, {"matt",3}, {"alex",4 }
            };

            // display results
            foreach (var item in table)
                Console.WriteLine(item.Key + ": " + item.Value);

            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }
    }
}

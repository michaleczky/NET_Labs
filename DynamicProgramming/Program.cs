using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // dynamic string
            dynamic str = "Hello World!";
            Console.WriteLine(str.GetType());
            Console.WriteLine(str);

            // get length of another dynamic string using reflection
            dynamic dyn = "This is a dynamic string";
            Console.WriteLine(GetDynamicStringLength(dyn));

            // trying to get string length of a dynamic int
            dynamic dyn2 = 42;
            Console.WriteLine(GetDynamicStringLength(dyn2));

            // exmaple on ExpandoObject
            dynamic expando = new ExpandoObject();
            expando.Name = "Test object";
            expando.Id = 12;
            Console.WriteLine($"{expando.Name}, {expando.Id}");

            Console.ReadKey();            

        }

        static int GetDynamicStringLength(dynamic dyn)
        {
            Type t = dyn.GetType();
            if (t.Name.Equals("String"))
            {
                PropertyInfo prop = t.GetProperty("Length");
                return prop.GetValue(dyn);
            }
            return -1;
        }

    }
}

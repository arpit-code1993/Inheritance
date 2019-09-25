using System;

namespace Inheritance
{
    class Program : Class1
    {
        static void Main(string[] args)
        {
            Class1 cs = new Class1();
            cs.name="Arpit Gupta";
            cs.salary = 100000;

            Console.WriteLine("name {0}", cs.name);
            Console.WriteLine("salary {0}", cs.salary);
        }
    }
}

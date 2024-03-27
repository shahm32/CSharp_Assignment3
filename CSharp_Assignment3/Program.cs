using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment3
{
    class Program
    {
        static void Main(string[]args)
        {
            Person bob=new Person();
            Console.WriteLine(bob.IsValidated());

            Person kim=new Person("Kim","Smith");
            Console.WriteLine(kim.IsValidated());
        }
    }
}

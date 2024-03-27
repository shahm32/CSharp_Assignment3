using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment3
{
    public class Person : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName = "", string lastName = "")
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override bool IsValidated()
        {
            if (FirstName == null)
                FirstName = "";
            if (LastName == null)
                LastName = "";
            return FirstName.Length>0&&LastName.Length>0; 
        }
    }
}

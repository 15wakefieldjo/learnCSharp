using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace learnCSharp
{
    class Teacher : Person
    {
        String location;
        public Teacher(String name, String location) : base(name, Person.type.TEACHER)
        {
            this.location = location;
            
        }
    class Person
    {
        public enum role
        {
            HEADTEACHER
        };
       public role teacherjob { get; set; }

    }
        
}
    }

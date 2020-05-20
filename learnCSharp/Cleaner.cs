using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace learnCSharp
{
    class Cleaner : Person
    {
        String location;
        public Cleaner(String name, String location) : base(name, Person.type.CLEANER)
        {
            this.location = location;

        }
        
    }

}
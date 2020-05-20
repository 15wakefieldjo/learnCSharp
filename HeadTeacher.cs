using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace learnCSharp
{
    class HeadTeacher : Person
    {
        String location;
        public HeadTeacher(String name, String location) : base(name, Person.type.HEADTEACHER)
        {
            this.location = location;

        }

    }

}

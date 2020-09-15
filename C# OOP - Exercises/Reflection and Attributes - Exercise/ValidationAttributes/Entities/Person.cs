using System;
using System.Collections.Generic;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Entities
{
    public class Person
    {
        private const int MinAge = 12;
        private const int MaxAge = 90;

        public Person(string fullName, int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }

        [MyRequiredAttribute]
        public string FullName { get; private set; }

        [MyRange(MinAge,MaxAge)]
        public int Age { get; private set; }
    }
}

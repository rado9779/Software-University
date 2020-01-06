using System;
using System.Collections.Generic;
using System.Text;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name { get; }
        public int Age { get; }
        public string Town { get; }

        public int CompareTo(Person other)
        {
            int compare = Name.CompareTo(other.Name);
            if (compare == 0)
            {
                compare = Age.CompareTo(other.Age);
                if (compare == 0)
                {
                    compare = Town.CompareTo(other.Town);
                }
            }
            return compare;
        }
    }
}

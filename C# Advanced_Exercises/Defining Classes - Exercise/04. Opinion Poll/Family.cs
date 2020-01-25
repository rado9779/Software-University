using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public List<Person> People { get; set; }
        public Family Where { get; internal set; }

        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

        public  Person GetOldestMember()
        {
            var oldestPerson = this.people
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();

            return oldestPerson;
        }
    }
}

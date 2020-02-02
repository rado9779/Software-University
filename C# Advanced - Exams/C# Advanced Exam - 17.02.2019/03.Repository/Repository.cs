using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Repository
    {
        private Dictionary<int, Person> collection;
        private int id;

        public Repository()
        {
            this.collection = new Dictionary<int, Person>();
            this.id = 0;
        }
        public int Count => this.collection.Count;

        public void Add(Person person)
        {
            this.collection.Add(this.id++, person);
        }
        public Person Get(int id)
        {
            return this.collection[id];
        }
        public bool Update(int id, Person newPerson)
        {
            if (!this.collection.ContainsKey(id))
            {
                return false;
            }
            this.collection[id] = newPerson;
            return true;
        }
        public bool Delete(int id)
        {
            if (!this.collection.ContainsKey(id))
            {
                return false;
            }

            this.collection.Remove(id);
            return true;
        }

    }
}

using BorderControl.Interfaces;
using System;

namespace BorderControl.Models
{
    public class Pet : IBirthable
    {
        public Pet(string name,string birthdate)
        {
            this.Name = name;
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy",null);
        }

        public string Name { get;private set; }
        public DateTime Birthdate { get; private set; }
    }
}

using BorderControl.Interfaces;
using System;

namespace BorderControl.Models
{
    public class Robot : IIdentifiable ,IBirthable
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Id { get; private set; }

        public string Model { get;private set; }

        public DateTime Birthdate { get; private set; }
    }
}

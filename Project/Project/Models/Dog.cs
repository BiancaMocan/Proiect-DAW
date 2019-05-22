using System;

namespace Project.Models
{
    public class Dog
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int Weight { get; set; }

        public string Breed { get; set; }
    }
}
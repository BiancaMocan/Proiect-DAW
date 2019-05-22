using System;

namespace APIProject.Models
{
    public class Dog
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public float Weight { get; set; }

        public string Breed { get; set; }
    }
}

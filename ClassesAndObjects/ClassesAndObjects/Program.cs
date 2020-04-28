using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal { Name = "Rex", Age = 5, Species = "pies" };
            Console.WriteLine("To zwierzę to " + dog.Species + ", ma " + dog.Age + " lat i ma na imię " + dog.Name + ".");
            dog.Move();
        }
    }

    class Animal
    { 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        public void Move()
        {
            Console.WriteLine(Name + " porusza się.");
        }
    }
}

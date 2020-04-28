using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal { Name = "Mruczek", Age = 5, Species = "kot" };
            Console.WriteLine(cat.ToString());
            cat.Move();
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

        public new string ToString()
        {
            return "To zwierzę to " + Species + ", ma " + Age + " lat i ma na imię " + Name + ".";
        }
    }

    class Fish : Animal
    {
        public new void Move()
        {
            Console.WriteLine(Name + " pływa.");
        }
    }

    class Dog : Animal
    {
        public new void Move()
        {
            Console.WriteLine(Name + " biega.");
        }
    }


}

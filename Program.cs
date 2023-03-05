using System;
using System.ComponentModel.DataAnnotations;

namespace Activity_3
{
    class Cat
    {
        public string name = "unknown";
        public string breed = "unknown";
        public string nature = "unknown";
        public double age;

        public Cat(string name, string breed, string nature, double age)
        {
            this.name = name;
            this.breed = breed;
            this.nature = nature;
            this.age = age;
        }

        public Cat(string name, string breed, double age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }

        public Cat(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

        public void display()
        {
            Console.WriteLine(name + ": ");
            Console.WriteLine("\t" + breed + "\n" + "\t" + nature + "\n" + "\t" + age + "\n");
        }

        static public int number(int a)
        {
            return a + 3;
        }

        static public int number(int a, int b)
        {
            return a + b + 3;
        }

        static public int number(int a, int b, int c)
        {
            return a + b + c + 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int Siamese, AmericanShorthair, Puspin;

            Siamese = Cat.number(3);
            AmericanShorthair = Cat.number(3, 2);
            Puspin = Cat.number(3, 2, 5);

            Console.WriteLine("Cat Store\n");

            Cat Lomi = new ("Lomi", "Puspin", "Relaxed", 0.4);
            Cat Jill = new ("Jill", "American Shorthair");
            Cat Flay = new ("Flay", "Siamese", 8);

            Lomi.display();
            Console.Write("Quantity (same breed): ");
            Console.WriteLine(Puspin + "\n");

            Jill.display();
            Console.Write("Quantity (same breed): ");
            Console.WriteLine(AmericanShorthair + "\n");

            Flay.display();
            Console.Write("Quantity (same breed): ");
            Console.WriteLine(Siamese + "\n");

            
        }
    }
}
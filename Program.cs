using System;

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Name = "Tommy";
        d.age = 5;
        d.breed = "Labrador";

        d.speak();

        Cat c = new Cat();
        c.Name = "Kitty";
        c.age = 3;

        c.speak();
        c.meow();
    }

    class Animal
    {
        public string Name;
        public int age;

        public void speak()
        {
            Console.WriteLine($"Name: {Name}, Age: {age}");
        }
    }

    class Dog : Animal
    {
        public string breed;
    }

    class Cat : Animal
    {
        public void meow()
        {
            Console.WriteLine("Meow!");
        }
    }
}
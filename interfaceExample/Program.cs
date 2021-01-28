using System;

namespace lesson8
{
    public interface IShape
    {
        double Area();
    }

    public class Square : IShape
    {
        double length;

        // overloaded constructor
        public Square(double length)
        {
            this.length = length;
        }

        // interface method
        public double Area()
        {
            // area = length * length
            return length * length;
        }
    }

    public class Circle : IShape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            // area = 3.14 * radius * radius
            return 3.14 * radius * radius;
        }
    }

    // `FoodConsumer` interface
    public interface FoodConsumer
    {
        string eat();
    }

    // `Animal` interface
    public interface Animal
    {
        string sound();
    }

    // base class `Mammal` - one method `greet()`
    public class Mammal
    {
        private string name;

        public Mammal(string name)
        {
            this.name = name;
        }

        public string greet()
        {
            return "Hello, I'm " + this.name + ".";
        }
    }

    // `Dog` class inherits from `Mammal` class - inherits the `greet()` method
    // It implements both the `FoodConsumer` and `Animal` interfaces:
    //  - It implements the `FoodConsumer` interface's `eat()` method
    //  - It implements the `Animal` interface's `sound()` method
    public class Dog : Mammal, FoodConsumer, Animal
    {
        public Dog(string name) : base(name) { }

        public string eat()
        {
            return "Yum yum!";
        }

        public string sound()
        {
            return "Woof!";
        }
    }

    class Program
    {
        static void Main()
        {
            double squareLength = 19.50;
            Square sq = new Square(squareLength);
            double area = sq.Area();
            Console.WriteLine(area);

            double circleRadius = 4;
            Circle cir = new Circle(circleRadius);
            double circleArea = cir.Area();
            Console.WriteLine(circleArea);

            Dog spot = new Dog("Spot");
            Console.WriteLine(spot.greet());
            Console.WriteLine(spot.eat());
            Console.WriteLine(spot.sound());
        }
    }
}
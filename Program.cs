using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ls6
{
    //sealed - заборона успадкування класів
    //class Parent
    //{
    //    public static int Counter { get; set; } = 0;
    //    protected int x, y, z;
    //    public Parent()
    //    {
    //        Counter++;
    //    }
    //    public Parent(int x) : this()
    //    {
    //        this.x = x;
    //        this.y = 0;
    //        this.z = 0;
    //    }
    //    public Parent(int x, int y, int z) : this()
    //    {
    //        this.x = x;
    //        this.y = y;
    //        this.z = z;
    //    }
    //    public virtual void Infor()
    //    {
    //        Console.WriteLine( "Hello from Parent");
    //    }
    //}
    //class Child : Parent
    //{
    //    private string name;
    //    public string Name { get { return name; } set { name = value; } }
    //    public Child(int x, int y, int z) : base(x, y, z)
    //    {
    //        Name = "Super Child!";
    //    }
    //    public override void Infor()
    //    {
    //        base.Infor();
    //        Console.WriteLine($"{x}, {y}, {z}");
    //    }

    //}
    class Human
    {
        public string Name;
        public int Age;
        public string Gender;

        public Human(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        
    }

    class Builder : Human
    { 
        public Builder(string name, int age, string gender): base(name, age, gender) { }

        public void Build()
        {
            Console.WriteLine("I am building a house!");
        }

    }
    class Pilot : Human
    {
        public Pilot(string name, int age, string gender) : base(name, age, gender) { }

        public void FlyThePlane()
        {
            Console.WriteLine("I fly a plane!");
        }

    }
    class Sailor : Human
    {
        public Sailor(string name, int age, string gender) : base(name, age, gender) { }

        public void SailOnAShip()
        {
            Console.WriteLine("I sail on a ship!");
        }

    }

    class Passport
    {
        protected string country;
        protected string fullName;
        protected DateTime dateOfBirth;

        public Passport(string country, string fullName, DateTime dateOfBirth)
        {
            this.country = country;
            this.fullName = fullName;
            this.dateOfBirth = dateOfBirth;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Country: {country}");
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Date of Birth: {dateOfBirth.ToShortDateString()}");
        }
    }

    class ForeignPassport : Passport
    {
        private string passportNumber;
        private string[] visas;

        public ForeignPassport(string country, string fullName, DateTime dateOfBirth, string passportNumber)
            : base(country, fullName, dateOfBirth)
        {
            this.passportNumber = passportNumber;
            this.visas = new string[0];
        }

        public void AddVisa(string visa)
        {
            Array.Resize(ref visas, visas.Length + 1);
            visas[visas.Length - 1] = visa;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Passport Number: {passportNumber}");
            Console.WriteLine("Visas:");
            foreach (var visa in visas)
            {
                Console.WriteLine(visa);
            }
        }
    }
    class Animal
    {
        protected string name;
        protected string species;
        protected int age;

        public Animal(string name, string species, int age)
        {
            this.name = name;
            this.species = species;
            this.age = age;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Species: {species}");
            Console.WriteLine($"Age: {age}");
        }
    }

    class Tiger : Animal
    {
        private string furColor;

        public Tiger(string name, int age, string furColor) : base(name, "Tiger", age)
        {
            this.furColor = furColor;
        }

        public void Roar()
        {
            Console.WriteLine("Roar! I am a tiger!");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Fur Color: {furColor}");
        }
    }

    class Crocodile : Animal
    {
        private string habitat;

        public Crocodile(string name, int age, string habitat) : base(name, "Crocodile", age)
        {
            this.habitat = habitat;
        }

        public void Snap()
        {
            Console.WriteLine("Snap! I am a crocodile!");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Habitat: {habitat}");
        }
    }

    class Kangaroo : Animal
    {
        private int jumpHeight;

        public Kangaroo(string name, int age, int jumpHeight) : base(name, "Kangaroo", age)
        {
            this.jumpHeight = jumpHeight;
        }

        public void Jump()
        {
            Console.WriteLine($"I am a kangaroo! I can jump {jumpHeight} meters high!");
        }
    }
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return length * width;
        }
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class RightTriangle : Shape
    {
        private double baseLength;
        private double height;

        public RightTriangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }
    }

    class Trapezoid : Shape
    {
        private double base1;
        private double base2;
        private double height;

        public Trapezoid(double base1, double base2, double height)
        {
            this.base1 = base1;
            this.base2 = base2;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * (base1 + base2) * height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Parent obj1 = new Child(12, 5, 6);

            //obj1.Infor();

            //if(obj1 is Child)
            //{
            //    (obj1 as Child).Name = "Test";
            //}
            //List<Parent> list = new List<Parent>();
            //List.Add(list);

            Console.WriteLine("PRAC_1");

            Builder bob = new Builder("Bob", 35, "Male");
            bob.Build(); 
            Console.WriteLine($"Builder: {bob.Name}, Age: {bob.Age}, Gender: {bob.Gender}");

            Pilot alice = new Pilot("Alice", 40, "Female");
            alice.FlyThePlane(); 
            Console.WriteLine($"Pilot: {alice.Name}, Age: {alice.Age}, Gender: {alice.Gender}");

            Sailor jack = new Sailor("Jack", 25, "Male");
            jack.SailOnAShip(); 
            Console.WriteLine($"Sailor: {jack.Name}, Age: {jack.Age}, Gender: {jack.Gender}");

            Console.WriteLine("PRAC_2");

            Passport regularPassport = new Passport("USA", "John Doe", new DateTime(1990, 5, 15));
            regularPassport.PrintInfo();

            Console.WriteLine();

            ForeignPassport foreignPassport = new ForeignPassport("USA", "John Doe", new DateTime(1990, 5, 15), "ABC123456");
            foreignPassport.AddVisa("Schengen Visa");
            foreignPassport.AddVisa("UK Visa");
            foreignPassport.PrintInfo();

            Console.WriteLine("PRAC_3");

            Tiger tiger = new Tiger("Simba", 5, "Orange");
            tiger.PrintInfo();
            tiger.Roar();

            Console.WriteLine();

            Crocodile crocodile = new Crocodile("Snappy", 10, "Swamp");
            crocodile.PrintInfo();
            crocodile.Snap();

            Console.WriteLine();

            Kangaroo kangaroo = new Kangaroo("Joey", 3, 3);
            kangaroo.PrintInfo();
            kangaroo.Jump();

            Console.WriteLine("PRAC_4");
            Shape[] shapes = new Shape[]
            {
                new Rectangle(2, 4),
                new Circle(2),
                new RightTriangle(3, 5),
                new Trapezoid(6, 8, 3)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area: {shape.CalculateArea()}");
            }

            Console.ReadKey();
        }
    }
}

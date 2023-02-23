namespace AbstractAnimalClass
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Cat : Animal
    {
        public override string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public Cat()
        {
            Name = "";
            Age = 0;
            Color = "";

        }

        public Cat(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public override string Describe()
        {
            return $"Name: {Name} \nAge: {Age} \nColor: {Color}\n";
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.Name = "Venus";
            cat1.Color = "Brown";
            cat1.Age = 5;

            Cat cat2 = new Cat("Aries", 12, "Black");

            Console.WriteLine(cat1.Describe());
            Console.WriteLine(cat2.Describe());
        }
    }
}
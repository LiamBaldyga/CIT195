namespace AnimalInheritance
{
    class Program
    {
        // base Class 
        class Animal
        {
            private string name; // only accessible within this class
            protected string type; //accessible from derived classes
            public string color;  // accessible from any class

            public void setName(string name)
            {
                this.name = name;
            }
            public virtual string getName()
            {
                return this.name;
            }
            public void setType(string type)
            {
                this.type = type;
            }
            public virtual string getType()
            {
                return this.type;
            }
        }

        class Cat : Animal
        {
            private int age;
            private string breed;
            private int weight;

            public void setAge(int age)
            {
                this.age = age;
            }

            public int getAge()
            {
                return this.age;
            }

            public void setBreed(string breed)
            {
                this.breed = breed;
            }

            public string getBreed()
            {
                return this.breed;
            }

            public void setWeight(int weight)
            {
                this.weight = weight;
            }

            public int getWeight()
            {
                return this.weight;
            }

            public override string getName()
            {
                return "Cat";
            }
            public override string getType()
            {
                return "Mammal";
            }
        }


        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.setName("Dog");
            a.setType("Mammal");
            a.color = "Brown";
            Console.WriteLine("-----Animal Information-----");
            Console.WriteLine($"Name: {a.getName()}");
            Console.WriteLine($"Type: {a.getType()}");
            Console.WriteLine($"Color: {a.color}");

            Cat c = new Cat();
            c.setBreed("Chartreux");
            c.setAge(5);
            c.setWeight(11);
            c.color = "Grey";
            Console.WriteLine("-----Cat Information-----");
            Console.WriteLine($"Name: {c.getName()}");
            Console.WriteLine($"Type: {c.getType()}");
            Console.WriteLine($"Color: {c.color}");
            Console.WriteLine($"Breed: {c.getBreed()}");
            Console.WriteLine($"Age: {c.getAge()}");
            Console.WriteLine($"Weight: {c.getWeight()}");
        }
    }
}
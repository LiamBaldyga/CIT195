using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal 
    class Fish : Animal
    {
        public int length;
        public string color;
        public int weight;
        
        public Fish(): base() 
        {
            length = 0;
            color = "";
            weight = 0;
        }

        public Fish(string name, int length, string color, int weight) :base(name)
        {
            this.length = length;
            this.color = color;
            this.weight = weight;
        }

        public void displayInfo()
        {
            Console.WriteLine($"\n-----Fish information----- \nName: {name} \nLength: {length}in \nColor: {color} \nWeight: {weight}lbs");
        }
    }

    class Cat : Animal
    {
        public int age;
        public int weight;
        public string color;

        public Cat(): base()
        {
            age = 0;
            color = "";
            weight = 0;
        }

        public Cat(string name, int age, int weight, string color): base(name)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
        }

        public void displayInfo()
        {
            Console.WriteLine($"\n-----Cat information----- \nName: {name} \nAge: {age} \nColor: {color} \nWeight: {weight}lbs");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Fish fish1 = new Fish();
            fish1.name = "Joel";
            fish1.length = 10;
            fish1.weight = 3;
            fish1.color = "Green";
            fish1.displayInfo();


            //derived class object using parameterized constructor
            Fish fish2 = new Fish("Drake", 15, "White", 5);
            fish2.displayInfo();

            Cat cat1 = new Cat();
            cat1.name = "Venus";
            cat1.weight = 10;
            cat1.color = "Brown";
            cat1.age = 6;
            cat1.displayInfo();

            Cat cat2 = new Cat("Arya", 4, 8, "Brown");
            cat2.displayInfo();
        }

    }
}
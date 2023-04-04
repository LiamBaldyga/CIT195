using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public static bool operator >(Person p1, Person p2)
    {
        return p1.Age > p2.Age;
    }

    public static bool operator <(Person p1, Person p2)
    {
        return p1.Age < p2.Age;
    }

    public static Person operator +(Person p1, Person p2)
    {
        string newName = p1.Name + " and " + p2.Name;
        int newAge = (p1.Age + p2.Age) / 2;
        return new Person(newName, newAge);
    }

    public override string ToString()
    {
        return Name + " (" + Age + ")";
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Person person1 = new Person("Alice", 25);
        Person person2 = new Person("Bob", 30);

        Console.WriteLine("Person 1: " + person1);
        Console.WriteLine("Person 2: " + person2);

        if (person1 > person2)
        {
            Console.WriteLine("Person 1 is older than Person 2");
        }
        else
        {
            Console.WriteLine("Person 1 is younger than Person 2");
        }

        Person person3 = person1 + person2;
        Console.WriteLine("Person 3 (average of Person 1 and Person 2): " + person3);
    }
}
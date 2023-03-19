using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        class famousPeople
        {
            public string Name { get; set; }
            public int? BirthYear { get; set; } = null;
            public int? DeathYear { get; set; } = null;
        }



        static void Main(string[] args)
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
     };
            
            var past1900 = from people in stemPeople
                        where people.BirthYear > 1900
                        select people.Name;

            Console.WriteLine("People born after 1900");
            foreach (var name in past1900) Console.WriteLine(name);

            var twoLs = from people in stemPeople
                        where people.Name.Contains("ll")
                        select people.Name;

            Console.WriteLine("\nTwo lowercase l's");
            foreach(var name in twoLs) Console.WriteLine(name);

            var peopleCount = (from people in stemPeople
                              where people.BirthYear > 1950
                              select people).Count();

            Console.WriteLine($"\nThe amount of people born after 1950 is {peopleCount}");

            var between = (from people in stemPeople
                           where people.BirthYear > 1920 && people.BirthYear < 2000
                           select people.Name).Count();

            Console.WriteLine($"\nThe amount of people born after 1920 and before 2000 is {between}");

            var sorted = from people in stemPeople
                         orderby people.BirthYear
                         select people.Name;

            Console.WriteLine("\nPeople sorted by birth year");
            foreach (var name in sorted) Console.WriteLine(name);

            var sortedDeath = from people in stemPeople
                              where people.DeathYear > 1960 && people.DeathYear < 2015
                              orderby people.Name ascending
                              select people.Name;

            Console.WriteLine("\nPeople born between 1960 and 2015, sorted by name in ascending order");
            foreach (var name in sortedDeath) Console.WriteLine(name);
        }
    }
}
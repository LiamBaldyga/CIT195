namespace immutableID
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1);
            s1.FirstName = "John";
            s1.LastName = "Doe";

            Student s2 = new Student(2, "Liam", "Baldyga");

            display(s1);
            display(s2);
        }

        static void display(Student std)
        {
            Console.WriteLine($"ID: {std.Id} \n Name: {std.FirstName} {std.LastName}\n");

        }
    }
    class Student
    {
        // auto-implemented properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }
        // parameterized constructor
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }

        public Student(int i)
        {
            Id = i;
            FirstName = "";
            LastName = "";
        }

    }
}
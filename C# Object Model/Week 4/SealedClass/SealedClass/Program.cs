namespace SealedClass
{
    interface IEmployee
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
        public double Pay();
    }
    class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public string Fullname()
        {
            return FirstName + " " + LastName;
        }
        public virtual double Pay()
        {
            double salary;
            Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
            salary = double.Parse(Console.ReadLine());
            return salary;
        }

        public virtual void display()
        {
            Console.WriteLine($"ID: {Id} \nName: {Fullname()} \nSalary: {Pay()}\n");
        }

    }

    sealed class Executive : Employee
    {
        public string Title { set; get; }
        public double Salary { set; get; }

        public Executive()
        {
            Title = string.Empty;
            Salary = 0;
        }

        public Executive(int id, string firstName, string lastName, string title, double salary) : base(id, firstName, lastName)
        {
            Title = title;
            Salary = salary;
        }

        public override double Pay()
        {
            Console.WriteLine($"What is {Fullname()}'s weekly bonus?");
            double bonus = double.Parse(Console.ReadLine());
            return Salary + bonus;
        }

        public override void display()
        {
            Console.WriteLine($"ID: {Id} \nName: {Fullname()} \nTitle: {Title} \nSalary: {Salary} \nBonus: {Pay() - Salary}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "John", "Doe");
            employee.display();

            Executive exec = new Executive(2, "Liam", "Baldyga", "CEO", 100000.00);
            exec.display();
        }
    }
}
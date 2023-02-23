namespace ClubInterface
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
    }

    class ClubMember : IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegistrationDate { get; set; }



        public ClubMember()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }

        public ClubMember(int id, string firstName, string lastName, string email, DateTime registrationDate, bool isActive)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            RegistrationDate = registrationDate;
            IsActive = isActive;
        }

        public string Fullname()
        {
            return FirstName + " " + LastName;
        }

        public void display()
        {
            Console.WriteLine($"Id: {Id} \nName: {Fullname()} \nEmail: {Email} \nRegistration Date: {RegistrationDate.ToShortDateString()} \nActive: {IsActive}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClubMember club = new ClubMember(1, "Liam", "Baldyga", "liambaldyga@gmail.com", new DateTime(2022, 2, 23), true);
            club.display();
        }
    }
}
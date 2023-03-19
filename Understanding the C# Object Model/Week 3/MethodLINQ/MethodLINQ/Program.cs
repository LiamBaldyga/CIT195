using System.Linq;

namespace MethodLINQ
{
    class Program
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
            public string Major { get; set; }
            public double Tuition { get; set; }
        }
        public class StudentClubs
        {
            public int StudentID { get; set; }
            public string ClubName { get; set; }
        }
        public class StudentGPA
        {
            public int StudentID { get; set; }
            public double GPA { get; set; }
        }
        static void Main(string[] args)
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Frank Furter", Age = 55, Major="Hospitality", Tuition=3500.00} ,
                new Student() { StudentID = 1, StudentName = "Gina Host", Age = 21, Major="Hospitality", Tuition=4500.00 } ,
                new Student() { StudentID = 2, StudentName = "Cookie Crumb",  Age = 21, Major="CIT", Tuition=2500.00 } ,
                new Student() { StudentID = 3, StudentName = "Ima Script",  Age = 48, Major="CIT", Tuition=5500.00 } ,
                new Student() { StudentID = 3, StudentName = "Cora Coder",  Age = 35, Major="CIT", Tuition=1500.00 } ,
                new Student() { StudentID = 4, StudentName = "Ura Goodchild" , Age = 40, Major="Marketing", Tuition=500.00} ,
                new Student() { StudentID = 5, StudentName = "Take Mewith" , Age = 29, Major="Aerospace Engineering", Tuition=5500.00 }
    };
            // Student GPA Collection
            IList<StudentGPA> studentGPAList = new List<StudentGPA>() {
                new StudentGPA() { StudentID = 1,  GPA=4.0} ,
                new StudentGPA() { StudentID = 2,  GPA=3.5} ,
                new StudentGPA() { StudentID = 3,  GPA=2.0 } ,
                new StudentGPA() { StudentID = 4,  GPA=1.5 } ,
                new StudentGPA() { StudentID = 5,  GPA=4.0 } ,
                new StudentGPA() { StudentID = 6,  GPA=2.5} ,
                new StudentGPA() { StudentID = 7,  GPA=1.0 }
            };
            // Club collection
            IList<StudentClubs> studentClubList = new List<StudentClubs>() {
            new StudentClubs() {StudentID=1, ClubName="Photography" },
            new StudentClubs() {StudentID=1, ClubName="Game" },
            new StudentClubs() {StudentID=2, ClubName="Game" },
            new StudentClubs() {StudentID=5, ClubName="Photography" },
            new StudentClubs() {StudentID=6, ClubName="Game" },
            new StudentClubs() {StudentID=7, ClubName="Photography" },
            new StudentClubs() {StudentID=3, ClubName="PTK" },
        };

            var studentGPA = studentGPAList.GroupBy(s => s.GPA).Select(s => s.Key);
            Console.WriteLine("Students GPA descending order");
            foreach (var s in studentGPA)
            {
                Console.WriteLine(s);
            }

            var studentClub = studentClubList.GroupBy(s => s.ClubName).Select(s => s.Key);
            Console.WriteLine("\nStudent Club");
            foreach (var s in studentClub)
            {
                Console.WriteLine(s);
            }

            var studentGPA2 = studentGPAList.Where(s => s.GPA > 2.5 && s.GPA < 4.0).Select(s => s.StudentID);
            Console.WriteLine("\nStudent GPA between 2.5 and 4.0");
            foreach (var s in studentGPA2)
            {
                Console.WriteLine(s);
            }

            var averageTuition = studentList.Average(s => s.Tuition);
            Console.WriteLine($"\nAverage Tuition: {averageTuition}");

            var studentTuition = studentList.Max(s => s.Tuition);
            foreach (var s in studentList)
            {
                if (s.Tuition == studentTuition)
                {
                    Console.WriteLine($"Name: {s.StudentName} Major: {s.Major} Tuition: {s.Tuition}");
                }
            }
            var joinedList = studentList.Join(studentGPAList, s => s.StudentID, g => g.StudentID, (s, g) => new { s.StudentName, s.Major, g.GPA });
            Console.WriteLine("\nJoined List");
            foreach (var s in joinedList)
            {
                Console.WriteLine($"Name: {s.StudentName}, Major: {s.Major}, GPA: {s.GPA}");
            }

            var joinedList2 = studentList.Join(studentClubList, s => s.StudentID, c => c.StudentID, (s, c) => new { s.StudentName, c.ClubName }).Where(s => s.ClubName == "Game").Select(s => s.StudentName);
            Console.WriteLine("\nJoined List with club name Game");
            foreach (var s in joinedList2)
            {
                Console.WriteLine(s);
            }

        }
    }

}

namespace clubMemberIndexer
{ 
    class Program
    {
        public const int Size = 15;  // global variable
        static void Main(string[] args)
        {
            ClubMembers club = new ClubMembers();

            club[0] = "Liam";
            club[1] = "John";
            club[2] = "Mary";

            club.ClubType = "Chess Club";
            club.ClubLocation = "My house";
            club.MeetingDate = "Every Monday at 3pm";

            Console.WriteLine($"Club Type: {club.ClubType} \nClubLocation: {club.ClubLocation} Meeting Date: {club.MeetingDate}");
            Console.WriteLine("Club Members: ");
            for(int i = 0; i < Size; i++ )
            {
                if (club[i] != "")
                {
                    Console.WriteLine(club[i]);
                }
            }
        }


        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = "";
                }
                ClubType = "";
                ClubLocation = "";
                MeetingDate = "";
            }

            //indexer get and set methods
            public string this[int index]
            {
                get { return Members[index]; }
                set { Members[index] = value; }
            }

        }
    }
}
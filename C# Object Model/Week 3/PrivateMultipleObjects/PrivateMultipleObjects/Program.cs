using System;
using System.Runtime.CompilerServices;

namespace Inheritance
{
    class Club
    {
        private string _Name;
        private int _Members;
        private int _Fee;

        public Club(string name, int members, int fee)
        {
            _Name = name;
            _Members = members;
            _Fee = fee;
        }

        public Club()
        {
            _Name = "";
            _Members = 0;
            _Fee = 0;
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Members
        {
            get { return _Members; }
            set { _Members = value; }
        }

        public int Fee
        {
            get { return _Fee; }
            set { _Fee = value; }
        }

        public virtual void addChange()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("Members: ");
            Members = int.Parse(Console.ReadLine());

            Console.Write("Fee: $");
            Fee = int.Parse(Console.ReadLine());
        }

        public virtual void display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Members: {Members}");
            Console.WriteLine($"Fee: ${Fee}");
        }
    }

    class GamingClub : Club
    {
        private string _Game;
        private string _Motto;

        public GamingClub(string name, int members, int fee, string game, string motto) :base(name, members, fee)
        {
            _Game = game;
            _Motto = motto;
        }

        public GamingClub(): base()
        {
            _Game = "";
            _Motto = "";
        }

        public string Game
        {
            get { return _Game; }
            set { _Game = value; }
        }

        public string Motto
        {
            get { return _Motto; }
            set { _Motto = value; }
        }

        public override void addChange()
        {
            base.addChange();
            
            Console.Write("Game: ");
            Game = Console.ReadLine();

            Console.Write("Motto: ");
            Motto = Console.ReadLine();
        }

        public override void display()
        {
            base.display();
            Console.WriteLine($"Game: {Game}");
            Console.WriteLine($"Motto: \"{Motto}\"");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many clubs do you want to add?");
            int maxClubs;
            while (!int.TryParse(Console.ReadLine(), out maxClubs))
            {
                Console.WriteLine("Enter a whole number");
            }
            Club[] clubs = new Club[maxClubs];


            Console.WriteLine("How many gaming clubs do you want to add?");
            int maxGaming;
            while(!int.TryParse(Console.ReadLine(), out maxGaming))
            {
                Console.WriteLine("Enter a whole number");
            }
            GamingClub[] gClub = new GamingClub[maxGaming];

            int choice, rec, type;
            int cCounter = 0, gCounter = 0;
            choice = Menu();

            while(choice != 4)
            {
                Console.WriteLine("Enter 1 for base club or 2 for gaming club");
                while (!int.TryParse(Console.ReadLine(), out type))
                    Console.WriteLine("1 for base club or 2 for gaming club");
                try
                {
                    switch (choice)
                    {
                        case 1:
                            if (type == 1) //base club
                            {
                                if (cCounter <= maxClubs)
                                {
                                    clubs[cCounter] = new Club();
                                    clubs[cCounter].addChange();
                                    cCounter++;
                                }
                                else
                                {
                                    Console.WriteLine("The maximum number of clubs has been added");
                                }
                            } else
                            {
                                if (gCounter <= maxGaming)
                                {
                                    gClub[gCounter] = new GamingClub();
                                    gClub[gCounter].addChange();
                                    gCounter++;
                                }
                                else
                                {
                                    Console.WriteLine("The maximum number of gaming clubs has been added");
                                }
                            }
                            break;

                        case 2:
                            Console.Write("Enter the record number you want to change: ");
                            while (!int.TryParse(Console.ReadLine(), out rec))
                                Console.Write("Enter the record number you want to change: ");
                            rec--;
                            if (type == 1)
                            {
                                while (rec > maxClubs - 1 || rec < 0)
                                {
                                    Console.WriteLine("The number you entered was out of the range");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                clubs[rec].addChange();
                            } else
                            {
                                while (rec > maxGaming - 1 || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range, try again");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                gClub[rec].addChange();
                            }
                            break;

                        case 3:
                            if (type == 1)
                            {
                                for (int i = 0; i < cCounter; i++)
                                    clubs[i].display();
                            } else
                            {
                                for (int i = 0; i < gCounter; i++)
                                    gClub[i].display();
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid selection, try again");
                            break;
                    }
                }

                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                choice = Menu();
            }
            
        }
        private static int Menu()
        {
            Console.WriteLine("Make a selection from the menu");
            Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            int selection = 0;
            while (selection < 1 || selection > 4)
                while (!int.TryParse(Console.ReadLine(), out selection))
                    Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            return selection;
        }
    }
}
using System;

namespace myProject
{
    class Game
    {
        private int _Id;
        private string _Name;
        private double _Price;

        public Game()
        {
            _Id = 0;
            _Name = "";
            _Price = 0;
        }

        public Game(int id, string name, double price)
        {
            _Id = id;
            _Name = name;
            _Price = price;
        }
        public int GetId()
        {
            return _Id;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        public string GetName()
        {
            return _Name;
        }

        public void SetName(string name)
        {
            _Name = name;
        }

        public double GetPrice()
        {
            return _Price;
        }

        public void SetPrice(double price)
        {
            _Price = price;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.SetId(1);
            game1.SetName("Minecraft");
            game1.SetPrice(29.99);

            Game game2 = new Game();
            Console.Write("Enter the game ID: ");
            game2.SetId(int.Parse(Console.ReadLine()));
            Console.Write("Enter game name: ");
            game2.SetName(Console.ReadLine());
            Console.Write("Enter game price: $");
            game2.SetPrice(double.Parse(Console.ReadLine()));

            Game game3 = new Game(3, "Terraria", 10.00);

            Console.Write("Enter game ID: ");
            int tempId = int.Parse(Console.ReadLine());
            Console.Write("Enter game name: ");
            string tempName = Console.ReadLine();
            Console.Write("Enter game price: $");
            double tempPrice = double.Parse(Console.ReadLine());
            Game game4 = new Game(tempId, tempName, tempPrice);

            displayGames(game1);
            displayGames(game2);
            displayGames(game3);
            displayGames(game4);
        }

        static void displayGames(Game game)
        {
            Console.WriteLine("----------Game Information----------");
            Console.WriteLine($"Game Name: {game.GetName()}");
            Console.WriteLine($"Game Price: ${game.GetPrice()}");
            Console.WriteLine($"Game ID: {game.GetId()}");
        }
    }
}
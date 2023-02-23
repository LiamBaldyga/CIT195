namespace VehicleInterface
{
    interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int Year { get; set; }

        void Display();
    }

    class Car : IVehicle
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }

        public Car(string make, string model, int year)
        {
            Make = make;
            Year = year;
            Model = model;
        }

        public void Display()
        {
            Console.WriteLine($"Make: {Make} \nModel: {Model} \nYear: {Year}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Jeep", "Grand Cherokee", 2005);
            myCar.Display();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter two doubles");
        Console.Write("Double 1: ");
        double d1 = double.Parse(Console.ReadLine());
        Console.Write("Double 2: ");
        double d2 = double.Parse(Console.ReadLine());

        var sum = (double x, double y) => x + y;
        Console.WriteLine($"Addition of {d1} and {d2} is {sum(d1, d2)}");

        var product = (double x, double y) => x * y;
        Console.WriteLine($"Multiplication of {d1} and {d2} is {product(d1, d2)}");

        var smaller = (double x, double y) => x < y ? x : y;
        Console.WriteLine($"Smaller number between {d1} and {d2} is {smaller(d1, d2)}");


    }
}
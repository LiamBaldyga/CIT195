using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        Console.WriteLine("How many random integers do you want?");
        int count = int.Parse(Console.ReadLine());
        int[] numbers = new int[count];
        for (int i = 0; i < count; i++)
        {
            numbers[i] = r.Next(1, 10);
            Console.WriteLine($"Random number {i+1} is: {numbers[i]}");
        }

        Console.WriteLine($"The sum of the numbers is: {Add(numbers)}" );
        Console.WriteLine($"The product of the numbers is: {Multiply(numbers)}");
    }
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }

}
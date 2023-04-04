namespace OperatorOverloadingEx1
{
    public class Calculator
    {
        public int number { get; set; }
        public static Calculator operator ++(Calculator c)
        {
            c.number += 1;
            return c;
        }

        public static Calculator operator --(Calculator c)
        {
            c.number -= 1;
            return c;
        }

        public static bool operator <(Calculator c1, Calculator c2)
        {
            return c1.number < c2.number;
        }

        public static bool operator >(Calculator c1, Calculator c2)
        {
            return c1.number > c2.number;
        }

        public static Calculator operator +(Calculator c1, Calculator c2)
        {
            Calculator c = new Calculator();
            c.number = c1.number + c2.number;
            return c;
        }

        public static Calculator operator -(Calculator c1, Calculator c2)
        {
            Calculator c = new Calculator();
            c.number = c1.number - c2.number;
            return c;
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            // create object array
            Calculator[] numbers = new Calculator[10];
            // place random numbers into array and print values
            Console.Write("Original Numbers= ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Calculator(); // creates the object
                numbers[i].number = r.Next(1, 100);  // places a value in the object
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();
            // if divisible by 2, add 1 to value using operator ++ method
            // otherwise subtract 1 from value using operator -- method
            Console.Write("New Numbers +1 or -1= ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].number % 2 == 0)
                {
                    numbers[i]++;
                }
                else
                {
                    numbers[i]--;
                }
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

            // random Calculator object to add
            Calculator numToAdd = new Calculator();
            numToAdd.number = r.Next(1, 20);
            // Using operator +, add numToAdd.number to each element in the array
            // Print the results
            Console.Write($"Numbers + {numToAdd.number} = ");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += numToAdd;
                Console.Write(" " + numbers[i].number);
            }

            Console.WriteLine();

            // random Calculator object to subtract
            Calculator numToSub = new Calculator();
            numToSub.number = r.Next(1, 20);
            // Using operator -, subtract numToSub.number from each element in the array
            // Print the results
            Console.Write($"Numbers - {numToSub.number}= ");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] -= numToSub;
                Console.Write(" " + numbers[i].number);
            }

            Console.WriteLine();

            // random Calculator object for comparison
            Calculator numToCompare = new Calculator();
            numToCompare.number = r.Next(1, 100);
            // Using operator > and operator <, compare each element to numToCompare.number
            // print if the element is higher, lower or equal to the number you are comparing to
            Console.WriteLine($"Numbers above or below {numToCompare.number}");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < numToCompare)
                {
                    Console.WriteLine($"{numbers[i].number} is lower.");
                }
                else if (numbers[i] > numToCompare)
                {
                    Console.WriteLine($"{numbers[i].number} is higher.");
                }
                else
                {
                    Console.WriteLine($"{numbers[i].number} is equal.");
                }
            }
        }
    }
}
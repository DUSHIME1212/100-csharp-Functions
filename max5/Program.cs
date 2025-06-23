class Program
{
    static void Main(string[] args)
    {
        // Write a function named max5 that receives 5 numbers as parameters and returns the biggest one between them.
        double num1, num2, num3, num4, num5;
        // Prompt the user for input and read the numbers
        Console.WriteLine("Enter the first number:");
        num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the first number:");
        num2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the first number:");
        num3 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the first number:");
        num4 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the first number:");
        num5 = Convert.ToDouble(Console.ReadLine());
        
        
        double[] numbers = { num1, num2, num3, num4, num5 };
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        // Displaying the result
        Console.WriteLine($"The biggest number between {num1}, {num2}, {num3}, {num4}, and {num5} is: {max}");
    }
}

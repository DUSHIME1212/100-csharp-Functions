class  Program
{
    static void Main(string[] args)
    {
        
        double num1, num2, num3, num4;

        // Prompt the user for input and read the numbers
        Console.WriteLine("Enter the first number:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        num3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the fourth number:");
        num4 = Convert.ToDouble(Console.ReadLine());

        // Calculate the average
        double average = (num1 + num2 + num3 + num4) / 4;

        // Display the result
        Console.WriteLine($"The average of {num1}, {num2}, {num3}, and {num4} is: {average}");
    }
}

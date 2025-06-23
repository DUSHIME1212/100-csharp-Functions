class  Program
{
    public static int getMonthsNeededToWait(int month1, int month2)
    {
        // Calculate the number of months needed to wait
        if (month2 >= month1)
        {
            return month2 - month1;
        }
        else
        {
            return (12 - month1) + month2;
        }
    }
    static void Main(string[] args)
    {
        // Write a function name getMonthsNeededToWait that receives 2 numbers as parameters, representing the index of two month
        //The function should return the number of months we have to wait, to get from the first month to the second one.
        int month1, month2;
        // Prompt the user for input and read the months
        Console.WriteLine("Enter the first month index (1-12):");
        month1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second month index (1-12):");
        month2 = Convert.ToInt32(Console.ReadLine());
        // Validate the input
        if (month1 < 1 || month1 > 12 || month2 < 1 || month2 > 12)
        {
            Console.WriteLine("Invalid month index. Please enter a number between 1 and 12.");
            return;
        }
        // Call the function to get the number of months needed to wait
        int monthsNeeded = getMonthsNeededToWait(month1, month2);
        // Display the result
        Console.WriteLine($"You need to wait {monthsNeeded} month(s) to get from month {month1} to month {month2}.");
    }
}

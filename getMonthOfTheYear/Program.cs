// 18.getMonthOfTheYear
// Write a function named getMonthOfTheYear that receives a Date as a parameter and returns the month of the year as a human-readable string, in English.
//
// Example 1 Input date = Date Wed Dec 25 2024 18:15:00 GMT+0200 (Central Africa Time)
// Output
// "December"

class Program
{
    public static string getMonthOfTheYear(DateTime date)
    {
        return date.ToString("MMMM");
    }

    static void Main(string[] args)
    {
        DateTime inputDate = new DateTime(2024, 12, 25, 18, 15, 0);
        
        string month = getMonthOfTheYear(inputDate);
        
        Console.WriteLine($"The month of the year is: {month}");
    }
}
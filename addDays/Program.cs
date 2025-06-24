// 19.addDays
// Write a function named addDays that receives 2 parameters:
//
// a date - initialDate
// a number - daysCount
// and returns a new date created by adding daysCount days to initialDate.

// Input initialDate = Date Mon May 01 2023 12:00:00 GMT+0200 (Central Africa Time) 
// daysCount = 11

class Program
{
    public static DateTime addDays(DateTime initialDate, int daysCount)
    {
        return initialDate.AddDays(daysCount);
    }

    static void Main(string[] args)
    {
        DateTime initialDate = new DateTime(2023, 5, 1, 12, 0, 0);
        int daysCount = 11;

        DateTime newDate = addDays(initialDate, daysCount);

        Console.WriteLine($"New date after adding {daysCount} days: {newDate.ToString("yyyy-MM-dd")}");
    }
}
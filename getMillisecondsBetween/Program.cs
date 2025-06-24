// 17.getMillisecondsBetween
// Write a function named getMillisecondsBetween that receives 2 dates as parameters and returns the number of milliseconds between them.
//
// Example 1
// Input
// date1 = Date Wed Mar 02 2005 12:01:15 GMT+0200 (Central Africa Time)
// date2 = Date Wed Mar 02 2005 12:00:05 GMT+0200 (Central Africa Time)
// Output
// 70000

class Program
{
    public static long getMillisecondsBetween(DateTime date1, DateTime date2)
    {
        return Math.Abs((date1 - date2).Ticks);
    }

    static void Main(string[] args)
    {
        DateTime date1 = new DateTime(2005, 3, 2, 12, 1, 15);
        DateTime date2 = new DateTime(2005, 3, 2, 12, 0, 5);

        long millisecondsBetween = getMillisecondsBetween(date1, date2);
        
        Console.WriteLine($"Milliseconds between the two dates: {millisecondsBetween}");
    }
}
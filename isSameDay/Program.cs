// 24.isSameDay
// Write a function named isSameDay that receives 2 Dates as parameters, and checks if they represent the same day, month and year.
//
//     Example 1
// Input
//     date1
//
//         =
//         Date Sat Nov 10 2007 12:00:00 GMT+0200 (Central Africa Time)
// date2
//
//     =
//     Date Wed Dec 10 2008 13:00:00 GMT+0200 (Central Africa Time)
// Output
// false

class Program
{
    public static bool isSameDay(DateTime date1, DateTime date2)
    {
        return date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day;
    }

    static void Main(string[] args)
    {
        DateTime date1 = new DateTime(2007, 11, 10, 12, 0, 0);
        DateTime date2 = new DateTime(2008, 12, 10, 13, 0, 0);

        bool result = isSameDay(date1, date2);

        Console.WriteLine($"Are the two dates on the same day? {result}");
    }
}
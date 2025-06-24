// 31.countPageViews
// Write a function named countPageViews that receives 3 parameters:
//
// pageViews - an Array of objects describing views of our page. Each object contains the number of views from a particular country, at a particular time and has the following properties:
//
// date - a Date
// country - a string representing a country code
// count - a number
// country - a string representing a country code
//
// interval - an object with 2 properties, startDate and endDate - each of them Dates
//
//     The function should return the number of page views from that country between those 2 dates (inclusive).
//
//     Example 1
// Input
//     pageViews
//
//         =
//         Array(5)
// 0: { count: 104, country: "RO", date: Date Wed May 10 2023 12:00:00 GMT+0200 (Central Africa Time) }
// 1: { count: 151, country: "USA", date: Date Fri May 05 2023 12:00:00 GMT+0200 (Central Africa Time) }
// 2: { count: 67, country: "RO", date: Date Sun May 07 2023 12:00:00 GMT+0200 (Central Africa Time) }
// 3: { count: 89, country: "CA", date: Date Wed May 10 2023 12:00:00 GMT+0200 (Central Africa Time) }
// 4: { count: 500, country: "RO", date: Date Fri May 12 2023 14:00:00 GMT+0200 (Central Africa Time) }
// <prototype>: (0) [ ]
// country
//
//     =
//     "RO"
// interval
//
//     =
// {…}
// endDate: Date Fri May 12 2023 12:00:00 GMT+0200 (Central Africa Time)
// startDate: Date Mon May 01 2023 12:00:00 GMT+0200 (Central Africa Time)
//     <prototype>: Object
//     Output
// 171

class Program
{
    public static int countPageViews(object[] pageViews, string country, DateTime startDate, DateTime endDate)
    {
        int totalCount = 0;

        foreach (var view in pageViews)
        {
            var pageView = view as dynamic;
            if (pageView.country == country && 
                pageView.date >= startDate && 
                pageView.date <= endDate)
            {
                totalCount += pageView.count;
            }
        }

        return totalCount;
    }

    static void Main(string[] args)
    {
        var pageViews = new object[]
        {
            new { date = new DateTime(2023, 5, 10), country = "RO", count = 104 },
            new { date = new DateTime(2023, 5, 5), country = "USA", count = 151 },
            new { date = new DateTime(2023, 5, 7), country = "RO", count = 67 },
            new { date = new DateTime(2023, 5, 10), country = "CA", count = 89 },
            new { date = new DateTime(2023, 5, 12), country = "RO", count = 500 }
        };

        string country = "RO";
        DateTime startDate = new DateTime(2023, 5, 1);
        DateTime endDate = new DateTime(2023, 5, 12);

        int result = countPageViews(pageViews, country, startDate, endDate);
        Console.WriteLine(result); // Output: 171
    }
}
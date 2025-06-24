// 26.arrayToObject
// Write a function named arrayToObject that receives an array of strings as parameter and returns an object where each key is an item of the array and its value is the index of that item.
//
//     If there are duplicate strings in the array, the value inside the object should be the index of it's first occurrence.
//
//     Example 1
// Input
//     strings
//
//         =
//         Array(3)
// 0: "JavaScript"
// 1: "is"
// 2: "awesome"
//     <prototype>: (0) [ ]
// Output
// {…}
// JavaScript: 0
// awesome: 2
//     is: 1
//     <prototype>: Object

class Program
{
    public static object arrayToObject(string[] strings)
    {
        var result = new System.Dynamic.ExpandoObject() as IDictionary<string, object>;
        
        for (int i = 0; i < strings.Length; i++)
        {
            if (!result.ContainsKey(strings[i]))
            {
                result[strings[i]] = i;
            }
        }
        
        return result;
    }

    static void Main(string[] args)
    {
        string[] inputArray = { "JavaScript", "is", "awesome", "JavaScript" };
        
        var result = arrayToObject(inputArray);
        
        foreach (var kvp in (IDictionary<string, object>)result)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
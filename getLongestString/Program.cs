// 13.getLongestString
// Write a function named getLongestString that receives an Array of strings as parameter and returns the longest one.
//
//     If the Array is empty, return an empty string.
//
//     If there are multiple strings of the same maximum length, return the first one.

class Program
{
    public static string getLongestString(string[] strings)
    {
        if (strings.Length == 0)
        {
            return string.Empty; 
        }
        
        string longestString = strings[0];
        
        foreach (string word in strings)
        {
            if (word.Length > longestString.Length)
            {
                longestString = word;
            }
        }
        
        return longestString;
    }

    static void Main(string[] args)
    {
        string[] inputStrings = { "apple", "banana", "cherry", "date" };
        
        string result = getLongestString(inputStrings);
        
        Console.WriteLine($"The longest string is: {result}");
    }
}
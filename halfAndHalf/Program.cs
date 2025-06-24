// Write a function named halfAndHalf that takes a string as parameter.
//
//     The function should return the same string with the first half of the string in lowercase and the second half in uppercase.
//
//     Example 1
// Input text= "Hello World"
// Output
// "hello WORLD"

class Program
{
    public static string halfAndHalf(string text)
    {
        int mid = text.Length / 2;
        string firstHalf = text.Substring(0, mid).ToLower();
        string secondHalf = text.Substring(mid).ToUpper();
        return firstHalf + secondHalf;
    }

    static void Main(string[] args)
    {
        string inputText = "Hello World";
        
        string result = halfAndHalf(inputText);
        
        Console.WriteLine($"Transformed text: {result}");
    }
}
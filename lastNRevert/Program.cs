// Write a function named lastNRevert that receives 2 parameters:
// - a string named text
// - a number - n
// and returns the last n characters of text but in reverse order.

class program
{
    public static string lastNRevert(string text, int n)
    {
        
        if (n > text.Length)
        {
            n = text.Length;
        }
        
        
        string lastNChars = text.Substring(text.Length - n);
        char[] charArray = lastNChars.ToCharArray();
        Array.Reverse(charArray);
        
        return new string(charArray);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string inputText = Console.ReadLine();
        
        Console.WriteLine("Enter a number (n):");
        int n = Convert.ToInt32(Console.ReadLine());
        
        string result = lastNRevert(inputText, n);
        
        Console.WriteLine($"The last {n} characters in reverse order: {result}");
    }
}
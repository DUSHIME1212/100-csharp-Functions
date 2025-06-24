// Write a function named mostRepetitions that receives 3 parameters:
//
// a string - string1
// a string - string2
// a letter
// and returns the string that has the most occurrences of the specified letter.
// If both have the same number of occurrences return string1.

class Program
{
    public static string mostRepetitions(string string1, string string2, char letter)
    {
        int count1 = CountOccurrences(string1, letter);
        int count2 = CountOccurrences(string2, letter);

        if (count1 >= count2)
        {
            return string1;
        }
        else
        {
            return string2;
        }
    }

    private static int CountOccurrences(string str, char letter)
    {
        int count = 0;
        foreach (char character in str)
        {
            if (character == letter)
            {
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter first string:");
        string str1 = Console.ReadLine();
        
        Console.WriteLine("Enter second string:");
        string str2 = Console.ReadLine();
        
        Console.WriteLine("Enter the letter to count:");
        char letter = Console.ReadKey().KeyChar;
        
        Console.WriteLine();

        string result = mostRepetitions(str1, str2, letter);
        
        Console.WriteLine($"The string with the most occurrences of '{letter}' is: {result}");
    }
}
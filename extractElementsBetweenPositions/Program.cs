// 21.extractElementsBetweenPositions
// Write a function named extractElementsBetweenPositions that receives 3 parameters:
//
// an Array of numbers - numbers
// a number - n
// a number - m
// and returns a new Array containing all elements that have their position between n and m (both included).
//
// NOTE: there's no guarantee that n is lower than m.
//
//     Example 1
// Input
//     numbers
//
//         =
//         Array(15)
// 0: 10
// 1: 24
// 2: 7
// 3: 42
// 4: 15
// 5: 8
// 6: 33
// 7: 19
// 8: 56
// 9: 91
// 10: 3
// 11: 28
// 12: 12
// 13: 50
// 14: 67
//     <prototype>: (0) [ ]
// n
//
//     =
//     4
// m
//
//     =
//     11

class Program
{
    public static int[] extractElementsBetweenPositions(int[] numbers, int n, int m)
    {
        // if n is greater than m
        if (n > m)
        {
            int temp = n;
            n = m;
            m = temp;
        }

        // Calculate the length of the new array
        int length = Math.Max(0, m - n + 1);
        int[] result = new int[length];

        // Copy elements from the original array to the new array
        for (int i = 0; i < length; i++)
        {
            if (n + i < numbers.Length)
            {
                result[i] = numbers[n + i];
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 10, 24, 7, 42, 15, 8, 33, 19, 56, 91, 3, 28, 12, 50, 67 };
        int n = 4;
        int m = 11;

        int[] extractedElements = extractElementsBetweenPositions(numbers, n, m);

        Console.WriteLine($"Extracted elements: {string.Join(", ", extractedElements)}");
    }
}
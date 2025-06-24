// 11.areAllNumbersEven
// Write a function named areAllNumbersEven that receives an Array of numbers as parameter, and returns a boolean indicating if all the numbers are even or not.
//
//     Example 1
// Input
//     numbers
//
//         =
//         Array(4)
// 0: 4
// 1: 6
// 2: -8
// 3: 14
//     <prototype>: (0) [ ]
// Output
// true

class Program
{
    public static bool areAllNumbersEven(int[] numbers)
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                return false; 
            }
        }
        return true; 
    }

    static void Main(string[] args)
    {
        int[] numbers = { 4, 6, -8, 14 };
        
        bool result = areAllNumbersEven(numbers);
        
        Console.WriteLine($"Are all numbers even? {result}");
    }
}
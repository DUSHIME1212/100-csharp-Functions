// 22.isSorted
// Write a function named isSorted that receives an Array of numbers as parameter and returns true if the list is sorted (either ascending or descending).
//
// Example 1
// Input numbers =  Array(3)
// 0: 19
// 1: 10
// 2: 23
//     <prototype>: (0) [ ]
// Output
// false

class  Program
{
    public static bool isSorted(int[] numbers)
    {
        if (numbers.Length < 2) return true; 

        bool ascending = true;
        bool descending = true;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                descending = false;
            }
            else if (numbers[i] > numbers[i + 1])
            {
                ascending = false;
            }
        }

        return ascending || descending;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 19, 10, 23 };
        
        bool result = isSorted(numbers);
        
        Console.WriteLine($"Is the array sorted? {result}");
    }
}
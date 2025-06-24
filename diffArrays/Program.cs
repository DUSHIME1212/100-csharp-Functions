

class Program
{
    static void Main(string[] args)
    {
        // Example arrays
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 4, 5, 6, 7, 8 };

        // Get the differences
        var differences = DiffArrays(array1, array2);

        // Print the differences
        foreach (var item in differences)
        {
            Console.WriteLine(item);
        }
    }

    static IEnumerable<int> DiffArrays(int[] arr1, int[] arr2)
    {
        return arr1.Except(arr2).Concat(arr2.Except(arr1));
    }
}
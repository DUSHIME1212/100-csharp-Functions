// 12.getBiggestNumberInArrays
// Write a function named getBiggestNumberInArrays that receives 2 parameters:
//
// an array of numbers named numbers1
// another array of numbers named numbers2
// and returns the maximum number between those 2 arrays.#

class Program
{
    public static double getBiggestNumberInArrays(double[] numbers1, double[] numbers2)
    {
        double max1 = numbers1.Length > 0 ? numbers1[0] : double.MinValue;
        double max2 = numbers2.Length > 0 ? numbers2[0] : double.MinValue;

        foreach (double number in numbers1)
        {
            if (number > max1)
            {
                max1 = number;
            }
        }

        foreach (double number in numbers2)
        {
            if (number > max2)
            {
                max2 = number;
            }
        }

        return Math.Max(max1, max2);
    }

    static void Main(string[] args)
    {
        double[] array1 = { 3.5, 7.2, 9.8 };
        double[] array2 = { 5.6, 8.3, 10.1 };

        double biggestNumber = getBiggestNumberInArrays(array1, array2);
        
        Console.WriteLine($"The biggest number between the two arrays is: {biggestNumber}");
    }
}
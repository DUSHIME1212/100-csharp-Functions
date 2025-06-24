// 32.linkedNumbersSum
// Write a function named linkedNumbersSum that receives one parameter
//
//     an object representing the start node of a linked list. It has 2 properties:
// value - representing a number
// next - representing the next node in the linked list (or null if there is no next node)
// The function should return the sum of all the numbers in the linked list.
//
//     Example 1
// Input
//     node
//
//         =
//         {…}
// next: { next: {…}, value: 2 }
// value: 1
//     <prototype>: Object
//     Output
// 6
// Explanation
//     We have a linked list with 3 nodes. The sum of the values of the nodes is 6.

class Program
{
    public static int linkedNumbersSum(dynamic node)
    {
        int sum = 0;
        while (node != null)
        {
            sum += node.value;
            node = node.next;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        var linkedList = new
        {
            value = 1,
            next = new
            {
                value = 2,
                next = new
                {
                    value = 3,
                    next = (object)null
                }
            }
        };

        int result = linkedNumbersSum(linkedList);
        Console.WriteLine(result);
    }
}
// 14.everyNPositions
// Write a function named everyNPositions that receives 2 parameters:
//
// a string - message
// a number - step
// and returns a new string composed of all characters from message that are on positions divisible by step.

using System.Text;

class Program
{
    public static string everyNPositions(string message, int step)
    {
        if (step <= 0)
        {
            throw new ArgumentException("Step must be greater than 0.");
        }

        char[] result = new char[(message.Length)];

        for (int i = 0; i < message.Length; i++)
        {
            if (i % step == 0)
            {
                result.Append(message[i]);
            }
        }

        return result.ToString();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a message:");
        string inputMessage = Console.ReadLine();

        Console.WriteLine("Enter a step number:");
        int step = Convert.ToInt32(Console.ReadLine());

        string result = everyNPositions(inputMessage, step);

        Console.WriteLine($"Characters at every {step} positions: {result}");
    }
}
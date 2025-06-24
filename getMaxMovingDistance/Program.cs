// 25.getMaxMovingDistance
// You're accepting a job in a new town and have a lot of furniture to move. Write a function named getMaxMovingDistance that receives 3 numbers as parameters:
//
// your total budget for moving the furniture (in USD) - budget
// the weight of all your furniture (in kg) - weight
// how much moving 10kg for 100km costs (in USD) - cost
// The function should return the maximum number of kilometers that we can afford to move the all furniture.
//
//     Example 1
// Input
//     budget
//
//         =
//         700
// weight
//
//     =
//     440
// cost
//
//     =
//     50
// Output
// 31.8181

class Program
{
    public static double getMaxMovingDistance(double budget, double weight, double cost)
    {
        if (cost <= 0 || weight <= 0) return 0;

        double totalCostPerKg = cost / 10; 
        double totalCost = totalCostPerKg * weight; 

        if (totalCost > budget) return 0; 

        double maxDistance = (budget / totalCost) * 100;
        return maxDistance;
    }

    static void Main(string[] args)
    {
        double budget = 700;
        double weight = 440;
        double cost = 50;

        double maxDistance = getMaxMovingDistance(budget, weight, cost);
        
        Console.WriteLine($"The maximum distance we can afford to move the furniture is: {maxDistance:F4} km");
    }
}
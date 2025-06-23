// You're driving to a new city for a small weekend trip. Write a function named getGasolineAmount that receives 2 numbers as parameters:
// - the number of kilometers to your destination
// - average consumption of liters per 100km
// The function should return the amount of gasoline needed to complete the entire round-trip.

class MyClass

{
    public static double getGasolineAmount(double kilometers, double consumption)
    {
        double totalDistance = kilometers * 2;

        double gasolineNeeded = (totalDistance * consumption) / 100;

        return gasolineNeeded;
    }
    static void main(string[] args)
    {
        Console.WriteLine("Enter the number of kilometers to your destination:");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the average consumption of liters per 100km:");
        double consumption = Convert.ToDouble(Console.ReadLine());
        double gasolineNeeded = getGasolineAmount(kilometers, consumption);

        Console.WriteLine($"You will need {gasolineNeeded} liters of gasoline for the round-trip.");
    }
}
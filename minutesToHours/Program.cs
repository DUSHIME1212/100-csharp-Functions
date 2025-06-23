using System;

class Program
{
    public static void minutesToHours(int minutes)
    {
        int hours = minutes / 60;
        int remainingMinutes = minutes % 60;
        Console.WriteLine($"{hours} hour(s) and {remainingMinutes} minute(s)");
    }

    public static void Main(string[] args)
    {
        minutesToHours(130); 
        minutesToHours(45);  
        minutesToHours(120);
    }
}
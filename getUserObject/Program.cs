// Write a function named getUserObject that receives 3 parameters:
//
// a string named firstName
//     a string named lastName
//     a number named age
// and returns an object representing an user, with the properties name and age.

class Myprogram
{
    public dynamic getUserObject(string firstName, string lastName, int age)
    {
        // Create an anonymous object representing the user
        return new
        {
            name = $"{firstName} {lastName}",
            age = age
        };
    }
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine();
        
        Console.WriteLine("Enter your last name:");
        string lastName = Console.ReadLine();
        
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        
        Myprogram program = new Myprogram();
        var userObject = program.getUserObject(firstName, lastName, age);
        
        Console.WriteLine($"User Object: Name - {userObject.name}, Age - {userObject.age}");
    }
}
// 20.getDevelopers
// Write a function named getDevelopers that receives an Array of employees as parameter.
//
//     Each employee has the following props:
//
// name - a string
// job - one of the following values: developer, designer, manager
// age - a number
//     The function should return a new Array with all the employees that are developers.


class Program
{
    public static dynamic[] getDevelopers(dynamic[] employees)
    {
        return Array.FindAll(employees, employee => employee.job == "developer");
    }

    static void Main(string[] args)
    {
        dynamic[] employees = new dynamic[]
        {
            new { name = "Alice", job = "developer", age = 28 },
            new { name = "Bob", job = "designer", age = 35 },
            new { name = "Charlie", job = "manager", age = 42 },
            new { name = "David", job = "developer", age = 31 }
        };

        dynamic[] developers = getDevelopers(employees);
        
        foreach (var developer in developers)
        {
            Console.WriteLine($"Name: {developer.name}, Job: {developer.job}, Age: {developer.age}");
        }
    }
}
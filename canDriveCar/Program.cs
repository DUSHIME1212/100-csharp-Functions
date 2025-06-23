// 10.canDriveCar
// Write a function named canDriveCar that receives 2 parameters:
//
// an object named user
//     an object named car
//     and returns a boolean indicating if the user can drive the car or not.
//
//     Note: anybody can drive a car if it has at least 18 years old or if the car has an engine smaller than 1000cc.

class Program
{
    public static bool canDriveCar(dynamic user, dynamic car)
    {
        return user.age >= 18 || car.engineSize < 1000;
    }

    static void Main(string[] args)
    {
        
        var user = new { age = 20 };
        
        var car = new { engineSize = 900 };

        bool canDrive = canDriveCar(user, car);

        Console.WriteLine($"Can the user drive the car? {canDrive}");
    }
}
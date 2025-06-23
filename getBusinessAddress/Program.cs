// // Write a function named getBusinessAddress that receives an Object representing a business as a parameter, and returns a string representation of the it's address.
//
// Input
//     business
//
//         =
//         {…}
// address: { number: 3, street: "Avenuepark", zipCode: 123500 }
// name: "100 Functions ltd."
//     <prototype>: Object
//     Output
// "Avenuepark, number 3, 123500"

class Program
{
    public static string getBusinessAddress(dynamic business)
    {
        
        string street = business.address.street;
        int number = business.address.number;
        int zipCode = business.address.zipCode;
        
        return $"{street}, number {number}, {zipCode}";
    }

    static void Main(string[] args)
    {
        
        var business = new
        {
            name = "100 Functions ltd.",
            address = new
            {
                number = 3,
                street = "Avenuepark",
                zipCode = 123500
            }
        };
        
        string address = getBusinessAddress(business);
        Console.WriteLine(address);
    }
}
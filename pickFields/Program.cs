// 27.pickFields
// Write a function named pickFields that receives 2 parameters:
//
// an object - data
// an Array of strings - fields
// The function should return a new object that contains all properties of data whose name is present in the fields array.
//
//     Example 1
// Input
//     data
//
//         =
//         {…}
// color: "blue"
// name: "Earth"
// solarSistem: "Milky Way"
//     <prototype>: Object
//     fields
//
//         =
//         Array(2)
// 0: "name"
// 1: "color"
//     <prototype>: (0) [ ]
// Output
// {…}
// color: "blue"
// name: "Earth"
//     <prototype>: Object

class Program
{
    public static object pickFields(object data, string[] fields)
    {
        var result = new System.Dynamic.ExpandoObject() as IDictionary<string, object>;
        
        foreach (var field in fields)
        {
            var propertyInfo = data.GetType().GetProperty(field);
            if (propertyInfo != null)
            {
                result[field] = propertyInfo.GetValue(data);
            }
        }
        
        return result;
    }

    static void Main(string[] args)
    {
        var data = new
        {
            color = "blue",
            name = "Earth",
            solarSystem = "Milky Way"
        };

        string[] fields = { "name", "color" };
        
        var result = pickFields(data, fields);
        
        foreach (var kvp in (IDictionary<string, object>)result)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
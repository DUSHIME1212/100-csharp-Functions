// 29.flipObject
// Write a function named flipObject that receives an Object describing people and their jobs and returns a new object with the jobs as keys, and names as values.
//
// Example 1
// Input people  =  {…}
// alice: "AI Engineer"
// bob: "JS Developer"
// jon: "JS Developer"
// nick: "UX Designer"
// <prototype>: Object
// Output
// {…}
// AI Engineer: (1) [ "alice" ]
// JS Developer: (2) [ "bob", "jon" ]
// UX Designer: (1) [ "nick" ]
// <prototype>: Object

class Program
{
    public static object flipObject(object people)
    {
        var result = new System.Dynamic.ExpandoObject() as IDictionary<string, object>;

        foreach (var kvp in (IDictionary<string, object>)people)
        {
            string job = kvp.Value.ToString();
            string name = kvp.Key;

            if (!result.ContainsKey(job))
            {
                result[job] = new List<string>();
            }

            ((List<string>)result[job]).Add(name);
        }

        return result;
    }

    static void Main(string[] args)
    {
        var people = new
        {
            alice = "AI Engineer",
            bob = "JS Developer",
            jon = "JS Developer",
            nick = "UX Designer"
        };

        var result = flipObject(people);

        foreach (var kvp in (IDictionary<string, object>)result)
        {
            Console.WriteLine($"{kvp.Key}: {string.Join(", ", (List<string>)kvp.Value)}");
        }
    }
}
// 33.getMissingContacts
// Write a function named getMissingContacts that receives one parameter:
//
// a Map of contacts, where the key is a string representing a userId and the value is an array of user ids - contactsMap
// The function should return a new Map, where the values are the contacts missing from each user.
//
//     Example 1
// Input
//     contactsMap
//
//         =
//         Map(3)
//         <entries>: (3) [ {…}, {…}, {…} ]
// size: 3
//     <prototype>: Object
//     Output
// Map(3)
//     <entries>: (3) [ {…}, {…}, {…} ]
// size: 3
//     <prototype>: Object

class  Program {
    public static Dictionary<string, List<string>> getMissingContacts(Dictionary<string, List<string>> contactsMap)
    {
        var result = new Dictionary<string, List<string>>();

        foreach (var user in contactsMap.Keys)
        {
            var missingContacts = new List<string>();
            foreach (var contact in contactsMap.Keys)
            {
                if (contact != user && !contactsMap[user].Contains(contact))
                {
                    missingContacts.Add(contact);
                }
            }
            result[user] = missingContacts;
        }

        return result;
    }

    static void Main(string[] args)
    {
        var contactsMap = new Dictionary<string, List<string>>
        {
            { "user1", new List<string> { "user2", "user3" } },
            { "user2", new List<string> { "user1" } },
            { "user3", new List<string> { "user1" } }
        };

        var result = getMissingContacts(contactsMap);

        foreach (var kvp in result)
        {
            Console.WriteLine($"{kvp.Key}: [{string.Join(", ", kvp.Value)}]");
        }
    }
    
}
// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var obj = new {
    FirstName = "John", 
    LastName = "Smith",
    Address = new {
        Street = "1234 Street St.",
    },
};

Console.WriteLine(obj.FirstName);
Console.WriteLine(obj.LastName);

Console.WriteLine(obj);

// Anonymous types are read-only and cannot be modified
// myobj.Name = "Jane Doe"; # will cause an error

// TODO: To change a value, use non-destructive mutation and "with" clause
var obj2 = obj with { FirstName = "Jane" };
Console.WriteLine(obj2);

// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine($"{obj.GetType().GetProperty("FirstName") is not null}");
Console.WriteLine($"{obj.GetType().GetProperty("Email") is not null}");

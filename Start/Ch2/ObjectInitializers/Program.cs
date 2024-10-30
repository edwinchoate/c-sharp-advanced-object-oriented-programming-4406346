// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers
class Program 
{

    static void Main (string[] args) 
    {
        // TODO: Use the initializer syntax to create new objects
        Dog dog = new Dog { Name="Fido", Age=5, IsTrained=true };
        Cat cat = new Cat { Name="Mr. Meow", Age=3, IsDeclawed=false };

        // TODO: Initializers can be used on anonymous types
        var dog2 = new { Name="Fido", Age=5, IsTrained=true };

        // TODO: Collections can also be initialized this way
        int[] numbers = new int[] {1, 2, 3, 4};

        // TODO: Initialize a collection with a set of objects
        PetOwner owner = new();

        owner.Pets = new List<Pet>
        {
            new Dog { Name="Fido", Age=5, IsTrained=true },
            new Cat { Name="Mr. Meow", Age=3, IsDeclawed=false }
        };
    }

}

// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

class Program
{
    static void Main (string[] args) 
    {

    // TODO: Create some new Rectangle objects with dimensions
    Rectangle rect1 = new Rectangle(10, 20);
    Rectangle rect2 = new Rectangle(30);

    // TODO: Change the values of width and height
    Console.WriteLine(rect1.GetArea());
    Console.WriteLine(rect2.GetArea());

    }

}
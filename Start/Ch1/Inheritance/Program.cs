// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using inheritance to define a class hierarchy

// Instantiate some objects
Circle c = new Circle(10);
Rectangle r = new Rectangle(10,20);
Square s = new Square(20);

// TODO: Exercise the ToString() method
Console.WriteLine(c);
Console.WriteLine(r);

// TODO: Use the "is" operator to test an object type
Console.WriteLine(c is Circle);
Console.WriteLine(c is Shape2D);
Console.WriteLine(r is Circle);

// TODO: Call the GetArea() function on each one
Console.WriteLine(c.GetArea());
Console.WriteLine(r.GetArea());
Console.WriteLine(s.GetArea());

// TODO: Print the area of each shape
void PrintArea (Shape2D shape) 
{
    Console.WriteLine(shape.GetArea());
}


// TODO: All of the classes derive from Shape2D, so we can treat each one
// as an instance of the base class. 
PrintArea(c);
PrintArea(r);
PrintArea(s);

// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Define a class using the "class" keyword

    // TODO: The constructor accepts parameters used to create the object


    // TODO: For convenience, we can have a constructor that takes one value
    // for squares that have the same side size


    // TODO: Classes can define methods that return values


    // TODO: member variables hold data


class Rectangle
{

    int _width;
    int _height;
    
    public Rectangle (int width, int height)
    {
        _width = width;
        _height = height;
    }

    public Rectangle (int side) 
    {
        _width = side;
        _height = side;
    }

    public int GetArea () 
    {
        return _width * _height;
    }

}
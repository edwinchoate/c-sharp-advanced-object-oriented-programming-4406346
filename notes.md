# Notes

## Ch. 1 Object-Oriented Basics

In .NET every class is derived from the [base `Object` class](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-8.0)

* `Object.ToString()`
* `Object.GetType()`

Access modifiers

* `public`
* `private`
* `protected`
* `virtual`
* `override`

.NET uses the terms "base class" and "derived class" (as opposed to super and sub).

Calling a base class' method from inside of a derived class:

```C#
base.SomeMethod();
```

_Anonymous type_ - C#'s way of putting JSON-like unstructured and practically un-typed objects into the code. Anonymous types are read-only.

```C#
var obj = new {
    FirstName = "John", 
    LastName = "Smith",
    Address = new {
        Street = "1234 Street St.",
    },
};
```

In .NET, anonymous types override the Object ToString method to instead print out the object with its key-pair pairs:

```bash
{ FirstName = John, LastName = Smith, Address = { Street = 1234 Street St. } }
```

Since anonymous types are read-only, if you want to change one of the values you have to do so with the `with` keyword, like this: 

```C#
var obj2 = obj with { FirstName = "Jane" };
```

How to check to see if an anonymous type has a specific property: 

```C#
bool hasFirstName = obj.GetType().GetProperty("FirstName") != null;
```

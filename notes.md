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

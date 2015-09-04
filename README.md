# CsUtilities
Small utilities from personnal code I've been using now all in one place, nothing fancy.

## Option
"Maybe"-like extension methods for C#. 
Since C# Nullables are only valid for structs and non-null types, I wanted something that was akin to Java's Optional or Rust's Option.

This is not a replacement for a proper 'Option' class/library though and not a way to justify using nulls in code, use scarcely :)
Maybe it's bad design, but it made code more readable

```csharp
// Useless example, like all examples
Console.Print(AMethodThatMightReturnANullable()
    .Map((obj) => $"You have the number {obj}.") ?? ""You have no number :(");
```

## Functional
Not a lot here... but why was LINQ missing a ForEach() method?

## Strings
Join as a string extension (like Python)
```csharp
var aList = new List<string>() { "One", "Two", "Three" };
", ".Join(aList); // One, Two, Three
```

snake_case generator, I don't like camelCase in CSV/JSON/Databases
```csharp
var aRandomString = "aCamelCaseString";
aRandomString.ToSnakeCase(); // a_camel_case_string
```

## Colors
C# portable libraries do not possess a common color stuff. This is just a small class mainly to convert from strings.

```csharp
ArgbColor.FromString("#FF0000"); // This works
ArgbColor.FromString("#AAFF0000"); // This works

ArgbColor.FromString("FF0000"); // This also works
ArgbColor.FromString("AAFF0000"); // Yup, also working

ArgbColor.FromString("#FFF"); // It does not, fill an issue :)
```

*P.S. This API is targetting .NET 4.6 common APIs (ASP.NET 5, UWP, etc.) but I don't see any reason why it can't be compiled back to .NET 4.5*

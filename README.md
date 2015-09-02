# CsUtilities
Small utilities from personnal code I've been using now all in one place, nothing fancy.

## Option
"Maybe"-like extension methods for C#. 
Since C# Nullables are only valid for structs and non-null types, I wanted something that was akin to Java's Optional or Rust's Option.

This is not a replacement for a proper 'Option' class/library though and not a way to justify using nulls in code, use scarcely :)
Maybe it's bad design, but it made code more readable

## Functional
Not a lot here... but why was LINQ missing a ForEach() method?

## Strings
I like to use Join like in Python

## Colors
C# portable libraries do not possess a common color stuff. This is just a small class mainly to convert from strings.

*P.S. This API is targetting .NET 4.6 common APIs (ASP.NET 5, UWP, etc.) but I don't see any reason why it can't be compiled back to .NET 4.5*

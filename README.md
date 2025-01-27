# Incorrect Comparison of Reference Types in C#

This example demonstrates a common error in C# where reference types are compared using the `==` operator instead of `.Equals()`.  The `==` operator checks for reference equality (whether the two variables point to the same object in memory), while `.Equals()` checks for value equality (whether the objects have the same values).

The `bug.cs` file shows the incorrect comparison using `==`. The `bugSolution.cs` file shows the corrected comparison using `.Equals()`.
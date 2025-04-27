# For and Foreach Loops Practice Project

Welcome to the **For and Foreach Loops Practice** project in C#! This project helps you practice using both `for` loops and `foreach` loops.

## Topics Covered

### 1. For Loop
- Repeats a block of code a set number of times.
- Example:
  ```csharp
  for (int i = 0; i < 5; i++)
  {
      Console.WriteLine("i is: " + i);
  }
  ```

### 2. Foreach Loop
- Iterates through each element in a collection (like arrays or lists).
- Example:
  ```csharp
  string[] names = {"Alice", "Bob", "Charlie"};

  foreach (string name in names)
  {
      Console.WriteLine("Name: " + name);
  }
  ```

### Bonus Challenges
- Practice using loops with different data structures like arrays and lists.
- Nest one loop inside another!

## How to Run

1. Ensure you have the [.NET 8 SDK](https://dotnet.microsoft.com/download) installed.
2. Create a new console project:
   ```bash
   dotnet new console -n LoopsPractice
   cd LoopsPractice
   ```
3. Replace the content of `Program.cs` with the provided code.
4. Run the project:
   ```bash
   dotnet run
   ```

---

Happy looping! 🔁✨

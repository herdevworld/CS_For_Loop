/*
 When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop:
 */

// TODO 1: Use a for loop to print numbers 1 to 5
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"For Loop Number: {i}");
}

Console.WriteLine("----------------------");

// TODO 2: Create an array of fruits
string[] fruits = { "Apple", "Banana", "Cherry", "Date" };

// TODO 3: Use a foreach loop to print all fruits
foreach (string fruit in fruits)
{
    Console.WriteLine($"Fruit: {fruit}");
}

Console.WriteLine("----------------------");

// Bonus Challenge:
// TODO 4: Use a for loop to print fruits with their index
for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine($"Fruit {i}: {fruits[i]}");
}
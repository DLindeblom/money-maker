// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Money Maker!");


Console.Write("Please enter an amount to see how many coins you will have: ");
string input = Console.ReadLine();

double amount = Convert.ToDouble(input);

Console.WriteLine($"{amount} is equal to...");


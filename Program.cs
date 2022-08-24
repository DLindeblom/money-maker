// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Money Maker!");


Console.Write("Please enter an amount to see how many coins you will have: ");
string input = Console.ReadLine();

double amount = Convert.ToDouble(input);

Console.WriteLine($"{amount} is equal to...");

int gold = 10;
int silver = 5;

double goldCoins = amount / gold;

goldCoins = Math.Floor(goldCoins);

double remainder = amount % gold;

double silverCoins = remainder / silver;

silverCoins = Math.Floor(silverCoins);

remainder = remainder % silver;

Console.WriteLine($"Gold Coins: {goldCoins}");
Console.WriteLine($"Silver Coins: {silverCoins}");
Console.WriteLine($"Bronze Coins: {remainder}");
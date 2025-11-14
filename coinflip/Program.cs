Random coin = new Random();
int heads_Tails = coin.Next(1, 3);
Console.WriteLine(heads_Tails == 1 ? "tails" : "heads");
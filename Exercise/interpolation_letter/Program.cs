// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here

// var name = customerName + ",";
// var greeting = $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.";
// var body = $"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}%.";
// var closing = $"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be ${newProfit:N2}";

// var magic_Yield = currentProduct.PadRight(10);
// magic_Yield += currentReturn.ToString("P2").PadLeft(14);
// magic_Yield += currentProfit.ToString("N2").PadLeft(20);

// var glorious_Future = newProduct.PadRight(10);
// glorious_Future += newReturn.ToString("P2").PadLeft(10);
// glorious_Future += newProfit.ToString("N2").PadLeft(20);
// // Your logic here
// Console.WriteLine(name + "\n");
// Console.WriteLine(greeting + "\n");
// Console.WriteLine(body + "\n");
// Console.WriteLine(closing + "\n");

// Console.WriteLine("Here's a quick comparison:" + "\n");

// Console.WriteLine(magic_Yield);
// Console.WriteLine(glorious_Future);

// Better Solution

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);

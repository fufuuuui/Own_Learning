// // //string[] fraudulentOrderIds = new string[3];
// // string[] fraudulentOrderIds = ["A123", "B456", "C789",];

// // // fraudulentOrderIds[0] = "A123";
// // // fraudulentOrderIds[1] = "B456";
// // // fraudulentOrderIds[2] = "C789";
// // //fraudulentOrderIds[3] = "D000";

// // Console.WriteLine($"First: {fraudulentOrderIds[0]}");
// // Console.WriteLine($"Second: {fraudulentOrderIds[1]}");
// // Console.WriteLine($"Third: {fraudulentOrderIds[2]}");

// // fraudulentOrderIds[0] = "F000";

// // Console.WriteLine($"Reassign First: {fraudulentOrderIds[0]}");
// // Console.WriteLine($"There are {fraudulentOrderIds.Length} fraudulent orders to process.");

// string[] names = ["Rowena", "Robin", "bao",];
// foreach (string name in names)
// {
//     Console.WriteLine("" + name);
// }

// 
// string[] names = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
// foreach (string name in names)
// {
//     if (name.StartsWith("B"))
//     {
//         Console.WriteLine($"{name}"); 

//     }

// }
// string firstName = "Bob";
// int widgetsSold = 7;
// // Testing a change to the message.
// // int widgetsSold = 7;
// // Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");

//   The following code creates five random OrderIDs
//   to test the fraud detection process.  OrderIDs 
//   consist of a letter from A to E, and a three
//   digit number. Ex. A123.

// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     // Get a random that equates to ASCII letters A through E
//     int prefixValue = random.Next(65, 70);
//     // Convert the random value into a char, then string
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     // Create a random number, pad with zeroes
//     string suffix = random.Next(1, 1000).ToString("000");
//     // Combine the prefix and suffix together, then assign to current OrderID
//     orderIDs[i] = prefix + suffix;
// }
// //print out each orderID
// foreach (string orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }
// Random dice = new Random();
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }


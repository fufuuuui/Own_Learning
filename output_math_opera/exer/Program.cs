int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
float result1 = (float)value1 / (float)value2;
Console.WriteLine($"Divide value1 by value2, display the result as an int: {Math.Round(result1)}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// BETTER ANSWER

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// // Convert.ToInt32() rounds up the way you would expect.
// int result1 = Convert.ToInt32(value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
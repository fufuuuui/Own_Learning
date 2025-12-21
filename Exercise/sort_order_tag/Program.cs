// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] message = orderStream.Split(',');

// string[] newMessage = new string[message.Length];

// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     if (message[i].Length > 4 || message[i].Length < 4)
//     {
//         newMessage[i] = new string(letters) + $"\t- Error\n";
//     }
//     else
//     {
//         newMessage[i] = new string(letters) + $"\t- OK\n";
//     }
// }
// Array.Sort(newMessage);
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);

// Better Solution
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}
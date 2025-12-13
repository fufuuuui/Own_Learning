// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] newMessage = new string[pangram.Length];
// foreach (var pangramArray in pangram.Split(' '))

// {
//     Console.WriteLine(pangramArray);
//     for (var i = 0; i < pangramArray.Length; i++)
//     {
//         char[] raversed = pangramArray[i].ToCharArray();
//         Array.Reverse(raversed);
//         newMessage[i] = new string(raversed);
//     }
// }
// string result = string.Join(" ", newMessage);
// Console.WriteLine(result);

// Better Solution

string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);
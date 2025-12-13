string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] message = orderStream.Split(',');

string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    if (message[i].Length > 4 || message[i].Length < 4)
    {

        Array.Reverse(letters);
        newMessage[i] = new string(letters);
    }
    newMessage[i] = new string(letters);
}
string result = String.Join(" ", newMessage);
Console.WriteLine(result);
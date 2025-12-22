string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

openingPosition += openSpan.Length; // Move to the first character inside the parentheses

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
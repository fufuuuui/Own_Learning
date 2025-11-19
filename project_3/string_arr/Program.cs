string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

string[] periodLocation  = myStrings;

foreach (var item in periodLocation)
{
    
    int index = item.IndexOf(".");
    do
    {
        Console.WriteLine(item + "\n");
    }while (item.IndexOf(".") + 1 == index + 1);
}

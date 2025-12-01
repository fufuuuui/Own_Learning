string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal results = 0;
string letter = "";

for (int i = 0; i < values.Length; i++)
{
    decimal result = 0;
    if (decimal.TryParse(o, out result))
    {   
        results += result;
    }
    else
    {
        letter += values[i];
    }

}
Console.WriteLine($"Message: {letter}");
Console.WriteLine($"Total: {results}");
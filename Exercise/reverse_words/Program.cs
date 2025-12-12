string pangram = "The quick brown fox jumps over the lazy dog";
foreach (var pangramArray in pangram.Split(" ", 1))
{
    Console.WriteLine(pangramArray);
    if (pangramArray.Length > 0)
    {
        char[] raversed = pangramArray.ToCharArray();
        Array.Reverse(raversed);
        string result = string.Join("", raversed);
        Console.WriteLine(result);
    }
}
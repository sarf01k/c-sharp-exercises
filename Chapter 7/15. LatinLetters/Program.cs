Console.Write("Enter a word: ");
string word = Console.ReadLine();

for (int i = 0; i < word.Length; i++)
{
    Console.Write("{0} -> ", word[i]);
    if (word[i] > 90)
    {
        Console.Write(word[i] - 32 - 'A');
        Console.WriteLine();
    }
    else
    {
        Console.Write(word[i] - 'A');
        Console.WriteLine();
    }
}

Console.ReadKey(true);
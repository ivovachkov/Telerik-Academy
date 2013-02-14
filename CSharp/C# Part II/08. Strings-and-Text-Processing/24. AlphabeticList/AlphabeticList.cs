using System;
using System.Linq;

class AlphabeticList
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split();
        var sorted = words.OrderBy(x => x);
        Console.WriteLine(string.Join(" ", sorted));
        Array.Sort(words);
        Console.WriteLine(string.Join(" ", words));        
    }
}
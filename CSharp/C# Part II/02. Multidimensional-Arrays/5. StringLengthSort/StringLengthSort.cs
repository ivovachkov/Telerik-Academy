using System;
using System.Linq;

class StringLengthSort
{
    static void Main(string[] args)
    {
        //string[] words = new string[] { "zagorka", "ariana", "heineken", "amstel", "bolqrka", "tap", };

        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        Array.Sort(words, (x,y) => (x.Length).CompareTo(y.Length));

        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}
using System;

class LetterIndexInWord
{
    static string alphabet = "abcdefghijklmnopqrstuvwxyz";
    static void Main()
    {
        string word = Console.ReadLine().ToLower();
        foreach (var letter in word)
        {
            int letterIndex = BinarySearch(letter);
            Console.Write(letterIndex + " ");
        }
        Console.WriteLine();
    }

    static int BinarySearch(char letter)
    {
        int left = 0;
        int right = alphabet.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (letter == alphabet[middle])
            {
                return middle;
            }
            else if (letter < alphabet[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        return -1;
    }
}
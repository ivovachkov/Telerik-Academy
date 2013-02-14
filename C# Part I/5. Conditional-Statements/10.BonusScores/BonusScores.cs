using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        string digit = Console.ReadLine();
        int score;

        switch (digit)
        {
            case "1":
            case "2":
            case "3":
                score = Convert.ToInt32(digit);
                Console.WriteLine(score * 10);
                break;
            case "4":
            case "5":
            case "6":
                score = Convert.ToInt32(digit);
                Console.WriteLine(score * 100);
                break;
            case "7":
            case "8":
            case "9":
                score = Convert.ToInt32(digit);
                Console.WriteLine(score * 1000);
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
        
    }
}
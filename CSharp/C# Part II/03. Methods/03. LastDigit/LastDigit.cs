using System;

class LastDigit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        string result = ReturnLastDigit(number);
        Console.WriteLine(result);
    }

    static string ReturnLastDigit(int number)
    {
        string result;
        int lastDigit = number % 10;

        switch (lastDigit)
        {
            case 0:
                result = "Zero";
                break;
            case 1:
                result = "One";
                break;
            case 2:
                result = "Two";
                break;
            case 3:
                result = "Three";
                break;
            case 4:
                result = "Four";
                break;
            case 5:
                result = "Five";
                break;
            case 6:
                result = "Six";
                break;
            case 7:
                result = "Seven";
                break;
            case 8:
                result = "Eight";
                break;
            case 9:
                result = "Nine";
                break;
            default:
                result = "Error";
                break;
        }

        return result;
    }
}
using System;

class NumberToWords
{
    static void Main()
    {
        Console.Write("Enter a number in the range [0..999]: ");
        int number = int.Parse(Console.ReadLine());
        int ones = number % 10;
        int tens = (number / 10) % 10;
        int hundreds = number / 100;

        if ((number < 0) || (number > 999))
        {
            Console.WriteLine("Not a valid number!");
        }
        else if (number == 0)
        {
            Console.WriteLine("Zero");
        }
        else if ((number > 0) && (number < 10))
        {
            Console.WriteLine(Ones(number));
        }
        else if ((number > 9) && (number < 20))
        {
            Console.WriteLine(Specials(number));
        }
        else if ((number > 19) && (number < 100))
        {
            Console.WriteLine(Tens(tens) + " " + Ones(ones).ToLower());
        }
        else if ((number > 99) && (number < 1000))
        {
            if (((number % 100) < 20) && ((number % 100) > 0))
            {
                if ((number % 100) > 9)
                {
                    Console.WriteLine(Ones(hundreds) + " hundred and " + Specials(number % 100).ToLower());
                }
                else
	            {
                    Console.WriteLine(Ones(hundreds) + " hundred and " + Ones(ones).ToLower());
	            }
            }
            else
            {
                if ((tens != 0) && (ones == 0))
                {
                    Console.WriteLine(Ones(hundreds) + " hundred and " + Tens(tens).ToLower());
                }
                else
                {
                    Console.WriteLine(Ones(hundreds) + " hundred " + Tens(tens).ToLower() + " " + Ones(ones).ToLower());
                }
            }
        }
    }

    static string Ones(int ones)
    {
        string text = "";
        switch (ones)
        {
            case 1:
                text = "One";
                break;
            case 2:
                text = "Two";
                break;
            case 3:
                text = "Three";
                break;
            case 4:
                text = "Four";
                break;
            case 5:
                text = "Five";
                break;
            case 6:
                text = "Six";
                break;
            case 7:
                text = "Seven";
                break;
            case 8:
                text = "Eight";
                break;
            case 9:
                text = "Nine";
                break;
            default:
                break;
        }
        return text;
    }

    static string Specials(int specials)
    {
        string text = "";
        switch (specials)
        {
            case 10:
                text = "Ten";
                break;
            case 11:
                text = "Eleven";
                break;
            case 12:
                text = "Twelve";
                break;
            case 13:
                text = "Thirteen";
                break;
            case 14:
                text = "Fourteen";
                break;
            case 15:
                text = "Fifteen";
                break;
            case 16:
                text = "Sixteen";
                break;
            case 17:
                text = "Seventeen";
                break;
            case 18:
                text = "Eighteen";
                break;
            case 19:
                text = "Nineteen";
                break;
            default:
                break;
        }
        return text;
    }

    static string Tens(int tens)
    {
        string text = "";
        switch (tens)
        {
            case 2:
                text = "Twenty";
                break;
            case 3:
                text = "Thirty";
                break;
            case 4:
                text = "Fourty";
                break;
            case 5:
                text = "Fifty";
                break;
            case 6:
                text = "Sixty";
                break;
            case 7:
                text = "Seventy";
                break;
            case 8:
                text = "Eighty";
                break;
            case 9:
                text = "Ninety";
                break;
            default:
                break;
        }
        return text;
    }
}
using System;

class NumberToTextConvertion
{
    static void Main()
    {
        Console.Write("Enter number in the range [0..999]: ");
        int number = int.Parse(Console.ReadLine());

        int ones = number % 10;
        int tens = (number / 10) % 10;
        int hundreds = number / 100;
        int twoDigitNum = number % 100;

        if (number < 0 || number > 999)
        {
            Console.WriteLine("Invalid number");
        }

        switch (number)
        {
            case 0: Console.Write("Zero"); break;
            case 1: Console.Write("One"); break;
            case 2: Console.Write("Two"); break;
            case 3: Console.Write("Three"); break;
            case 4: Console.Write("Four"); break;
            case 5: Console.Write("Five"); break;
            case 6: Console.Write("Six"); break;
            case 7: Console.Write("Seven"); break;
            case 8: Console.Write("Eight"); break;
            case 9: Console.Write("Nine"); break;
            case 10: Console.Write("Ten"); break;
            case 11: Console.Write("Eleven"); break;
            case 12: Console.Write("Twelve"); break;
            case 13: Console.Write("Thirteen"); break;
            case 14: Console.Write("Fourteen"); break;
            case 15: Console.Write("Fifteen"); break;
            case 16: Console.Write("Sixteen"); break;
            case 17: Console.Write("Seventeen"); break;
            case 18: Console.Write("Eightteen"); break;
            case 19: Console.Write("Nineteen"); break;
        }

        switch (hundreds)
        {
            case 1: Console.Write("One hundred "); break;
            case 2: Console.Write("Two hundred "); break;
            case 3: Console.Write("Three hundred "); break;
            case 4: Console.Write("Four hundred "); break;
            case 5: Console.Write("Five hundred "); break;
            case 6: Console.Write("Six hundred "); break;
            case 7: Console.Write("Seven hundred "); break;
            case 8: Console.Write("Eight hundred "); break;
            case 9: Console.Write("Nine hundred "); break;
        }

        if (hundreds > 0 && (ones == 0 || tens < 2))
        {
            if (ones == 0 && tens == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("and ");
                switch (twoDigitNum)
                {
                    case 1: Console.Write("one"); break;
                    case 2: Console.Write("two"); break;
                    case 3: Console.Write("three"); break;
                    case 4: Console.Write("four"); break;
                    case 5: Console.Write("five"); break;
                    case 6: Console.Write("six"); break;
                    case 7: Console.Write("seven"); break;
                    case 8: Console.Write("eight"); break;
                    case 9: Console.Write("nine"); break;
                    case 10: Console.Write("ten"); break;
                    case 11: Console.Write("eleven"); break;
                    case 12: Console.Write("twelve"); break;
                    case 13: Console.Write("thirteen"); break;
                    case 14: Console.Write("fourteen"); break;
                    case 15: Console.Write("fifteen"); break;
                    case 16: Console.Write("sixteen"); break;
                    case 17: Console.Write("seventeen"); break;
                    case 18: Console.Write("eightteen"); break;
                    case 19: Console.Write("nineteen"); break;
                }

                switch (tens)
                {
                    case 2: Console.Write("twenty "); break;
                    case 3: Console.Write("thirty "); break;
                    case 4: Console.Write("fourty "); break;
                    case 5: Console.Write("fifty "); break;
                    case 6: Console.Write("sixty "); break;
                    case 7: Console.Write("seventy "); break;
                    case 8: Console.Write("eighty "); break;
                    case 9: Console.Write("ninety "); break;
                }
            }
        }

        if (hundreds == 0)
        {
            switch (tens)
            {
                case 2: Console.Write("Twenty "); break;
                case 3: Console.Write("Thirty "); break;
                case 4: Console.Write("Fourty "); break;
                case 5: Console.Write("Fifty "); break;
                case 6: Console.Write("Sixty "); break;
                case 7: Console.Write("Seventy "); break;
                case 8: Console.Write("Eighty "); break;
                case 9: Console.Write("Ninety "); break;
            }
        }

        if (hundreds > 0 && tens != 0 && ones != 0)
        {
            switch (tens)
            {
                case 2: Console.Write("twenty "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("fourty "); break;
                case 5: Console.Write("fifty "); break;
                case 6: Console.Write("sixty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninety "); break;
            }
        }

        if (hundreds >= 0 && tens > 0 && twoDigitNum > 19)
        {
            switch (ones)
            {
                case 1: Console.Write("one"); break;
                case 2: Console.Write("two"); break;
                case 3: Console.Write("three"); break;
                case 4: Console.Write("four"); break;
                case 5: Console.Write("five"); break;
                case 6: Console.Write("six"); break;
                case 7: Console.Write("seven"); break;
                case 8: Console.Write("eight"); break;
                case 9: Console.Write("nine"); break;
            }
        }
        Console.WriteLine();
    }
}
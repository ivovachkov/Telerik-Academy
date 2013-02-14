using System;

class ProductSign
{
    static void Main(string[] args)
    {
        double firstNumber = -2.3568;
        double secondNumber = -9;
        double thirdNumber = 5.45654;

        if ((firstNumber == 0) || (secondNumber == 0) || (thirdNumber == 0))
        {
            Console.WriteLine(0);
        }

        if (firstNumber > 0)
        {
            if ((secondNumber > 0) && (thirdNumber > 0))
            {
                Console.WriteLine("+");
            }
            if ((secondNumber < 0) && (thirdNumber < 0))
            {
                Console.WriteLine("+");
            }
            if (((secondNumber > 0) && (thirdNumber < 0)) ||
                ((secondNumber < 0) && (thirdNumber > 0)))
            {
                Console.WriteLine("-");
            }
        }
        else
        {
            if ((secondNumber > 0) && (thirdNumber > 0))
            {
                Console.WriteLine("-");
            }
            if ((secondNumber < 0) && (thirdNumber < 0))
            {
                Console.WriteLine("-");
            }
            if (((secondNumber > 0) && (thirdNumber < 0)) ||
                ((secondNumber < 0) && (thirdNumber > 0)))
            {
                Console.WriteLine("+");
            }
        }
    }
}
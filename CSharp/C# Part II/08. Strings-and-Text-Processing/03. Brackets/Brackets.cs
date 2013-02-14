using System;

class Brackets
{
    static void Main()
    {
        string expression = "((a+b)/5-d).";
        int counter = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                counter++;
            }
            else if (expression[i] == ')')
            {
                counter--;
            }
        }

        if (counter==0)
        {
            Console.WriteLine("The expression is correct!");
        }
        else
        {
            Console.WriteLine("The expression is incorrect!");
        }
    }
}
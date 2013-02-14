using System;
using System.Collections.Generic;

class ReverseCalculateEquation
{
    static void Main()
    {
        Console.WriteLine("Choose a task to solve: ");
        Console.WriteLine("1. Reverse a number");
        Console.WriteLine("2. Calculate average in sequence");
        Console.WriteLine("3. Solve linear equation");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                int number;
                string input;
                do
                {
                    Console.Write("Enter number to reverse: ");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out number) || number < 0);

                Console.WriteLine(Reverse(number));
                break;

            case 2:
                Console.Write("Enter legth of sequence: ");
                int length = int.Parse(Console.ReadLine());
                int[] numbers = new int[length];
                Console.WriteLine("Enter {0} numbers: ", length);

                for (int i = 0; i < length; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine(Average(numbers));
                break;

            case 3:
                int a, b;
                string firstLine;
                string secondLine;
                do
                {
                    Console.Write("Enter a: ");
                    firstLine = Console.ReadLine();
                    Console.Write("Enter b: ");
                    secondLine = Console.ReadLine();
                } while (!int.TryParse(firstLine, out a) || !int.TryParse(secondLine, out b) || a == 0);
                if (b == 0)
                {
                    Console.WriteLine("Every x is solution");
                }
                else
                {
                    Console.WriteLine(LinearEquation(a, b));
                }
                break;

            default:
                Console.WriteLine("Error");
                break;
        }
    }

    static int Reverse(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            reversed += number % 10;
            number /= 10;
            reversed *= 10;
        }
        return reversed / 10;
    }

    static decimal Average(params int[] elements)
    {
        long sum = 0;
        foreach (var item in elements)
        {
            sum += item;
        }
        return (decimal)sum / elements.Length;
    }

    static decimal LinearEquation(decimal a, decimal b)
    {
        return (-b / a);
    }
}
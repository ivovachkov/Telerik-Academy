using System;

class TypeChoiceVariable
{
    static void Main()
    {
        Console.WriteLine("Enter your choice: ");
        Console.WriteLine("1. for int");
        Console.WriteLine("2. for double");
        Console.WriteLine("3. for string");
        int choice = int.Parse(Console.ReadLine());
        string variable = Console.ReadLine();

        switch (choice)
        {
            case 1:
                Console.WriteLine(Convert.ToInt32(variable) + 1);
                break;
            case 2:
                Console.WriteLine(Convert.ToDouble(variable) + 1);
                break;
            case 3:
                Console.WriteLine(variable + "*");
                break;
            default:
                Console.WriteLine("Not valid choice");
                break;
        }
    }
}
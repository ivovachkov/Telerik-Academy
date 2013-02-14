using System;
class AgePlusTen
{
    static void Main()
    {
        int age;
        Console.Write("What is your age: ");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("In ten years, you will be {0} years old", age + 10);
    }
}

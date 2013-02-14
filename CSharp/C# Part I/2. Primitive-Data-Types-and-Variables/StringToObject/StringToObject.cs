using System;

class StringToObject
{
    static void Main()
    {
        string firstValue = "Hello";
        string secondValue = "World";
        object objValue = firstValue + " " + secondValue;
        
        Console.WriteLine(objValue);

        string thirdValue = (string)objValue;
        Console.WriteLine(thirdValue);
    }
}
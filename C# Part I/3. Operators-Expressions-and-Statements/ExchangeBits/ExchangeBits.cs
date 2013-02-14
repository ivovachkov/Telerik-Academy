using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter positive integer: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binay is: " + Convert.ToString(number, 2).PadLeft(32, '0'));

        uint firstBitsNumber = (((number >> 3) & 7)) << 24;
        uint secondBitsNumber = (((number >> 24) & 7)) << 3;

        uint zeroFirstBits = (uint)(number & (~(7 << 3)));
        uint zeroBits = (uint)(zeroFirstBits & (~(7 << 24)));

        uint newFirstNumber = (uint)(firstBitsNumber | zeroBits);
        uint newNumber = (uint)(secondBitsNumber | newFirstNumber);

        Console.WriteLine("The new number is: " + newNumber);
        Console.WriteLine("The new number in binary is: " + Convert.ToString(newNumber, 2).PadLeft(32, '0'));
    }
}
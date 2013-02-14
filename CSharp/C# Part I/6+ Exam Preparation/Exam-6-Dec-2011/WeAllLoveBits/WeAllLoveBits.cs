using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] reversed = new int[n];
        for (int numbersCount = 0; numbersCount < n; numbersCount++)
        {
            int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(number, 2));
            int bitPower = 1;
            int reversedBitsNumber = 0;
            int bitCount = 0;
            int tempNumber = number;

            while (tempNumber > 0)
            {
                bitCount++;
                tempNumber >>= 1;
            }

            for (int i = bitCount - 1; i >= 0; i--)
            {
                reversedBitsNumber += (number & 1) * (bitPower << i);
                number >>= 1;
            }
            reversed[numbersCount] = reversedBitsNumber;
            //Console.WriteLine(Convert.ToString(reversedBitsNumber, 2).PadLeft(bitCount, '0'));
            //Console.WriteLine(reversedBitsNumber);
        }

        for (int i = 0; i < reversed.Length; i++)
        {
            Console.WriteLine(reversed[i]);
        }
    }
}
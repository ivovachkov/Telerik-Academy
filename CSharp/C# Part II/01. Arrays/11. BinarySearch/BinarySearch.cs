using System;

class BinarySearch
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 9, 9, 10, 11 };
        int element = int.Parse(Console.ReadLine());
        int left = 0;
        int right = arr.Length - 1;
        int middle = 0;

        while (left <= right)
        {
            middle = (left + right) / 2;
            if (element == arr[middle])
            {
                Console.WriteLine("The index of the element is: " + middle);
                break;
            }
            else if (element < arr[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        if (arr[middle] != element)
        {
            Console.WriteLine("The element is not in the list.");
        }
    }
}
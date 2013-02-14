using System;

class SquareRoot
{
    static void Main()
    {        
        try
        {
            int number = int.Parse(Console.ReadLine());
            bool isPositive = number > 0;
            if (isPositive)
            {
                double result = Math.Sqrt(number);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("You should put a positive number!");
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No number given!");
        }
        catch (FormatException)
        {
            Console.WriteLine("The number you wrote is not an integer!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is out of the range of Int.32!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }        
    }
}
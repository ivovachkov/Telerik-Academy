using System;

namespace Hi
{
    public class HelloTestProgram
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(Hello(name));
            TestHello();
        }

        public static string Hello(string name)
        {
            string result = String.Format("Hello, {0}!", name);
            return result;
        }

        static void TestHello()
        {
            string name = "Pesho";
            string expected = "Hello, Pesho!";
            string real = Hello(name);
            if (real == expected)
            {
                Console.WriteLine("The test passed!");
            }
            else
            {
                Console.WriteLine("The test failed!");
            }
        }
    }
}
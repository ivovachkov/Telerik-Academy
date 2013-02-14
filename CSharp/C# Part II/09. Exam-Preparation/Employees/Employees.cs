using System;
using System.Linq;
using System.Collections.Generic;

class EmployeesProgram
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Rating { get; set; }
    }

    class Positions
    {
        public int Rating { get; set; }
        public string Position { get; set; }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Positions[] positions = new Positions[n];

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            string[] tokens = line.Split('-');
            positions[i] = new Positions();
            positions[i].Position = tokens[0].TrimEnd();
            positions[i].Rating = int.Parse(tokens[1].TrimStart());
        }

        int m = int.Parse(Console.ReadLine());
        Employee[] employees = new Employee[m];

        for (int i = 0; i < m; i++)
        {
            string line = Console.ReadLine();
            string[] tokens = line.Split('-');
            employees[i] = new Employee();
            employees[i].Position = tokens[1].TrimStart();
            foreach (var item in positions)
            {
                if (item.Position == employees[i].Position)
                {
                    employees[i].Rating = item.Rating;
                }
            }
            string[] names = tokens[0].Trim().Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);
            employees[i].FirstName = names[0];
            employees[i].LastName = names[1];
        }

        //Console.WriteLine();

        var sortedPositions = 
            employees.OrderByDescending(x => x.Rating).
            ThenBy(x => x.LastName).
            ThenBy(x => x.FirstName);

        foreach (var item in sortedPositions)
        {
            Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
        }
    }
}
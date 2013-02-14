using System;

class CompanyManager
{
    static void Main()
    {
        Console.Write("Company name: ");
        string compName = Console.ReadLine();

        Console.Write("Company address: ");
        string compAddress = Console.ReadLine();

        Console.Write("Company phone number: ");
        string compPhone = Console.ReadLine();

        Console.Write("Company fax number: ");
        string compFax = Console.ReadLine();

        Console.Write("Company web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager's first name: ");
        string managerFName = Console.ReadLine();

        Console.Write("Manager's last name: ");
        string managerLName = Console.ReadLine();

        Console.Write("Manager's age: ");
        string managerAge = Console.ReadLine();

        Console.Write("Manager's phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine(compName);
        Console.WriteLine(compAddress);
        Console.WriteLine(compPhone);
        Console.WriteLine(compFax);
        Console.WriteLine(webSite);
        Console.WriteLine(managerFName);
        Console.WriteLine(managerLName);
        Console.WriteLine(managerAge);
        Console.WriteLine(managerPhone);
    }
}

using System;

class EmployeeRecord
{
    static void Main()
    {
        string firstName = "Ivaylo";
        string familyName = "Vachkov";
        byte age = 23;
        char gender = 'm';
        ushort idNumber = 00345;
        int employeeNumber = 27569999;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}",firstName,familyName,age,gender,idNumber,employeeNumber);
    }
}
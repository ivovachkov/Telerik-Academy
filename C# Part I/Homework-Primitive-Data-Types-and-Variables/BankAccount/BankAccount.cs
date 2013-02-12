using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Ivaylo";
        string middleName = "Lyubenov";
        string lastName = "Vachkov";
        decimal moneyBalance = 567.45m;
        string bankName = "Postbank";
        string IBAN = "PBBGSF009876534";
        string BIC = "PBBGSF";
        ulong firstCCN = 508746399870u;
        ulong secondCCN = 508746399560u;
        ulong thirdCCN = 508746399458u;
        Console.WriteLine(
            "{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}", 
            firstName,middleName,lastName,moneyBalance,bankName,
            IBAN,BIC,firstCCN,secondCCN,thirdCCN);
    }
}
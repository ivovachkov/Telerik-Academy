using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        string message = "Write a program that encodes and decodes a string using given encryption key (cipher)";
        string key = "xor";
        int keyLen = key.Length;
        StringBuilder encrypted = new StringBuilder();
        StringBuilder decrypted = new StringBuilder();

        for (int i = 0; i < message.Length; i++)
        {
            encrypted.Append((char)(message[i] ^ key[i % keyLen]));
        }
        Console.WriteLine(encrypted.ToString());

        for (int i = 0; i < encrypted.Length; i++)
        {
            decrypted.Append((char)(encrypted[i] ^ key[i % keyLen]));
        }
        Console.WriteLine(decrypted.ToString());
    }
}
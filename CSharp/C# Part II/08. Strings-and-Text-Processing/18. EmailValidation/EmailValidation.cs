using System;

class EmailValidation
{
    static void Main()
    {
        string text = "feel free to e-mail us at go.sample@hotmail.com. Make sure it is right as g8U_&j@gmail.com, to be continued";
        string[] tokens = text.Split();
        for (int i = 0; i < tokens.Length; i++)
        {
            string token = tokens[i];
            if (token[token.Length - 1] == '.' || token[token.Length - 1] == ','
                || token[token.Length - 1] == '!' || token[token.Length - 1] == '?')
            {
                token = token.Remove(token.Length - 1);
            }

            if ((token.IndexOf("@", 0) > 3) && 
                (token.IndexOf("@", 0) < token.Length - 5) &&
                (token.LastIndexOf(".", token.Length - 1) > token.IndexOf('@', 0) + 3) &&
                (token.LastIndexOf(".", token.Length - 1) < token.Length - 3))
            {
                Console.WriteLine(token);
            }
        }
    }
}
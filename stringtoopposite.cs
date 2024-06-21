using System;
class Program
{
    static void Main()
    {
        string input = "Have a Nice Day";
        string result = ConvertToOppositeCase(input);
        Console.WriteLine("Original string: " + input);
        Console.WriteLine("Converted string: " + result);
    }

    static string ConvertToOppositeCase(string str)
    {
        char[] characters = str.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsUpper(characters[i]))
            {
                characters[i] = char.ToLower(characters[i]);
            }
            else if (char.IsLower(characters[i]))
            {
                characters[i] = char.ToUpper(characters[i]);
            }
        }

        return new string(characters);
    }
}

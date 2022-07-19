namespace StringCompression;

using System;
using System.Text.RegularExpressions;

public class Example
{
    private const int firstElementOfGroup = 0;

    public static void Main()
    {
        string input = "ABBBABBBBCDEFFF";
        string pattern = "([a-zA-Z])\\1{2,}";
        string result = Regex.Replace(input, pattern, m =>
        {
            var str = m.Groups[firstElementOfGroup].Value;
            return str.Length.ToString() + str[0];
        });

        Console.WriteLine($"Original String: {input}");
        Console.WriteLine($"Replacement String: {result}");
    }
}
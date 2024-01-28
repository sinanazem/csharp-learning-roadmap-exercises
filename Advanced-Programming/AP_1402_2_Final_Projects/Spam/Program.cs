using System;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

class SpamDetector
{
    public bool IsSpam(string word)
    {
        
        if (ContainsOneMoreUpperCase(word) ||
            HasRepeatedCharacters(word) ||
            HasNoVowels(word) ||
            HasNonAlphabeticCharacters(word))
        {
            return true;
        }

        return false;
    }

    private bool ContainsOneMoreUpperCase(string word)
    {
        int counter = 0;
        foreach (char c in word)
        {
            if (char.IsUpper(c))
            {
                counter ++;
            }
        }
        if (counter > 1)
        {
            return true;
        }
        return false;
    }

    private bool HasRepeatedCharacters(string word)
    {
        Regex regex = new Regex(@"(.)\1{2,}");
        return regex.IsMatch(word);
    }

    private bool HasNoVowels(string word)
    {
        string vowels = "aeiou";
        foreach (char c in word.ToLower())
        {
            if (vowels.Contains(c))
            {
                return false;
            }
        }

        return true;
    }

    private bool HasNonAlphabeticCharacters(string word)
    {
        Regex regex = new Regex(@"[^a-zA-Z]");
        return regex.IsMatch(word);
    }
}

class Program
{
    static void Main()
    {
        SpamDetector spamDetector = new SpamDetector();

        Console.WriteLine("Please Enter your message: ");
        string message = Console.ReadLine();

        string[] words = message.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int spamWordCount = 0;

        foreach (string word in words)
        {
            if (spamDetector.IsSpam(word))
            {
                spamWordCount++;
            }
        }

        Console.WriteLine(spamWordCount.ToString());



    }
}

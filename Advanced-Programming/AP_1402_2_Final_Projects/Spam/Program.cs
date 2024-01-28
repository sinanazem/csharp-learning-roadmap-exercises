using System;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

class SpamDetector
{
    private string message;
    public string Message
    {
        get { return message; }
        set { message = value; }
    }
    public SpamDetector() { }
    public SpamDetector(string inputMessage)
    {
        message = inputMessage;
    }

    public int CountSpam()
    {
        string[] words = message.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        int spamWordCount = 0;

        foreach (string word in words)
        {
            if (IsSpam(word))
            {
                spamWordCount++;
            }
        }
        return spamWordCount;
    }
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
        Console.WriteLine("Please Enter your message: ");
        string message = Console.ReadLine();

        SpamDetector spamDetector = new SpamDetector(message);

        Console.WriteLine("Number of Spam in your message: " + spamDetector.CountSpam());
    }
}

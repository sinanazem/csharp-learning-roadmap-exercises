using System;
using System.Collections.Generic;

class DiscountCodeValidator
{
    private string validCode;

    public string ValidCode
    {
        get { return validCode; }
        set { validCode = value; }
    }
    
    public DiscountCodeValidator() { }
    public DiscountCodeValidator(string validCodeInput)
    {
        validCode = validCodeInput;
    }

    public bool IsValidDiscountCode(string code)
    {
        HashSet<char> codeSet = new HashSet<char>(code);
        HashSet<char> validSet = new HashSet<char>(validCode);
        return codeSet.SetEquals(validSet);
    }
}

class Program
{
    static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());
        string t = Console.ReadLine().Trim();

        DiscountCodeValidator validator = new DiscountCodeValidator(t);

        string[] codes = new string[n];
        for (int i = 0; i < n; i++)
        {
            codes[i] = Console.ReadLine().Trim();
        }

        for (int i = 0; i < n; i++)
        {
            bool isValid = validator.IsValidDiscountCode(codes[i]);
            
            if (isValid)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}

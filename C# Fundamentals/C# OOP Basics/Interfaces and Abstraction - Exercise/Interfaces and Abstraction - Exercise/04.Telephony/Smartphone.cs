using System;
using System.Collections.Generic;
using System.Text;

public class Smartphone : ICall, IBrowse
{
    public Smartphone()
    {
        this.Numbers = new List<string>();
        this.Browsers = new List<string>();
    }

    public List<string> Numbers { get; private set; }
    public List<string> Browsers { get; private set; }

    public void TryAddBrowser(string browser)
    {
        var isValid = ValidateBrowser(browser);

        if (isValid)
            Browsers.Add(browser);
        else
            Browsers.Add("Invalid URL!");
    }

    public void TryAddNumber(string number)
    {
        var isValid = ValidateNumber(number);

        if (isValid)
            Numbers.Add(number);
        else
            Numbers.Add("Invalid number!");
    }

    private bool ValidateBrowser(string browser)
    {
        for (int i = 0; i < browser.Length; i++)
        {
            if (Char.IsDigit(browser[i]))
                return false;
        }

        return true;
    }

    private bool ValidateNumber(string number)
    {
        for (int i = 0; i < number.Length; i++)
        {
            if (!Char.IsDigit(number[i]))
                return false;
        }

        return true;
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        
        foreach (var number in Numbers)
        {
            if (number != "Invalid number!")
                result.AppendLine("Calling... " + number);
            else
                result.AppendLine(number);
        }

        foreach (var browser in Browsers)
        {
            if (browser != "Invalid URL!")
                result.AppendLine("Browsing: " + browser + "!");
            else
                result.AppendLine(browser);
        }

        return result.ToString();
    }
}
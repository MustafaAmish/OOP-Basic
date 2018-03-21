using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Smartphone :IBrowseable,ICallable
{
    public string Browsing(string url)
    {
        return url.Any(u=>char.IsDigit(u))? "Invalid URL!" : $"Browsing: {url}!";
    }

    public string Call(string number)
    {
        return  number.Any(n=>char.IsDigit(n))? $"Calling... {number}" : "Invalid number!";
    }
}
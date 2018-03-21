using System;
using System.Collections.Generic;
using System.Text;


public class StackOfStrings
{
    List<string> names=new List<string>();

    public bool IsEmpty()
    {
        return names.Count == 0;
    }

    public void Push(string name)
    {
        names.Add(name);
    }

    public string Pop()
    {
        string rezult = null;
        if (!IsEmpty())
        {
            rezult = names[names.Count - 1];
            names.RemoveAt(names.Count - 1);
        }
        return rezult;
    }

    public string Peek()
    {

        string rezult = null;
        if (!IsEmpty())
        {
            rezult = names[names.Count - 1];
            
        }
        return rezult;
    }

}


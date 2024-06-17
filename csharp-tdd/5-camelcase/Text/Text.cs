﻿using System.Text;

namespace Text;

///<summary>
/// public class for number of words in a strings
///</summary>
public class Str
{
    ///<summary>
    /// Method that returns the number of words in a string
    ///</summary>

    public static int CamelCase(string? s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        int wCount = 1;
        foreach (char c in s)
        {
            if (char.IsUpper(c))
            {
                wCount++;
            }
        }

        return wCount;
    }


}
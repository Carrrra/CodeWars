using System;
using System.Collections.Generic;

public class Kata
{
    public static string Rgb(int r, int g, int b)
    {
        r = Math.Max(0, Math.Min(255, r));
        g = Math.Max(0, Math.Min(255, g));
        b = Math.Max(0, Math.Min(255, b));

        var hex = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        var rgb = new int[] { r, g, b };
        var converted = new List<string>();

        foreach (var val in rgb)
        {
            converted.Add(hex[(val - (val % 16)) / 16]);
            converted.Add(hex[val % 16]);
        }

        return string.Join("", converted);
    }
}
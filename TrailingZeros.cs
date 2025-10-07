using System;

public static class Kata
{
    public static int TrailingZeros(int n)
    {
        var result = 0;
        var value = 5;

        while (value <= n)
        {
            result += n / value; // integer division counts multiples
            value *= 5;           // move to next power of 5
        }

        return result;
    }
}
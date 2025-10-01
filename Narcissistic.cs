using System;
using System.Linq;

public class Kata
{
    public static bool Narcissistic(int value)
    {
        double sum = 0;
        var ints = value.ToString().Select(x => x - '0').ToArray();
        foreach (var number in ints)
        {
            sum += Math.Pow(number,ints.Length);
        }
        if (sum == value)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
using System.Collections.Generic;
using System.Linq;


public class Kata
{
    public static int Find(int[] integers)
    {
        var bools = new List<bool>();
        for (int i = 0; i < integers.Length; i++)
        {
            bools.Add(oddOrNot(integers[i]));
        }
        if (bools.Count(x => x) > bools.Count(x => !x))
        {
            return integers[bools.IndexOf(false)];
        }
        else
        {
            return integers[bools.IndexOf(true)];
        }
    }

    public static bool oddOrNot(int i)
    {
        if (i % 2 == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
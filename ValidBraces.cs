using System;
using System.Linq;
using System.Collections.Generic;

public class Brace
{
    public static bool validBraces(string braces)
    {
        var openBraces = new string[] { "(", "{", "[" };
        var closedBraces = new string[] { ")", "}", "]" };
        var stack = new Stack<string>();

        foreach (var c in braces)
        {
            string s = c.ToString();

            if (Array.Exists(openBraces, x => x == s))
            {
                stack.Push(s);
            }
            else if (Array.Exists(closedBraces, x => x == s))
            {
                if (stack.Count == 0)
                    return false;

                if (!isMatching(stack.Pop(), s))
                    return false;
            }
        }

        return stack.Count == 0;
    }

    public static bool isMatching(string open, string close)
    {
        return (open == "(" && close == ")") ||
               (open == "{" && close == "}") ||
               (open == "[" && close == "]");
    }
}
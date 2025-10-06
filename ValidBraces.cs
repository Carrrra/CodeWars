using System;
using System.Linq;
using System.Collections.Generic;

public class Brace
{
    public static bool validBraces(String braces)
    {
        var openBraces = new string[] { "(", "{", "[" };
        var closedBraces = new string[] { ")", "}", "]" };
        var stack = new Stack<string>();
        foreach (var c in braces)
        {
            if (Arrays.Exists(openBraces, x => x == c))
            {
                stack.Push(c);
            }
            else if (Arrays.Exists(closedBraces, x => x == c))
            {
                if (stack.Count == 0)
                    return false;

                if (!isMatching(stack.Pop(), c))
                    return false;
            }
            return stack.Count == 0;
        }

        return false;
    }
    public static bool isMatching(string open, string close)
    {
        return (open == "(" && close == ")") ||
               (open == "{" && close == "}") ||
               (open == "[" && close == "]");
    }
}
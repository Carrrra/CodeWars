using System.Text;

public class RangeExtraction
{
    public static string Extract(int[] args)
    {
        var sb = new StringBuilder();
        var i = 0;
        while(i < args.Length)
        {
            if(i < args.Length - 2)
            {
                if(args[i] + 1 == args[i+1] && args[i] + 2 == args[i+2])
                {
                    sb.Append($"{args[i]}-{args[i+2]}");
                    i += 2; 
                }
                
            }
            else 
            {
               sb.Append($"{args[i].ToString()},");
               i++;
            }         
        }
        sb.Remove(sb.Length- 1, 1);
        return sb.ToString();
    }
}
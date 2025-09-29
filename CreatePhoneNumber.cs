using System.Text;
public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        var builder = new StringBuilder("(", 10);
        for (int i = 0; i < numbers.Length; i++)
        {
            builder.Append(numbers[i].ToString());
            if (i == 2)
            {
                builder.Append(")");
                builder.Append(" ");
            }
            if (i == 5)
                    builder.Append("-");
        }
        return builder.ToString();
    }
}
using System.Collections.Generic;

namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            var visited = new List<int>();
            for (int i = 0; i < seq.Length; i++)
            {
                if (visited.Contains(seq[i]))
                    continue;
                    
                visited.Add(seq[i]);
                var count = 1;
                for (int j = i + 1; j < seq.Length; j++)
                {
                    if (seq[i] == seq[j])
                        count++;
                
                }
                if (count % 2 == 1)
                    return seq[i];
            }
            return -1;
        }

    }
}
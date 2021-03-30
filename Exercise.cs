using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman
{
    public class Exercise
    {
        public static int converRomanToInteger(string s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }
            Dictionary<char, int> hash = new Dictionary<char, int>();
            hash.Add('I', 1);
            hash.Add('V', 5);
            hash.Add('X', 10);
            hash.Add('L', 50);
            hash.Add('C', 100);
            hash.Add('D', 500);
            hash.Add('M', 1000);

            int result = 0;
            int next_index = 1;

            for (int i = 0; i < s.Length && next_index < s.Length; i++)
            {
                if (hash[s[i]] >= hash[s[next_index]])
                {
                    result = result + hash[s[i]];
                }
                else
                {
                    result = result - hash[s[i]];
                }
                next_index += 1;
            }
            result = result + hash[s[s.Length - 1]];
            return result;
        }
    }
}

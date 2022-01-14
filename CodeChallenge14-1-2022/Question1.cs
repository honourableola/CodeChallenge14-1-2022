using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge14_1_2022
{
    class Question1
    {
        public void LongestDuplicatedSubstring(string word)
        {
            string longestSubstring = string.Empty;
            List<string> substrings = new List<string>();
            List<string> duplicated = new List<string>();
            for (int lenght = 1; lenght < word.Length; lenght++)
            {
                for(int startingPoint = 0; startingPoint < word.Length - lenght + 1; startingPoint++)
                {
                    string wordPart = word.Substring(startingPoint, lenght);
                    substrings.Add(wordPart);
                }
            }
   
            for(int i = 0; i < substrings.Count - 1; i++)
            {
                int count = 0;
                for (int j = 1; j < substrings.Count; j++)
                {
                    if (substrings[i] == substrings[j])
                    {
                        count++;
                        
                    }
                }
                
                if(count >= 2)
                {
                    duplicated.Add(substrings[i]);
                }
            }

            for(int i = 0; i < duplicated.Count; i++)
            {
                if(duplicated[i].Length > longestSubstring.Length)
                {
                    longestSubstring = duplicated[i];
                }
            }

            Console.WriteLine(longestSubstring);

            
        }
    }
}

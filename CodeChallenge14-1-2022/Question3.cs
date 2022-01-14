using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge14_1_2022
{
    class Question3
    {
        public void StringValidation(string testCase)
        {
            List<char> charList = new List<char>();
            List<char> store = new List<char>();
            int openingParentheses = 0;
            int closingParentheses = 0;

            for(int i = 0; i < testCase.Length; i++)
            {
                charList.Add(testCase[i]);
            }

            for(int i = 0; i < charList.Count; i++)
            {
                if (testCase[i] == '(')
                {
                    openingParentheses++;
                }
                else if (testCase[i] == ')')
                {
                    closingParentheses++;
                }
                store.Add(testCase[i]);
                if (store.Count % 2 != 0 && closingParentheses > openingParentheses)
                {
                    store.Remove(store[i]);
                }

                Console.WriteLine(testCase[i]);
            }

            
           /* if(openingParentheses == 0)
            {
                Console.WriteLine("Valid string");
            }
            else
            {
                Console.WriteLine("Invalid string");
            }*/
        }
    }
}

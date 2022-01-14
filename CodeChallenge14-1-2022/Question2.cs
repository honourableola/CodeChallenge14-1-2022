using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge14_1_2022
{
    class Question2
    {
        public int SmallestDistanceAmongPair(int[] testArray, int pos)
        {
            List<int> distances = new List<int>();
            for(int i = 0; i < testArray.Length - 1; i++)
            {
                for(int j = i + 1; j < testArray.Length; j++)
                {
                    int distance = Math.Abs(testArray[i] - testArray[j]);
                    distances.Add(distance);
                }
            }
            distances.Sort();
            return distances[pos - 1];
        }
    }
}

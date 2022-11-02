using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare_the_triplets
{
    public static class Solution
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int totalAlice = 0;
            int totalBob = 0;


            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == b[i])
                    continue;

                if (a[i] > b[i])
                    totalAlice++;
                else
                    totalBob++;
            }

            List<int> pontuacao = new List<int> { totalAlice, totalBob };
            return pontuacao;
        }
    }
}

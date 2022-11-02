using compare_the_triplets;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TestesHackerRank
{
    public class CompareTheTripletsTests
    {
        [Fact]
       
        public void AliceDeveGanhar()
        {
            List<int> alice = new List<int> { 10, 11, 6, 5 };
            List<int> bob = new List<int> { 4, 5, 6, 7 };

            var pontuacao = Solution.CompareTriplets(alice, bob);

            Assert.True(pontuacao.First() > pontuacao.Last());
        }

        [Fact]
        public void BobDeveGanhar()
        {
            List<int> alice = new List<int> { 10, 11, 6, 5 };
            List<int> bob = new List<int> { 30, 10, 8, 6 };

            var pontuacao = Solution.CompareTriplets(alice, bob);

            Assert.True(pontuacao.First() < pontuacao.Last());
        }

        [Fact]
        public void DeveEmpatar()
        {
            List<int> alice = new List<int> { 30, 0, 8, 6 };
            List<int> bob = new List<int> { 30, 0, 8, 6 };

            var pontuacao = Solution.CompareTriplets(alice, bob);

            Assert.True(pontuacao.First() == pontuacao.Last());
        }
    }
}

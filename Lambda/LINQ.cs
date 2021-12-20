using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda
{
    internal static class LINQ
    {
        static List<int> FirstSeven = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        //var square = firstSeven.Select(x => x * x);
        static IEnumerable<int> FirstTen = Enumerable.Range(1, 10);

        public static IEnumerable<int> GetFirstTen()
        {
            return FirstTen;
        }

        public static List<int> GetFirstSeven()
        {
            return FirstSeven;
        }

        public static void printInts(IEnumerable<int> thisEnumeration)
        {
            foreach (int i in thisEnumeration)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        public static IEnumerable<int> squareEnum(IEnumerable<int> toSquare)
        {
            return toSquare.Select(x => x * x);
        }

        static List<int> Scores = new List<int>() { 97, 92, 81, 60 };
        public static List<int> GetScores()
        {
            return Scores;
        }

        public static IEnumerable<int> queryScores(List<int> scoresToQuery)
        {
            IEnumerable<int> ret = from score in scoresToQuery
            where score > 80
            select score;
            return ret;
        }





    }
}

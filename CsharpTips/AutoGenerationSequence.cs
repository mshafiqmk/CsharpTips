using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTips
{
    public class AutoGenerationSequence
    {
        public static void GenerateSequence(int start , int end)
        {
            var sequenceFromStartToEnd = Enumerable.Range(start, end);

            foreach (var item in sequenceFromStartToEnd)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] GenerateSequenceAsArray(int start , int end)
        {
            return Enumerable.Range(start, end).ToArray();
        }
        public static List<int> GenerateSequenceAsList(int start, int end)
        {
            return Enumerable.Range(start, end).ToList();
        }
    }
}

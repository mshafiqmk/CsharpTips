using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTips
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making One List of two list using zip() ext method ");
            EnumsWithLinq.MakeOnListOfTwoListOfStrings();

            Console.WriteLine("Making tuple of two list using zip() ext method ");
            EnumsWithLinq.MakeTupleOfTwoLists();

            //Generating sequence -> AutoGenerationSequence.cs

            //Generating sequence from 1 to 5
            AutoGenerationSequence.GenerateSequence(1,5);

            //Generating array from 10 to 60
            var arraryFromTenToFifty = AutoGenerationSequence.GenerateSequenceAsArray(10, 50);

            //Generating list from 100 to 129 
            var listFromHunderedToOneThrity = AutoGenerationSequence.GenerateSequenceAsList(100, 30);

        }
    }
}

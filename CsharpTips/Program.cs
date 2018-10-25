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
        }
    }
}

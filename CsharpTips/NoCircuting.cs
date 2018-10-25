using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTips
{
    public class NoCircuting
    {
        public static void DemoWithDubleAnd()
        {
            Console.WriteLine("With && Operator");
            bool b = false && checkName("shafiq");
        }

        internal static void DemoWithSingleAnd()
        {
            Console.WriteLine("With & Operator");
            bool b = false & checkName("shafiq");
        }
        private static bool checkName(string name)
        {
            Console.WriteLine("Checking name =>"+name);
            return true;
        }
    }
}

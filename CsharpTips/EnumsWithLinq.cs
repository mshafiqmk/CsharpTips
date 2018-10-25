using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTips
{
    public class EnumsWithLinq
    {
        public static void  MakeOnListOfTwoListOfStrings()
        {
            string[] names = new[] { "shafiq", "adnan", "khuidad" };
            string[] ages  = new[] { "22" , "8" ,"20"};
            IEnumerable<string> namesAndAges = names.Zip(ages, (name, age) => name + " " + age);
            foreach (var item in namesAndAges)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

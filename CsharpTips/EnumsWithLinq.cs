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
        public static void MakeTupleOfTwoLists()
        {
            var names = new[] { "shafiq", "khuidad", "khan" };
            var ages = new[] { 22, 58, 36 };
            var namesAndAges = names.Zip(ages, (name, age) => Tuple.Create(name, age));

            foreach (var nameAndAge in namesAndAges)
            {
                Console.WriteLine(nameAndAge.Item1 +" "+nameAndAge.Item2);
            }
            Console.ReadKey();
        }
    }
}

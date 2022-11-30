using System;
using System.Collections;
using System.Linq;
namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //The provided Array lists
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };

            /*I chose to make use of the C# LINQ set operations to query the given lists
             *
             */

            //a. Common elements in both lists
            IEnumerable<int> list3 = from arrayListA in list1.Intersect(list2)
                                        select arrayListA;             
            Console.WriteLine(string.Join(" ", list3));

            //b. Elements only in list1
            IEnumerable<int> list4 = from arrayListB in list1.Except(list2)
                                     select arrayListB;
            Console.WriteLine(string.Join(" ", list4));

            //Elements only in list2
            IEnumerable<int> list5 = from arrayListC in list2.Except(list1)
                                     select arrayListC;
            Console.WriteLine(string.Join(" ", list5));

            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();

        }
    }
}
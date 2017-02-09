using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace BinarySearch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TestW.txt");
            string text = System.IO.File.ReadAllText(path);
            Console.WriteLine(Rank(490636, text.Split(',').Select(int.Parse).ToArray()));
            Console.ReadKey(true);
        }

        private static int Rank(int key, int[] a)
        {
            var lo = 0;
            var hi = a.Length - 1;
            while (lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (key < a[mid])
                {
                    hi = mid - 1;
                }
                else if (key > a[mid])
                {
                    lo = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
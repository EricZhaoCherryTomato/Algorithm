using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rank(5, new[] {1,2,3,5,7}));
            Console.ReadKey(true);
        }

        static int Rank(int key, int[] a)
        {
            int lo = 0;
            int hi = a.Length - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (key < a[mid])
                {
                    hi = mid - 1;
                }
                else if(key > a[mid])
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

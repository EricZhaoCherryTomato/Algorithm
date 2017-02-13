using System;

namespace ThreeSumFast
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    public class BinarySearch
    {
        public int Rank(int[] numbers, int number)
        {
            var lo = 0;
            var hi = numbers.Length - 1;

            while (lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (number < numbers[mid])
                {
                    hi = mid - 1;
                }
                else if (number > numbers[mid])
                {
                    lo = mid + lo;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }

    public class TwoSum
    {
        public int Count(int[] numbers)
        {
            //An unsuccessful binary search returns- 1, so we do not increment the count.
            //If the binary search returns j > i, we have a[i] + a[j] = 0, so we increment the count.
            //If the binary search returns j between 0 and i, we also have a[i] + a[j] = 0 but do not increment the count, to avoid double counting.
            var cnt = 0;
            var bs = new BinarySearch();
            Array.Sort(numbers);
            for (var i = 0; i < numbers.Length; i++)
            {
                if (bs.Rank(numbers, -numbers[i]) > i)
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
  public  class Program
    {
        static void Main(string[] args)
        {
            //select 1
            //var nums = new List<int>();
            //var nums2 = nums.Where(x => x > 5);
        }

        public static List<int> Increment(List<int> nums)
        {
            var retVal = nums.Select(x => x + 1);
            return retVal.ToList();
        }

        public static int[] GetWhereDivisibleBy(List<int> nums, int x)
        {
            var retVal =  nums.Where(y => y % x == 0);
            return retVal.ToArray();
        }


    }
}

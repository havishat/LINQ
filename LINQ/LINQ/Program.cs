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

        public static bool AnyCapitals(string s)
        {
            return s.Any(x => char.IsUpper(x));
        }

        public static bool AllCapitals(string s)
        {
            return s.Where(x=> char.IsLetter(x)).All(x => char.IsUpper(x));
        }

        public static int NumPairs(Dictionary<int, string > dict)
        {
            return dict.Count();
        }

        public static int NumPairsWithKeyValue(Dictionary<int, string> dict, int x, int y)
        {
            return dict.Where(el => el.Key > x && el.Value.Length < y).Count();
        }


        public static  List<double> GetDistinctWithValue(List<double> nums, int x)
        {
            return nums.Distinct().Where(xy => xy < x).ToList();
            
        }

        public static int[] FindFirstArrayWithLength(List<int[]> arrays, int x)
        {
            return arrays.FirstOrDefault(y => y.Length > x);
        }

        public static int GetLastOddElement(int[] array)
        {

            return array.LastOrDefault(y => y % 2 == 1);

        }
    }
}

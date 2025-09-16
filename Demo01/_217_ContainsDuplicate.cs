using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class _217_ContainsDuplicate
    {
        /// <summary>
        /// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool ContainsDuplicate(int[] nums)
        {
            ////Approach 1: Brute Force
            //foreach (var i in nums)
            //{
            //    if (nums.Count(x => x == i) > 1) return true;
            //}
            //return false;


            ////Approach 2: Sorting
            //nums = nums.OrderBy(x => x).ToArray();
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] == nums[i - 1]) return true;
            //}
            //return false;


            ////Approach 3: Hash Set
            HashSet<int> hashSet = new HashSet<int>();
            foreach (int num in nums)
            {
                if (hashSet.Contains(num)) return true;
                hashSet.Add(num);
            }
            
            return false;

        }
    }
}

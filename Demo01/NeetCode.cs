using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo01
{
    public class NeetCode
    {
        //Arrays & Hashing

        /// <summary>
        /// 217. Contains Duplicate. Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hashSet = new HashSet<int>();
            foreach (int num in nums)
            {
                if (hashSet.Contains(num)) return true;
                hashSet.Add(num);
            }

            return false;
        }

        /// <summary>
        /// 242. Valid Anagram. Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else dic[c] = 1;
            }

            foreach (var c in t)
            {
                if (!dic.ContainsKey(c) || dic[c] == 0) return false;

                dic[c]--;
            }

            return true;
        }

        /// <summary>
        /// 1. Two Sum
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hashSet = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int other = target - nums[i];
                if (hashSet.ContainsKey(other))
                {
                    return new int[2] { i, hashSet[other] };
                }
                hashSet[nums[i]] = i;
            }
            throw new Exception("No solution found");
        }

        /// <summary>
        /// 49. Group Anagrams
        /// Given an array of strings strs, group the anagrams together.You can return the answer in any order.
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            
            foreach (string str in strs)
            {
                var c = str.ToArray();
                Array.Sort(c);

                var sorted = new string(c);

                if (!map.ContainsKey(sorted))
                    map[sorted] = new List<string>();
                map[sorted].Add(str);
            }

            return new List<IList<string>>(map.Values);
        }


    }
}

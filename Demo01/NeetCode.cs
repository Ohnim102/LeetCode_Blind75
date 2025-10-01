using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}

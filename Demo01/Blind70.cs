using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Blind70
    {
        /// <summary>
        /// 242. Valid Anagram. 
        /// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsAnagram(string s, string t)
        {
            ////Approach 1: Brute Force
            //if (s.Length != t.Length) return false;
            //foreach (var c in s)
            //{
            //    if (t.Contains(c))
            //    {
            //        t = t.Remove(t.IndexOf(c), 1);
            //        s = s.Remove(s.IndexOf(c), 1);
            //    }
            //    else return false;
            //}

            //if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t)) return true;
            //return false;


            ////Approach 2: Count c
            var count = new Dictionary<char, int>();
            if (s.Length != t.Length) return false;
            foreach (var c in s)
            {
                if (!count.ContainsKey(c)) count[c] = 0;
                count[c]++;
            }

            foreach (var c in t)
            {
                if (!count.ContainsKey(c)) return false;
                count[c]--;
                if (count[c] < 0) return false;
            }
            return true;
        }


    }
}

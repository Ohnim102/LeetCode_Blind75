using Demo01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Blind70
    {

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val != q.val) return false;

            // Recursively check if the left and right subtrees are identical
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }

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

        /// <summary>
        /// 268. Missing Number
        /// Given an array nums containing n distinct numbers in the range [0, n].
        /// Return the only number in the range that is missing from the array.
        /// </summary>
        public static int MissingNumber(int[] nums)
        {
            var n = nums.Length;
            var expectTotal = n * (n + 1) / 2;
            var actualTotal = 0;
            
            foreach (var i in nums)
            {
                actualTotal += i;
            }

            return expectTotal - actualTotal;
        }

        /// <summary>
        /// 572. Subtree of Another Tree
        /// Given the roots of two binary trees root and subRoot, 
        /// Return true if there is a subtree of root with the same structure and node values of subRoot and false otherwise.
        /// A subtree of a binary tree tree is a tree that consists of a node in tree and all of this node's descendants. 
        /// The tree tree could also be considered as a subtree of itself.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="subRoot"></param>
        /// <returns></returns>
        public static bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null) return false;

            if (IsSameTree(root, subRoot)) return true;

            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }

        /// <summary>
        /// 3. Longest Substring Without Repeating Characters. 
        /// Given a string s, find the length of the longest substring without duplicate characters.
        /// (More info: Sliding windows method)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {
            var seen = new Dictionary<char, int>();
            int left = 0, maxLen = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char c = s[right];

                if (seen.ContainsKey(c) && seen[c] >= left)
                {
                    // Move left pointer just past the previous occurrence
                    left = seen[c] + 1;
                }

                seen[c] = right; // Update latest index of character
                maxLen = Math.Max(maxLen, right - left + 1);
            }

            return maxLen;
        }
    }
}

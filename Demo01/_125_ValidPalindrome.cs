using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class _125_ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                // bỏ ký tự không alphanumeric bên trái
                while (left < right && !Char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                // bỏ ký tự không alphanumeric bên phải
                while (left < right && !Char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                // so sánh sau khi chuyển lowercase
                if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
                {
                    return false;
                }

                left++;
                right--;
            }
            return true;
        }

    }
}

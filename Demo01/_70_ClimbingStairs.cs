using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    /*
     Đây là bài LeetCode 70 - Climbing Stairs:
    - Có n bậc thang.
    - Mỗi lần có thể bước 1 bậc hoặc 2 bậc.
    - Cần tính số cách khác nhau để leo lên đỉnh.
    👉 Số cách leo lên bậc n = số cách leo lên bậc n-1 (sau đó bước 1 bậc) + số cách leo lên bậc n-2 (sau đó bước 2 bậc).
    👉 Giống dãy số Fibonacci: n = (n-1) + (n-2)
     */
    public class _70_ClimbingStairs
    {
        public int Main(int n)
        {
            return ClimbStairs01(n);
        }

        //Cách 1: Đệ quy (chậm – O(2^n))
        public int ClimbStairs01(int n)
        {
            if (n == 0 || n == 1) return 1;
            return ClimbStairs01(n - 2) + ClimbStairs01(n - 1);
        }

        //Cách 2: Dynamic Programming (O(n), bộ nhớ O(n))
        public int ClimbStairs02(int n)
        {
            if (n <= 1) return 1;

            var dp = new int[n + 1];
            dp[0] = dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }

        //Cách 3: Tối ưu bộ nhớ (O(n), space O(1))
        public int ClimbStairs03(int n)
        {
            if (n <= 1) return 1;

            int prev1 = 1, prev2 = 1, current = 0;

            for (int i = 2; i <= n; i++)
            {
                current = prev1 + prev2;
                prev2 = prev1;
                prev1 = current;
            }

            return prev1;
        }




    }
}

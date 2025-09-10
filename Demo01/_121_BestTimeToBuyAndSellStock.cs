using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class _121_BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int buy = prices[0];
            int currentProfit = 0;

            foreach (var price in  prices)
            {
                //Ta sẽ luôn muốn giá mua là giá thấp nhất
                if (price < buy)
                {
                    buy = price;
                }
                else if (price - buy > currentProfit)
                {
                    currentProfit = price - buy;
                }
            }

            return currentProfit;
        }

    }
}

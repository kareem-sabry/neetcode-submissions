public class Solution {
    public int MaxProfit(int[] prices) {
      int minPrice = prices[0], maxProfit = 0;

      for(int i = 1; i < prices.Length; i++)
      {
        if(prices[i] < minPrice)
        {
            minPrice = prices[i];
        }
        else
        {
            maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
        }
      }
      return maxProfit;
    }
}

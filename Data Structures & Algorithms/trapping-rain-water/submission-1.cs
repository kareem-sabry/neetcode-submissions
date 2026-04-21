public class Solution {
    public int Trap(int[] height) {
        if (height == null || height.Length < 3)
            return 0;
        int left = 0, right = height.Length - 1;
        int maxLeft = 0, maxRight = 0;
        int totalWater = 0;

        while(left < right)
        {
            if(height[left] < height[right])
            {
                 if(height[left] < maxLeft)
                {
                    totalWater += maxLeft - height[left];
                }
                else if (height[left] > maxLeft)
                {
                    maxLeft = height[left];
                }
                left++;
            }
            else
            {
                if(height[right] < maxRight)
                {
                    totalWater += maxRight - height[right];
                }
                else if (height[right] > maxRight)
                {
                    maxRight = height[right];
                }
                right --;
            }
        }
        return totalWater;
    }
}

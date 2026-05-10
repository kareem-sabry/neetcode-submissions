public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // Time : O(n) | Space : O(1)
        int product= 1; 
        int numZeroes = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                numZeroes++;
                continue;
            } 
            
            product = product * nums[i];
        }
        var output = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            if(numZeroes == 0)
            {
                output[i] = product / nums[i];
            }
            else if(numZeroes == 1)
            {
                if(nums[i] == 0)
                {
                    output[i] = product;
                }
                else
                {
                    output[i] = 0;
                }
            }
            else
            {
                output[i] = 0;
            }

        }
        return output;
    }
}

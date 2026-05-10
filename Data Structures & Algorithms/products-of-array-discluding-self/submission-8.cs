public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int rightProduct = 1;
        
        var result = new int[nums.Length];
        
        /*
            nums = [1 ,2 ,4 ,6]
            rightProduct = 6;
          result = [1, 1 ,2,8]
        */
        result[0] = 1;

        for(int i = 1; i < result.Length; i++)
        {
            result[i] = result[ i - 1] * nums[i - 1];
        }

        for(int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] = result[i] * rightProduct;
            rightProduct *= nums[i];
        }
        return result;
    
    
    }
}

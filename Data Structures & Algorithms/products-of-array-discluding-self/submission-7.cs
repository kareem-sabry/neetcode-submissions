public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // Time : O(n)  Space o(3n) => o(n)
        int leftProduct = 1, rightProduct = 1;
        var leftArray = new int[nums.Length];
        var rightArray = new int[nums.Length];
        var result = new int[nums.Length];
        
        /*
            nums = [1,2 ,4 ,6]
            left = 2
        leftArray= [1,1, ] 
        
        
        */
        leftArray[0] = 1;
        for(int i = 1; i < nums.Length; i++)
        {
            leftArray[i] = leftArray[i - 1] * nums[i - 1];
        }

        rightArray[nums.Length - 1] = 1;
        for(int i = nums.Length -2; i >=0; i-- )
        {
            rightArray[i] = rightArray[i + 1] * nums[ i + 1];
        }

        for(int i = 0; i < nums.Length; i++)
        {
            result[i] = leftArray[i] * rightArray[i];
        }
        return result;
    
    
    }
}

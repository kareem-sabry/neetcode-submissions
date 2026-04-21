public class Solution {
    public int LongestConsecutive(int[] nums) {
        int currentCount = 1;
        int longest = 1;
        if(nums.Length == 0)
        {
            return 0;
        }
        Array.Sort(nums);
        
        for(int i = 0; i < nums.Length -1; i++)
        {
            if(nums[i] == nums[i+1]) continue;

            if(nums[i+1] - nums[i] == 1 )
            {
                currentCount++;
            } 
            else 
            {
                longest = Math.Max(currentCount,longest);
                currentCount = 1;
            }
        }
        return Math.Max(longest,currentCount);
    }
   
}
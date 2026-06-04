public class Solution {
    public int LongestConsecutive(int[] nums) {
        // Time : O(nlogn + n) => o(nlog(n))
        // Space : O(1) C# uses introsort
        if(nums == null || nums.Length == 0)
            return 0;

        Array.Sort(nums);

        int max = 1, curr = 1;

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] == nums[i - 1])
                continue;
            
            if(nums[i] - nums[i - 1 ] == 1)
                curr++;
            else
                curr = 1;
            
            max = Math.Max(curr, max);
        }
        return max;
    }
}

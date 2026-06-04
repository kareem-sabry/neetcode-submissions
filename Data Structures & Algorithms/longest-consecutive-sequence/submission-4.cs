public class Solution {
    public int LongestConsecutive(int[] nums) {
       // Time: O(N)
       // Space: O(N)
        if(nums == null || nums.Length == 0)
            return 0;
        
        var set = new HashSet<int>(nums);
        int max = 1;
        foreach(var num in set)
        {
            if(!set.Contains(num - 1))
            {
                int currNum = num;
                int currLen = 1;

                while(set.Contains(currNum + 1))
                {
                    currLen++;
                    currNum++;
                }
                max = Math.Max(max,currLen);
            }
        }
        return max;
    }
}

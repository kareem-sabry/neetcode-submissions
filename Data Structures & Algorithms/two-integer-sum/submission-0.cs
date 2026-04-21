public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (!map.ContainsKey(complement))
            {
                map.Add(nums[i],i);
            }
            else
            {
                var lowerTerm = Math.Min(i, map[complement]);
                var upperTerm = Math.Max(i, map[complement]);
                return [lowerTerm,upperTerm];
            }
        }

        return [];
    }
}

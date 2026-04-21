public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums == null || nums.Length <= 1)
            return false;
        Dictionary<int,int> map = new();
        for(int i = 0; i < nums.Length; i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                return true;
            }
            else
            {
                map[nums[i]] = 1;
            }
        }
        return false;
    }
}
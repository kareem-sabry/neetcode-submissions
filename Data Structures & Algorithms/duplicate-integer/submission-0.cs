public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hash = new HashSet<int>(nums);
        if (nums.Length != hash.Count)
        {
            return true;
        }

        return false;
    }
}
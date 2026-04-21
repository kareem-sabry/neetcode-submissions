public class Solution {
    // Time : O(n)  , Space : O(n)
    public int LongestConsecutive(int[] nums) {
        if(nums == null || nums.Length == 0)
        return 0;

        var numbers = new HashSet<int>(nums);

        int longestStreak = 0;

        foreach(var num in numbers)
        {
            if(!numbers.Contains(num-1))
            {
                int currentNumber = num;
                int currentStreak = 1;

                while(numbers.Contains(currentNumber + 1))
                {
                    currentNumber++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak , currentStreak);
            }
        }
            return longestStreak;
    }
}

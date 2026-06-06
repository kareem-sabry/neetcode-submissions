public class Solution {
    public int[] TwoSum(int[] s, int target) {
        int left = 0, right = s.Length - 1;
        //[1,1,2,3,4]
        while(left < right)
        {

            var result = s[left] + s[right];

            if(result == target)
            {
                return new int[2]{left+1, right+1};
            }
            else if(result < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return new int[2];
    }
}

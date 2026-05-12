public class Solution {
    public bool IsPalindrome(string s) {
        // Time : O(n) | Space: O(1)
        int left = 0, right = s.Length - 1;

        /*
                         r
                 l
          s = "%%tab a cat"
        */

        while(left < right)
        {
            while(left < right && !char.IsLetterOrDigit(s[left])) left++;
            while(left < right && !char.IsLetterOrDigit(s[right])) right--;

            if(char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}

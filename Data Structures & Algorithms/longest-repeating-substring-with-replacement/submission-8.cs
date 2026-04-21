public class Solution {
    public int CharacterReplacement(string s, int k) {
        // Time : O(n) Space : O(n)
        var freq = new Dictionary<char, int>();
        int left = 0;
        int maxFreq = 0;
        int result = 0;

        for(int right = 0; right < s.Length; right++)
        {
            char cRight = s[right];
            if(!freq.ContainsKey(cRight))
            {
                freq[cRight] = 0;
            }
            freq[cRight]++;

            maxFreq = Math.Max(maxFreq, freq[cRight]);

            while((right - left + 1) - maxFreq > k)
            {
                char cLeft = s[left];
                freq[cLeft]--;
                left++;
            }

            result = Math.Max(result, right - left + 1);
        }
        return result;

    }
}

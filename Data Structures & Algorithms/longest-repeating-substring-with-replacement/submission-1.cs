public class Solution {
   public int CharacterReplacement(string s, int k) {
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++) {
            int[] counts = new int[26];
            int maxFreq = 0;

            for (int j = i; j < s.Length; j++) {
                counts[s[j] - 'A']++;
                maxFreq = Math.Max(maxFreq, counts[s[j] - 'A']);

                // Length of current substring is (j - i + 1)
                if ((j - i + 1) - maxFreq <= k) {
                    maxLength = Math.Max(maxLength, j - i + 1);
                }
            }
        }
        return maxLength;
    }
}

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int n1 = s1.Length;
        int n2 = s2.Length;
        if (n1 > n2)
            return false;
        
        int[] s1Count = new int[26];
        int[] windowCount = new int[26];

        for(int i = 0; i < n1; i++)
        {
            s1Count[s1[i] - 'a']++;
            windowCount[s2[i] - 'a']++;
        }
        
        for(int i = 0; i < n2 - n1 ; i++)
        {
            if (Matches(s1Count, windowCount)) return true;

            windowCount[s2[i+n1] - 'a']++;
            windowCount[s2[i] - 'a']--;
        }
        return Matches(s1Count,windowCount);

    }
    private bool Matches(int[] s1Count, int[] windowCount)
    {
        for(int i = 0; i < 26; i++)
        {
            if(s1Count[i] != windowCount[i])
            {
                return false;
            }
        }
        return true;
    }
}

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var hashSet = new HashSet<string>();

        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                var currentVal = board[i][j];
                
                if(currentVal != '.')
                {
                    if(!hashSet.Add(currentVal + " found in row" + i)
                    || !hashSet.Add(currentVal + " found in column " + j)
                    || !hashSet.Add(currentVal + " found in box " + i/3 + "-"+ j/3))
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }
}

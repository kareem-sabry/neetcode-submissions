public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        // brute force | Time : O(n ^ 2) space: o(n)
        int n = position.Length;
        if ( n <= 1) return n;

        var cars = new (int pos, double time) [n];

        for (int i = 0; i < n; i++)
        {
            double time = (double) (target - position[i]) / speed[i];
            cars[i] = (position[i],time);
        }
        
        Array.Sort(cars,(a,b)=>b.pos.CompareTo(a.pos));

        int fleets = 0;
        bool[] partOfFleet = new bool[n];

        for(int i = 0; i < n; i++)
        {
            if(partOfFleet[i]) continue;

            fleets++;
            double leadTime = cars[i].time;
            for(int j = i + 1; j < n; j++)
            {
                if(cars[j].time <= leadTime)
                    partOfFleet[j] = true;
                else
                {
                    break;
                }
            }
        }
        return fleets;
    }
}





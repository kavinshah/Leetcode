public class Solution {
    public int DistributeCandies(int[] candyType) {
        int maxCapacity=candyType.Length/2;
        HashSet<int> uniques = new HashSet<int>();
        
        for(int i=0; i<candyType.Length; i++)
        {
            uniques.Add(candyType[i]);
        }
        
        return Math.Min(uniques.Count, maxCapacity);
    }
}

//time: O(N)
//space: O(N)
public class Solution {
    public int DistributeCandies(int[] candyType) {
        int maxCapacity=candyType.Length/2;
        Dictionary<int,int> uniques = new Dictionary<int,int>();
        
        for(int i=0; i<candyType.Length; i++)
        {
            if(!uniques.ContainsKey(candyType[i]))
                uniques[candyType[i]]=0;
            uniques[candyType[i]]++;
        }
        
        return Math.Min(uniques.Keys.Count, maxCapacity);
    }
}

//time: O(N)
//space: O(N)
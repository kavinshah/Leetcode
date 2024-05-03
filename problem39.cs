/*

[2,3,6,7]

                                0, 7
                |             |               |               |
                0,5          1,4            2,1               0
        |         |    |    |   |           |           
        0,3      1,2   x   1,1  x           x
     |  |   |   |           |
    0,1 1,3 x   x           x
     |  |
    -1  0
                            
[2,2,3]
[7]


*/


public class Solution {
    IList<IList<int>> result;
    int[] candidates;
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        result = new List<IList<int>>();
        this.candidates = candidates;
        FindCombinations(0, target, new List<int>());
        return result;
    }
    
    public void FindCombinations(int start, int currentTarget, List<int> combinations){
        if(currentTarget < 0)
            return;
            
        if(currentTarget==0){
            result.Add(new List<int>(combinations));
        }
        
        for(int i=start; i<candidates.Length; i++){
            int newsum = currentTarget-candidates[i];
            combinations.Add(candidates[i]);
            FindCombinations(i, newsum, combinations);
            combinations.RemoveAt(combinations.Count-1);
        }
        
        return;
    }
}

//time: O(2^t*k)		---- for every combinations, we are allowed to pick an element multiple times and hence the complexity is 2^t and not 2^n. We also need O(k) time to copy over the elements to a new list if the target is reached
//space: O(k*x)			---- for x combinations, each of length k
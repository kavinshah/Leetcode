/*

2
3
5




*/

public class Solution {
    IList<IList<int>> result;
    int[] candidates;
    int target;
    
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        this.candidates=candidates;
        this.target=target;
        result=new List<IList<int>>();
        Permute(0, 0, new List<int>());
        return result;
    }
    
    public void Permute(int index, int currentSum, List<int> currentCombination)
    {
        if(index==candidates.Count() || currentSum>target)
            return;
        
        if(currentSum==target)
        {
            result.Add(new List<int>(currentCombination));
            return;
        }
        
        for(int i=index; i<candidates.Count(); i++)
        {
            currentCombination.Add(candidates[i]);
            Permute(i, currentSum+candidates[i], currentCombination);
            currentCombination.Remove(candidates[i]);
        }
        return;
    }
}

//time: O((N^(T/M))+1)
//space: O(T/M)

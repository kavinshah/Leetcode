/*

                                    0,8
                    |   |      |    |   |     |     |
                    x   1,7   2,6  3,1  4,2  5,7   6,3
                                


*/

public class Solution {
    IList<IList<int>> result = new List<IList<int>>();
    int[] candidates;
    
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        this.candidates = candidates;
        Array.Sort(this.candidates);
        Console.WriteLine(String.Join(",", this.candidates));
        FindCombinations(0,target, new List<int>());
        return  result.ToList();
    }
    
    public void FindCombinations(int index, int currentTarget, List<int> combinations){
        if(currentTarget<0){
            return;
        }
        
        if(currentTarget==0){
            result.Add(new List<int>(combinations));
            return;
        }
        
        for(int i=index; i<candidates.Length; i++){
            int newTarget = currentTarget - candidates[i];
            combinations.Add(candidates[i]);
            FindCombinations(i+1, newTarget, combinations);
            combinations.RemoveAt(combinations.Count-1);
            
            while((i+1)<candidates.Length && candidates[i]==candidates[i+1])
                i++;
        }
        return;
    }
}

//Time: O((2^N)*T) --- at every step, we either choose the element or don't which is O(2^N). We also need O(T) time to copy all elements from each combination into the resultset which takes O(T) time.
//Space: O(T*k) --- Assuming there are T combination, each of size k


/*

really good explanation: https://www.youtube.com/watch?v=Vn2v6ajA7U0&t=2s

[2,2,2,2]

[], 
2
2,2
2,2,2
2,2,2,2
2
2,2
2,2,2


                    1,2,3
                            0,[]
                       /           \
                   1,[]            1,[1]
               /        \
             2,[]      2,[2]
             /  \       /     \
        3, []   3, [3]  3,[2] 3, [2,3]
      
1,2,2,3
2
2 2
2 2 3
2
2 3



*/


public class Solution {
    int[] nums;
    IList<IList<int>> result = new List<IList<int>>();
    
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        this.nums=nums;
        Array.Sort(nums);
        FindSubsets(0, new List<int>());
        
        return result.ToList();
    }
    
    public void FindSubsets(int index, List<int> currentList){
        if(index==nums.Length){
            List<int> newList = new List<int>();
            newList.AddRange(currentList);
            result.Add(newList);
            return;
        }
        
        currentList.Add(nums[index]);
        FindSubsets(index+1, currentList);
        currentList.RemoveAt(currentList.Count-1);
        
        while((index+1)<nums.Length && nums[index]==nums[index+1]){
            index++;
        }
        FindSubsets(index+1, currentList);
        
        return;
    }
}

//time: O(N*2^N)
//space: O(N)

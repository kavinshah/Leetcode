/*

[2,4,6,10]

[2]
[2,6]
[2,6,10]
[2,10]
4,
4,10
6
6,10
10

*/

public class Solution {
    int[] nums;
    int result=0;
    int k;
    List<int> visited;
    public int BeautifulSubsets(int[] nums, int k) {
        this.nums=nums;
        this.visited=new List<int>();
        this.k=k;
        
        Array.Sort(this.nums);
        if(nums.Length==0)
            return 0;
        
        Dfs(0);
        return result;
    }
    
    public void Dfs(int index)
    {
        if(index==nums.Length)
            return;
        
        if(!visited.Contains(nums[index]-k))
        {
            result++;
            visited.Add(nums[index]);
            //Console.WriteLine(String.Join(",", visited));
            Dfs(index+1);
            visited.RemoveAt(visited.Count-1);
        }
        Dfs(index+1);
        return;
    }
}

//time: O(n*2^n)
//space: O(N)
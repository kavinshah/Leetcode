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
    //List<int> visited;
    Dictionary<int,int> visited;
    public int BeautifulSubsets(int[] nums, int k) {
        this.nums=nums;
        //this.visited=new List<int>();
        this.visited = new Dictionary<int, int>();
        this.k=k;
        if(nums.Length==0)
            return 0;
        Dfs(0);
        return result;
    }
    
    public void Dfs(int index)
    {
        if(index==nums.Length)
            return;
        
        if(!visited.ContainsKey(nums[index]-k) && !visited.ContainsKey(nums[index]+k))
        {
            result++;
            if(!visited.ContainsKey(nums[index]))
                visited[nums[index]]=0;
            visited[nums[index]]++;
            //Console.WriteLine(String.Join(",", visited.Keys));
            Dfs(index+1);
            visited[nums[index]]--;
            if(visited[nums[index]]==0)
                visited.Remove(nums[index]);
        }
        Dfs(index+1);
        return;
    }
}

//time: O(2^n)
//space: O(N)
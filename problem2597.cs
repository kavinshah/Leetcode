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

nums = [5, 5, 5, 7, 7]$, k = 2

skip_5=1
take_5=7
skip_7=skip_5 + take_5=8
take_7 = skip_5 * (2^counts-1) = 3

final answer = skip_7 + take_7 = 8+3=11

Here, for take_7, we only take skip_5 because 5+(1).k=7 i.e. difference between 5 and 7 =k and not multiple of k so we can consider either 5 or 7 at a time in a subset.
if 5+xk=7, then we can both the number:
take_7 = (take_5+skip_5)*(2^counts-1)

*/

public class Solution {
    int[] nums;
    int result=1;
    int k;
    Dictionary<int, Dictionary<int, int>> count;
    
    public int BeautifulSubsets(int[] nums, int k) {
        this.nums=nums;
        count=new Dictionary<int, Dictionary<int, int>>();
        
        foreach(int n in nums)
        {
            if(!count.ContainsKey(n%k))
                count[n%k]=new Dictionary<int, int>();
            if(!count[n%k].ContainsKey(n))
                count[n%k][n]=0;
            count[n%k][n]++;
        }
        
        for(int i=0; i<k; i++)
        {
            int prev=0;
            int dp0=1;
            int dp1=0;
            int[] sortedCounts;
            int power;
            
            if(!count.ContainsKey(i))
                continue;
            
            sortedCounts = count[i].Keys.ToArray();
            Array.Sort(sortedCounts);
            
            //Console.WriteLine(String.Join(",", sortedCounts));
            
            foreach(int n in sortedCounts)
            {
                power = (int) Math.Pow(2,count[i][n]);
                int temp=dp0;
                if(prev+k==n)
                {
                    dp0=dp0+dp1;
                    dp1=temp*(power-1);
                }
                else
                {
                    dp0=dp0+dp1;
                    dp1=(temp+dp1)*(power-1);
                }
                prev=n;
            }
            result=result*(dp1+dp0);
            //Console.WriteLine($"{result}, {dp0}, {dp1}");
            
        }
        
        return result-1;
    }
}


//time: O(NlogN+k)
//space: O(N+k)
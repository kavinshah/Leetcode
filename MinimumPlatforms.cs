/*

https://www.geeksforgeeks.org/problems/minimum-platforms-1587115620/1

								i
arr = 0145 0445 0555 0710 1026 1712 
dep = 0848 1144 1713 1734 1941 2242
		0	1	 2	  3		4	5
				j
		
i=0, j=0, platforms=1, result=1
i=1, j=0, platforms=2, result=2
i=2, j=0, platforms=3, result=3
i=3, j=0, platforms=4, result=4
i=4, j=1, platforms=3, result=4
i=5, j=1, platforms=4, result=4
i=5, j=2, platforms=3, result=4



*/


//User function Template for C#
class Solution
{
    //Complete this function
    //Function to find the minimum number of platforms required at the
    //railway station such that no train waits.
    public int findPlatform(int[] arr, int[] dep, int n)
    {
        //Your code here
        int result=1, platforms=1;
        int i=1, j=0;
        
        Array.Sort(arr);
        Array.Sort(dep);
        
        while(i<n && j<n){
            if( arr[i] <= dep[j] ){
                i++;
                platforms++;
            } else if(arr[i] > dep[j]) {
                j++;
                platforms--;
            }
            result = Math.Max(result, platforms);
        }
        
        return result;
    }
    
}

//Time: O(NlogN + 2*N)
//Space: O(2*N)
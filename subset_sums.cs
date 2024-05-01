//https://www.geeksforgeeks.org/problems/subset-sums2234/1
/*

                    [5,2,1,6]
                    /       \
                5           0
            /       \
            7       5
        /       \
        8       7
    /       \   / \
    14      8   13 7
    |       |   
    14      8
                    



*/


// User function Template for C#

class Solution {
    // Complete this function
    // Function to find the sum of all possible subsets of the given array.
    List<int> result, arr;
    public List<int> subsetSums(List<int> arr, int N) {
        // Your code here
        result = new List<int>{};
        this.arr = arr;
        FindSubsets(0, 0);
        return result;
    }
    
    public void FindSubsets(int index, int sum){
        if(index==arr.Count){
            result.Add(sum);
            return;
        }
        
        FindSubsets(index+1, sum+arr[index]);
        FindSubsets(index+1, sum);
        
    }
}

//time: O(2^N)
//space: O(N) -- if the result is not included in the space. This is the space taken by the recursive stack
//		: O(2^N) -- if the result is included in the space.
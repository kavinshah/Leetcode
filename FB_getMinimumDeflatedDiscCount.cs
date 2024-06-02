// Write any using statements here
/*

https://www.metacareers.com/profile/coding_puzzles?puzzle=183894130288005


[2, 5, 3, 6, 5]

[100,100,100]

[6, 5, 4, 3]

[2,2]

[1,2]

Approach:
- Start from the bottom
- If the current disk radius is larger than previous disk radius, then it needs to be deflated and also result needs to increased by 1(count)
- Repeat the previous for all the disks in the stack.

*/

class Solution {
  
  public int getMinimumDeflatedDiscCount(int N, int[] R) {
    // Write your code here
    int prev=R[N-1];
    int result=0;
    
    for(int i=N-2; i>=0; i--)
    {
      if(R[i]>=prev)
      {
        R[i] = Math.Max(1, prev-1);
        if(R[i]==prev)
        {
          return -1;
        }
        result++;
      }
      prev=R[i];
    }
    
    return result;
  }
  
}

//time: O(N)
//Space: O(1)
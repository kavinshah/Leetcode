/*

Solution:
https://www.youtube.com/watch?v=9gYwDmPRZrw

Hint:
1. You can move from large to small number or small to large number.
The shortest circular distance between 2 numbers is Min{(a-b+N)%N, (b-a+N)%N}

2. In C#, the modulo operator can return negative as opposed to Python which always returns a positive number.
eg. in C#, -4%10 = -4
in Python, -4%10 = 6

*/

// Write any using statements here

class Solution {
  
  public long getMinCodeEntryTime(int N, int M, int[] C) {
    // Write your code here
    long result=0L;
    int prev = 1;
    
    foreach(int n in C)
    {
      result += Math.Min((n-prev+N)%N, (prev-n+N)%N);
      prev=n;
    }
    
    return result;
  }

}
/*

prev=1, result=2
prev=9, result=7
prev=4, result=7
prev=4, result=11

*/
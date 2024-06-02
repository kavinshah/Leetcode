// Write any using statements here
/*

https://www.metacareers.com/profile/coding_puzzles?puzzle=348371419980095

[1,2,3,4,5,6]
[4,3,3,4]
[1,1,2]
[2,4,6,8]
[2,2,2,2]
[1, 1, 2, 2, 2, 2, 2]
[1, 2, 2, 2, 2, 2]
[7,10,5,6]
[1,1,2,2,2,2]
[7,10,9,5]
[1,1,2,2,2,2]
[10,10,10,10]
[9,10,10,10,10]
[1,3,5,7]
[2,3,5,7]
[2,2,2,2]
[2,3,5,8]

Explanation: 

- The player scores can be even or odd
- Since each problem can have a score of 1 or 2:
	- we can get the max player score and divide by 2. This will be added to the result. This is done to account for the total number of problems with score=2
	- we also need to check if there are any odd numbers and add 1 to the result. This is done so that we can also account for problems with score = 1
	
*/

class Solution {
  
  public int getMinProblemCount(int N, int[] S) {
    // Write your code here
    int max=S[0];
    int result=0;
    bool hasEven=false;
    
    foreach(int x in S)
    {
      if(x>max)
      {
        max=x;
      }
      if(x%2==1)
        hasEven=true;
    }
    
    if(hasEven)
      result=1;
    
    result += (int)(max/2);
    
    return result;
    
  }
  
}

//time: O(N)
//Space: O(1)
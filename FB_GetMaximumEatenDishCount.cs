// Write any using statements here
/*

https://www.metacareers.com/profile/coding_puzzles?puzzle=958513514962507

NlogK

*/
using System.Collections.Generic;

class Solution {
  
  public int getMaximumEatenDishCount(int N, int[] D, int K) {
    // Write your code here
    List<int> dishes = new List<int>(N);
    HashSet<int> eaten = new HashSet<int>();
    int startIndex=0, result=0;
    
    foreach(int item in D)
    {
      if(!eaten.Contains(item))
      {
        if(eaten.Count>=K)
        {
          eaten.Remove(dishes[startIndex]);
          startIndex++;
        }
        
        eaten.Add(item);
        dishes.Add(item);
        result++;
      }
    }
    
    return result;
  }
  
}

//time: O(NLogK)
//Space: O(N)
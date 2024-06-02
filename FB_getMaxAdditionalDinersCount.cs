// Write any using statements here

/*https://www.metacareers.com/profile/coding_puzzles?puzzle=203188678289677

https://github.com/alembfilho/meta/blob/master/cafeteria.js

0 1 0 2 0 1 0 2 0 2
1 2 3 4 5 6 7 8 9 10


2 0 0 0 0 1 0 0 0 0  1   0  0  1  0
1 2 3 4 5 6 7 8 9 10 11 12 13 14 15



*/
using System.Collections.Generic;

class Solution {
  
  public long getMaxAdditionalDinersCount(long N, long K, int M, long[] S) {
    // Write your code here
    
    int[] positions = new int[N+1];
    long result=0;
    bool isOpenNext=false;
    long prev=-1;
    
    foreach(long p in S)
    {
      positions[p] = 1;
    }

    for(long i=1; i<=N; i++)
    {
      isOpenNext=true;
      if(positions[i]==1)
      {
        prev=Math.Max(i, prev);
        continue;
      }
      
      //check next
      for(long j=i+1; j<=Math.Min(i+K, N); j++)
      {
        if(positions[j]==1)
        {
          isOpenNext = false;
          break;
        }
      }
      
      if(!isOpenNext)
      {
        continue;
      }
      
      //check previous
      if((prev==-1 || (i-prev)>K) && isOpenNext)
      {
        positions[i]=1;
        prev=Math.Max(i, prev);
        result++;
      }
    }
    
    return result;
  }

}

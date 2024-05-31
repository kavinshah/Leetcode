// Write any using statements here
/*



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
    long prev=-1;
    Queue<long> nextPositions = new Queue<long>();
    
    foreach(long p in S)
    {
      positions[p] = 1;
    }
    
    for(long i=1; i<=N; i++)
    {
      if(positions[i]==1)
      {
        nextPositions.Enqueue(i);
      }
    }
    
    for(long i=1; i<=N; i++)
    {
      if(positions[i]==1)
      {
        prev=i;
        continue;
      }
      
      //check next
      while(nextPositions.Count>0 && nextPositions.Peek()<i)
        nextPositions.Dequeue();
      
      if(nextPositions.Count>0 && (nextPositions.Peek()-i)<K)
      {
        prev=nextPositions.Dequeue();
        i=prev;
        continue;
      }
      
      //check prev
      if(prev==-1 || (i-prev)>K)
      {
        positions[i]=1;
        prev=i;
        Console.WriteLine(i);
        result++;
        i=i+K;
      }
    }
    
    return result;
  }

}

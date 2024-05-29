// Write any using statements here
/*

https://www.metacareers.com/profile/coding_puzzles?puzzle=870874083549040

a p a b a
0 1 2 3 4

a p a b a
0 1 2 3 4


. p b a a p . b
0 1 2 3 4 5 6 7


O(N*(Y-X)^2)



*/


class Solution {
  
  public int getArtisticPhotographCount(int N, string C, int X, int Y) {
    // Write your code here
    char[] pset = C.ToCharArray();
    int result=0;
    Console.WriteLine(C);
    for(int i=0; i<N; i++)
    {
      if(pset[i]!='P' && pset[i]!='B')
        continue;
      
      for(int j=i+X; j<=(i+Y); j++)
      {
        if(j>=N)
          break;
        
        if(pset[j]!='A')
          continue;
        
        for(int k=j+X; k<=(j+Y); k++)
        {
          if(k>=N)
            break;
          
          //Console.WriteLine("{0}, {1}, {2}", pset[i], pset[j], pset[k]);
          
          if(k<N && ((pset[i]=='P' && pset[k]=='B') || (pset[i]=='B' && pset[k]=='P')))
            result++;
        }
      }
    }
    
    return result;
  }
  
}

// Time: O(N*(Y-X)^2)
//Space: O(N)
// Write any using statements here

/*

https://www.metacareers.com/profile/coding_puzzles?puzzle=228269118726856

for 1-9:
  9
  
for 10-99:
  9
  
for 100-999:
  9
  
for 1000-9999:
  9
  
integers between 75-300:
int[75] : 9+6 = 15
int[300] : 9+9+2 = 20

20-15 = 5



*/


class Solution {
  
  public int getUniformIntegerCountInInterval(long A, long B) {
    // Write your code here
    
    int resultA, resultB;
    long num1=A, num2=B;
    int digitsA=0, digitsB=0;
    int prev=0;
    
    while(num1>0)
    {
      prev=(int)(num1%10);
      num1=(long)(num1/10);
      digitsA++;
    }
    
    resultA = (digitsA-1)*9;
    
    num1=0;
    while(digitsA>0)
    {
      num1=num1*10+prev;
      digitsA--;
    }
    
    if(num1>=A)
    {
      resultA += prev-1;
    } else {
      resultA += prev;
    }
    
    while(num2>0)
    {
      prev=(int)(num2%10);
      num2=(long)(num2/10);
      digitsB++;
    }
    
    resultB = (digitsB-1)*9;
    
    num2=0;
    while(digitsB>0)
    {
      num2=num2*10+prev;
      digitsB--;
    }
    
    if(num2>B)
    {
      resultB += prev-1;
    } else {
      resultB += prev;
    }
    
    return resultB-resultA;
  }
  
}

//time: O(M+N)
//Space: O(1)
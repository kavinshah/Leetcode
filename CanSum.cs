/*

https://www.youtube.com/watch?v=oBt53YbR9Kk&t=5418s

Given a target and an array of numbers, return true if a combination of numbers exists that is equal to the target.
The numbers can be used any number of times in the sum.

*/

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Test(7, new int[]{5,3,4,7});
        Test(23, new int[]{5,3,4,7});
    }
    
    public static void Test(int target, int[] numbers)
    {
        CanSum c = new CanSum(target, numbers);
        Console.WriteLine(c.CheckCanSum());
    }
}

public class CanSum
{
    int target;
    int[] numbers;
    bool[] dp;
    
    public CanSum(int target, int[] numbers)
    {
        this.target = target;
        this.numbers = numbers;
        Array.Sort(this.numbers);
        this.dp = new bool[target+1];
    }
    
    public bool CheckCanSum()
    {
        for(int i=1; i<=target; i++)
        {
            for(int j=0; j<numbers.Length; j++)
            {
                if((i-numbers[j]) < 0)
                {
                    continue;
                }
                
                if((i-numbers[j]) == 0 || dp[(i-numbers[j])])
                {
                    dp[i] = true;
                    break;
                }
            }
        }
        
        return dp[target];
    }
    
}

//Time: O(N*target) -- N = length of numbers array
//Space: O(target)
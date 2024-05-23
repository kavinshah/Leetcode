// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
/*

https://www.youtube.com/watch?v=oBt53YbR9Kk&t=5418s

Given a target and an array of numbers, return the shortest combination of numbers which equals whose sum equals to target.
The numbers can be used any number of times in the sum.


*/


using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Test(7, new int[]{5,3,4,7});
        Test(8, new int[]{2,3,5});
        Test(8, new int[]{1,4,5});
        Test(100, new int[]{1,2,5,25});
    }
    
    public static void Test(int target, int[] numbers)
    {
        BestSum b = new BestSum(target, numbers);
        List<int> combination = b.CheckBestSum();
        if(combination == null)
        {
            Console.WriteLine("{0} : False", target);
        } else {
            Console.WriteLine("{0}: [{1}]", target, String.Join(",", combination));
        }
    }
}

public class BestSum
{
    int target;
    int[] numbers;
    Dictionary<int, List<int>> dp;
    
    public BestSum(int target, int[] numbers)
    {
        this.target = target;
        this.numbers = numbers;
        Array.Sort(this.numbers);
        Array.Reverse(this.numbers);
        this.dp = new Dictionary<int, List<int>>();
    }
    
    public List<int> CheckBestSum()
    {
        for(int i=1; i<=target; i++)
        {
            dp[i] = null;
            foreach(int n in numbers)
            {
                if((i-n) < 0)
                {
                    continue;
                }
                
                if((i-n) == 0)
                {
                    dp[i] = new List<int>(){n};
                    break;
                }
                
                if(dp.ContainsKey(i-n) && dp[i-n]!= null)
                {
                    if(dp[i] == null || dp[i-n].Count < (dp[i].Count-1))
                    {
                        List<int> combination = new List<int>();
                        combination.AddRange(dp[i-n]);
                        combination.Add(n);
                        dp[i] = combination;
                    }
                }
            }
        }
        return dp[target];
    }
}

//time: O(target*n*target)
//Space: O(target*target)
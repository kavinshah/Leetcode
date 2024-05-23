/*

Given a target and an array of strings - wordbank, return a boolean if the target string can be constructed from the wordbank.

We can reuse elements of wordbank any number of times.

*/

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Text;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Test("abcdef", new string[]{"ab", "abc", "cd", "def", "abcd"});
        Test("abcdef", new string[]{"ab", "abc", "cd", "bcdef", "abcd"});
        Test("skateboard", new string[]{"bo", "rd", "ate", "t", "ska", "sk", "boar"});
        Test("enterapotentpot", new string[]{"a", "p", "ent", "enter", "ot", "o", "t"});
    }
    
    public static void Test(string target, string[] wordDict)
    {
        CanConstruct c = new CanConstruct(target, wordDict);
        Console.WriteLine(c.CheckCanConstruct(0));
    }
}

public class CanConstruct
{
    string target;
    HashSet<string> wordDict;
    int[] dp;
    
    public CanConstruct(string target, string[] wordDict)
    {
        this.target = target;
        this.wordDict = new HashSet<string>(wordDict);
        this.dp = new int[target.Length];
    }
    
    public bool CheckCanConstruct(int index)
    {
        
        if(index==target.Length)
        {
            return true;
        }
        
        if(dp[index] != 0)
        {
            return dp[index]==1?true:false;
        }
        
        //backtracking
        StringBuilder currentString = new StringBuilder();
        for(int i=index; i<target.Length; i++)
        {
            currentString.Append(target[i]);
            if(!wordDict.Contains(currentString.ToString()))
            {
                continue;
            }
            
            if(CheckCanConstruct(i+1))
            {
                dp[index]=1;
                return true;
            }
        }
        
        dp[index]=-1;
        return false;
    }
}

//time: O(N^2) -- n= target.length, m=worddict.count
//space: O(N)
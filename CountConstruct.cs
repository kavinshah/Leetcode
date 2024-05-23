/*

Given a target and an array of strings - wordbank, return the number of ways the target string can be constructed from the wordbank.

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
        Test("abcdef", new string[]{"ab", "abc", "cd", "def", "abcd"}); //t
        Test("abcdef", new string[]{"ab", "abc", "cd", "ef", "def", "abcd"}); //t
        // Test("abcdef", new string[]{"ab", "abc", "cd", "bcdef", "abcd"}); ///f
        // Test("skateboard", new string[]{"bo", "rd", "ate", "t", "ska", "sk", "boar"}); //f
        // Test("enterapotentpot", new string[]{"a", "p", "ent", "enter", "ot", "o", "t"}); //t
    }
    
    public static void Test(string target, string[] wordDict)
    {
        CountConstruct c = new CountConstruct(target, wordDict);
        c.CheckCountConstruct(0);
        Console.WriteLine(c.result);
    }
}

public class CountConstruct
{
    string target;
    HashSet<string> wordDict;
    int[] dp;
    public int result=0;
    
    public CountConstruct(string target, string[] wordDict)
    {
        this.target = target;
        this.wordDict = new HashSet<string>(wordDict);
        this.dp = new int[target.Length];
    }
    
    public bool CheckCountConstruct(int index)
    {
        if(index==target.Length)
        {
            result++;
            return true;
        }
        
        if(dp[index]!=0)
        {
            return dp[index]==1?true:false;
        }
        
        StringBuilder sb = new StringBuilder();
        for(int i=index; i<target.Length; i++)
        {
            sb.Append(target[i]);
            if(!wordDict.Contains(sb.ToString()))
            {
                continue;
            }
            if(CheckCountConstruct(i+1))
            {
                dp[index]=1;
            }
        }
        
        if(dp[index]==0)
        {
            dp[index]=-1;
            return false;
        }
        
        return true;
    }
}

//**need to re-verify time and space complexity
//Time: O(N^2) -- n=target.length, m=wordDict.count
//Space: O(N)
/*

** Revisit tabulation
** revisit time and space complexity 

https://www.youtube.com/watch?v=oBt53YbR9Kk&t=5418s

Given a target and an array of strings - wordbank, return a boolean if the target string can be constructed from the wordbank.

We can reuse elements of wordbank any number of times.

*/

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

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
        Console.WriteLine(c.CheckCanConstruct());
    }
}

public class CanConstruct
{
    string target;
    HashSet<string> wordDict;
    bool[] dp;
    
    public CanConstruct(string target, string[] wordDict)
    {
        this.target = target;
        this.wordDict = new HashSet<string>(wordDict);
        this.dp = new bool[target.Length+1];
        this.dp[0]=true;
    }
    
    public bool CheckCanConstruct()
    {
        for(int i=0; i<target.Length; i++)
        {
            if(dp[i])
            {
                foreach(string word in wordDict)
                {
                    if((i+word.Length)<=target.Length && target.Substring(i, word.Length) == word)
                    {
                        //Console.WriteLine("{0}, {1}", i, word);
                        dp[i+word.Length]=true;
                    }
                }
            }
        }
        //Console.WriteLine(String.Join(",", dp));
        return dp[target.Length];
    }
}

//Time: O(N^2*M) -- n=target.length, m=worddict.Count
//Space: O(N)
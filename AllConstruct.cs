/*

Given a target and an array of strings - wordbank, return all the ways in which the target string can be constructed using elements from the wordbank.

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
        Test("abcdef", new string[]{"ab", "abc", "cd", "def", "abcd"}); //t
        Test("abcdef", new string[]{"ab", "abc", "cd", "ef", "def", "abcd"}); //t
        Test("abcdef", new string[]{"ab", "abc", "cd", "bcdef", "abcd"}); ///f
        Test("skateboard", new string[]{"bo", "rd", "ate", "t", "ska", "sk", "boar"}); //f
        Test("enterapotentpot", new string[]{"a", "p", "ent", "enter", "ot", "o", "t"}); //t
    }
    
    public static void Test(string target, string[] wordDict)
    {
        AllConstruct c = new AllConstruct(target, wordDict);
        c.CheckAllConstruct(0);
        IList<IList<string>> result = c.result;
        Console.WriteLine("{0}, [{1}]", target, String.Join(",", wordDict));
        foreach(IList<string> r in result)
        {
            Console.WriteLine(String.Join(",", r));
        }
        return;
    }
}

public class AllConstruct
{
    string target;
    HashSet<string> wordDict;
    int[] dp;
    public IList<IList<string>> result;
    Stack<string> stack;
    
    public AllConstruct(string target, string[] wordDict)
    {
        this.target = target;
        this.wordDict = new HashSet<string>(wordDict);
        this.dp = new int[target.Length];
        this.result = new List<IList<string>>();
        this.stack = new Stack<string>();
    }
    
    public bool CheckAllConstruct(int index)
    {
        if(index==target.Length)
        {
            result.Add(new List<string>(stack));
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
            stack.Push(sb.ToString());
            if(CheckAllConstruct(i+1))
            {
                dp[index]=1;
            }
            stack.Pop();
        }
        
        if(dp[index]==0)
        {
            dp[index]=-1;
            return false;
        }
        
        return true;
    }
}

//**need to confirm the time and space complexity
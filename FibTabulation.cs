/*

Write a function fib(n) that takes in a number and returns the nth number of the Fibonacci sequence.

*/

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Test(8);
        Test(15);
        Test(32);
        Test(50);
    }
    
    public static void Test(int nth)
    {
        Fibonacci fib = new Fibonacci(nth);
        Console.WriteLine(fib.FindFibonacci());
    }
}

public class Fibonacci
{
    int target;
    long[] dp;
    public Fibonacci(int target)
    {
        this.target = target;
        this.dp = new long[target+1];
        this.dp[0]=0;
        this.dp[1]=1;
    }
    
    public long FindFibonacci()
    {
        for(int i=2; i<=target; i++)
        {
            dp[i] = dp[i-1] + dp[i-2];
        }
        return dp[target];
    }
}

//Time: O(target)
//space: O(target)

/*

x=2, n=10

res=2, exp=1
res=4, exp=2
res=16, exp=4
res=256, exp=8
res=512, exp=9
res=1024, exp=10

x=3, n=7
res=3, exp=1
res=9, exp=2
res=81, exp=4
res=243, exp=5
res=729, exp=6
res= 2187, exp=7

*/


public class Solution {
    Dictionary<uint, double> powers = new Dictionary<uint, double>(){{0, 1}};
    
    public double MyPow(double x, int n) {
        
        if(n==0)
            return 1;
        
        if(n<0)
        {
            return Calculate(1.0/x, (uint)-n);
        }
        
        return Calculate(x, (uint)n);
    }
    
    public double Calculate(double x, uint n)
    {
        if(powers.ContainsKey(n))
            return powers[n];
        
        if(n%2==1)
        {
            powers[n] = Calculate(x,(uint)(n/2))*Calculate(x,(uint)(n/2))*x;
        }
        else
        {
            powers[n] = Calculate(x,(uint)(n/2))*Calculate(x,(uint)(n/2));
        }
        //Console.WriteLine("{0}, {1}", n, powers[n]);
        return powers[n];
    }
}

//Time: O(log N)
//space: O(log N)
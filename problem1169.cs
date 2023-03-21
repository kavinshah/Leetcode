/*

// maintain 2 hashmap for invalid and valid transactions
// check the transaction is less than or = 1000
// check in invalid hashmap if a transaction within 60 mins exists
// add the transaction in invalid hashmap if invalid.
// check in valid hashmap if a transaction within 60 mins exists
// remove the transaction from valid hashmap if it exists and put it in invalid hashmap
// add the new transaction to the invalid hashmap


*/


public class Transaction
{
    public string name, city;
    public int amount, time;
    
    public Transaction()
    {
        name="";
        city="";
        amount=0;
        time=0;
    }
    
    public override string ToString()
    {
        return name + "," + time + "," + amount + "," + city;
    }
}

public class Solution {
    Dictionary<string, List<Transaction>>  valid, invalid;
    
    public IList<string> InvalidTransactions(string[] transactions) {
        valid = new Dictionary<string, List<Transaction>>();
        invalid = new Dictionary<string, List<Transaction>>();
        
        foreach(string t in transactions)
        {
            string[] values = t.Split(',');
            Transaction obj = new Transaction();
            obj.name=values[0];
            obj.time=Convert.ToInt32(values[1]);
            obj.amount=Convert.ToInt32(values[2]);
            obj.city=values[3];
            
            if(!invalid.ContainsKey(obj.name))
            {
                invalid[obj.name]=new List<Transaction>();
            }
            if(!valid.ContainsKey(obj.name))
            {
                valid[obj.name]=new List<Transaction>();
            }
            bool flag=false;
            if(obj.amount>1000)
                flag=true;
            if(CheckInvalidTransactions(obj))
                flag=true;
            
            if(CheckValidTransactions(obj))
                flag=true;
            
            if(flag)
            {
                invalid[obj.name].Add(obj);
            }
            else
            {
                valid[obj.name].Add(obj);
            }
        }
        
        List<string> result=new List<string>();
        foreach(var kvp in invalid)
        {
            foreach(Transaction t in kvp.Value)
                result.Add(t.ToString());
        }
        
        return result;
    }
    
    public bool CheckValidTransactions(Transaction newTransaction)
    {
        bool flag=false;
        
        for(int i=0; i<valid[newTransaction.name].Count;)
        {
            Transaction t=valid[newTransaction.name][i];
            if(t.time>=(newTransaction.time-60)
               && t.time<=(newTransaction.time+60)
               && newTransaction.city!=t.city)
            {
                flag=true;
                valid[t.name].RemoveAt(i);
                invalid[t.name].Add(t);
                // Console.Write("Removed Transaction - \t");
                // Console.WriteLine(t.ToString());
            }
            else
                i++;
        }
        
        return flag;
    }
    
    public bool CheckInvalidTransactions(Transaction newTransaction)
    {
        for(int i=0; i< invalid[newTransaction.name].Count; i++)
        {
            Transaction t=invalid[newTransaction.name][i];
            if(t.time>=(newTransaction.time-60)
               && t.time<=(newTransaction.time+60)
               && newTransaction.city!=t.city)
            {
                // Console.Write("Found Invalid Transaction - \t");
                // Console.WriteLine(t.ToString());
                return true;
            }
        }
        return false;
    }
}

//Time: O(N^2)
//Space: O(N)
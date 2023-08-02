public class Solution {
    public int MinKnightMoves(int x, int y) {
        int MaxX=300, MaxY=300;
        Queue<(int,int,int)> queue = new Queue<(int,int,int)>();
        int MinMoves=Int32.MaxValue;
        HashSet<(int,int)> visited= new HashSet<(int,int)>();
        
        visited.Add((0,0));
        queue.Enqueue((0,0,0));
        
        while(queue.Count>0)
        {
            (int,int,int) current = queue.Dequeue();
            int CX=current.Item1, CY=current.Item2, CM=current.Item3;
            
            if(CX==x && CY==y && CM<MinMoves)
            {
                MinMoves=CM;
                continue;
            }
            
            if(CM>MinMoves)
                continue;
            
            if(!visited.Contains((CX-2, CY-1)))
            {
                visited.Add((CX-2, CY-1));
                queue.Enqueue((CX-2, CY-1, CM+1));
            }
            
            if(!visited.Contains((CX-1, CY-2)))
            {
                visited.Add((CX-1, CY-2));
                queue.Enqueue((CX-1, CY-2, CM+1));
            }
            
            if(!visited.Contains((CX+1, CY-2)))
            {
                visited.Add(((CX+1, CY-2)));
                queue.Enqueue((CX+1, CY-2, CM+1));
            }
            
            if(!visited.Contains((CX+2, CY-1)))
            {
                visited.Add((CX+2, CY-1));
                queue.Enqueue((CX+2, CY-1, CM+1));
            }
                
            if(!visited.Contains((CX-2, CY+1)))
            {
                visited.Add((CX-2, CY+1));
                queue.Enqueue((CX-2, CY+1, CM+1));
            }
            
            if(!visited.Contains((CX-1, CY+2)))
            {
                visited.Add((CX-1, CY+2));
                queue.Enqueue((CX-1, CY+2, CM+1));
            }
                
            if(!visited.Contains((CX+1, CY+2)))
            {
                visited.Add((CX+1, CY+2));
                queue.Enqueue((CX+1, CY+2, CM+1));
            }
            
            if(!visited.Contains((CX+2, CY+1)))
            {
                visited.Add((CX+2, CY+1));
                queue.Enqueue((CX+2, CY+1, CM+1));
            }
                        
            //PrintQueue(queue);
        }
        return MinMoves;
    }
    
    public void PrintQueue(Queue<(int,int,int)> queue)
    {
        foreach(var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}

//BFS using circle logic
// Time : O(max(x,y)^2)
// space : O(max(x,y)^2)
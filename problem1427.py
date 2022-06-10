"""

abc
0,1 - bca
1,2 - cab

abcdefg
[1,1] -> gabcdef
[1,1] -> fgabcde
[0,2] -> 
[1,3] -> 


"""
class Solution:
    def stringShift(self, s: str, shift: List[List[int]]) -> str:
        lstring = deque(s)
        
        for op in shift:
            if op[0]==0:
                for i in range(op[1]):
                    ch = lstring.popleft()
                    lstring.append(ch)
            else:
                for i in range(op[1]):
                    ch=lstring.pop()
                    lstring.appendleft(ch)
            
            #print(lstring, op)
            
        return ''.join(lstring)
        
    
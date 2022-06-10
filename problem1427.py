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
        left=0
        right=0
        length = len(lstring)
        for op in shift:
            if op[0]==0:
                left+=op[1]
            else:
                right+=op[1]

        if (left-right)>0:
            amount=(left-right)%length
            for i in range(amount):
                ch=lstring.popleft()
                lstring.append(ch)
        else:
            amount=(right-left)%length
            for i in range(amount):
                ch=lstring.pop()
                lstring.appendleft(ch)
                
        return ''.join(lstring)
        
    
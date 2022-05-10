class Solution:
    def isValid(self, s: str) -> bool:
        bracketStack = []
        closingBracket = {')':'(', ']':'[', '}':'{'}
        for char in s:
            if char in ('(', '{', '['):
                bracketStack.append(char)
            elif char in ('}',')',']') and (len(bracketStack)==0 or closingBracket[char] != bracketStack[-1]):
                return False
            else:
                bracketStack.pop()
                
        return not bracketStack
    
#time: O(N), Space:O(N)
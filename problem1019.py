# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
"""
approach 1:
[5,3] 
pop from stack until stack is not empty and curr element > stack.top
use stack.top else 0
push current element on stack.

[2,1,5]
approach 2:
stack = [[0,2]], res = [0]
stack = [[0,2],[1,1]], res = [0,0]
stack = [], res = [5,5,0]

"""
class Solution:
    def nextLargerNodes(self, head):
        res, stack = [], []
        while head:
            while stack and stack[-1][1] < head.val:
                res[stack.pop()[0]] = head.val
            stack.append([len(res), head.val])
            res.append(0)
            head = head.next
        return res
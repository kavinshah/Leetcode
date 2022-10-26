class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        rows = [[0]*9 for i in range(9)]
        cols = [[0]*9 for i in range(9)]
        boxes = [[[0]*9 for i in range(3)], [[0]*9 for i in range(3)], [[0]*9 for i in range(3)]]
        print(boxes)
        for r in range(9):
            for c in range(9):
                item = board[r][c]
                if item==".":
                    continue
                item = int(item) - 1
                if rows[r][item]==1:
                    return False
                if cols[c][item]==1:
                    return False
                if boxes[r//3][c//3][item]==1:
                    return False

                rows[r][item]=1
                cols[c][item]=1
                boxes[r//3][c//3][item]=1
                
        return True


#time: O(C)
#space: O(C)
# time and space is constants since increase in the size of input will not increase time or space usage.

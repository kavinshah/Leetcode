class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        rowL=len(matrix)
        colL=len(matrix[0])
        low=0
        high=rowL*colL-1
        row=-1
        col=-1
        while(low<=high):
            mid=(low+high)//2
            row=mid//colL
            col=mid%colL
            if matrix[row][col]==target:
                return True
            if matrix[row][col]>target:
                high=mid-1
            else:
                low=mid+1
                
        return False
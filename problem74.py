class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        #first find the row
        low=0
        high=len(matrix)-1
        mid=-1
        row=-1
        while(low<=high):
            mid=(low+high)//2
            if matrix[mid][0] <= target <= matrix[mid][-1]:
                break
            if matrix[mid][0]>target:
                high=mid-1
            else:
                low=mid+1
                
        row=mid
        
        #find the col
        low=0
        high=len(matrix[0])-1
        while(low<=high):
            mid=(low+high)//2
            if matrix[row][mid]==target:
                return True
            if matrix[row][mid]>target:
                high=mid-1
            else:
                low=mid+1
                
        return False
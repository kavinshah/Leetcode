"""

                                [0,10,3,2,1,6,5,4]
                                /               \
                                
1   2   3
3   2   1


[1,1,1,2,2,3]
2
[1]
1
[1,2]
2
[1,1,1,1,2,2,2,3,5,5,5,5]
2

"""

class Element:
    def __init__(self, item, frequency):
        self.val=item
        self.count = frequency
        
    def __str__(self):
        return 'Value:' + self.val + 'Count:' + self.count
    
    def __repr__(self):
        return '\nValue:' + str(self.val) + ', Count:' + str(self.count)

class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        def partition(left, right, pivot):
            nonlocal elements
            j=left
            elements[right], elements[pivot]=elements[pivot], elements[right]
            for i in range(left, right):
                if elements[i].count<elements[right].count:
                    elements[j], elements[i]=elements[i], elements[j]
                    j+=1
            elements[j], elements[right]=elements[right], elements[j]
            return j
        
        def quickselect(low, high):
            nonlocal ksmallest, elements
            if high==low:
                return high
            print(low, high)
            pivot=partition(low, high, random.randint(low, high))
            if pivot==(ksmallest-1):
                return pivot
            if pivot>(ksmallest-1):
                return quickselect(low, pivot-1)
            else:
                return quickselect(pivot+1, high)
            
        counter=defaultdict(int)
        for n in nums:
            counter[n]+=1
        
        elements = []
        for key in counter.keys():
            item = Element(key, counter[key])
            elements.append(item)
            
        ksmallest = len(elements)-k
        
        if len(counter.keys())==1 or ksmallest==0:
            return counter.keys()
        
        index=quickselect(0, len(elements)-1)
        result=[]
        for e in elements[index+1:]:
            result.append(e.val)
            
        return result
        
# Time: O(N), Space: O(N)
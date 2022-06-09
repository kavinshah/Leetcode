"""

[1,0] -> 0 before 1

0->1
1->2
2->3
3->0

0->1->2->3
-
|     -
|    /
|   /
|  /
| /
4


                         4<---- 0 ----> 1
                                ^       |
                                |       |
                                |       |
                                |       |
                                |       v
                                3<----- 2

0->1
1->0

"""
class Solution:
    def canFinish(self, numCourses: int, prerequisites: List[List[int]]) -> bool:
        def isCyclic(node):
            nonlocal currentpath, checked, courses
            
            if checked[node]:
                return False
            
            if currentpath[node]:
                return True
            
            currentpath[node]=True
            
            for neighbor in courses[node]:
                if isCyclic(neighbor):
                    return True
                
            currentpath[node]=False
            checked[node]=True
            return False
            
        courses = defaultdict(set)
        currentpath = [False]*numCourses
        checked = [False]*numCourses
        for i in range(numCourses):
            courses[i]
            
        for p in prerequisites:
            courses[p[1]].add(p[0])
        
        #print(courses, courses.keys())
        
        for c in courses.keys():
            if isCyclic(c):
                return False
                
        return True   
        
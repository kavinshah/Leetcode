class BrowserHistory:

    def __init__(self, homepage: str):
        #print("initialize:", homepage)
        self.history=[homepage]
        self.pointer = 0 # revisit this to validate

    def visit(self, url: str) -> None:
        #print("visit:", url)
        self.pointer+=1
        
        if self.pointer==len(self.history):
            self.history.append(url)
            return
        else:
            self.history[self.pointer]=url
            self.history=self.history[:self.pointer+1]
            return

    def back(self, steps: int) -> str:
        #print("back:", steps)
        self.pointer = max(0, self.pointer-steps)
        #print("back:", self.history[self.pointer])
        return self.history[self.pointer]

    def forward(self, steps: int) -> str:
        #print("forward:", steps)
        self.pointer = min(len(self.history)-1, self.pointer+steps)
        #print("forward:", self.history[self.pointer])
        return self.history[self.pointer]

# Your BrowserHistory object will be instantiated and called as such:
# obj = BrowserHistory(homepage)
# obj.visit(url)
# param_2 = obj.back(steps)
# param_3 = obj.forward(steps)

"""

history = []
pointer = -1


back: pointer-backindex
return min(0,pointer-backindex)
forward: pointer+forward
return min(len(history)-1,pointer-backindex)

visit: linkedin.in
history = [leetcode.com, google.com, facebook.com, youtube.com]
pointer = 2

pointer = 3
history = [leetcode.com, google.com, facebook.com, linkedin.in]
history = [leetcode.com, google.com, facebook.com, linkedin.in]

pointer = 3
visit=linkedin.in
history = [leetcode.com, google.com, facebook.com, youtube.com]

pointer=4
history = [leetcode.com, google.com, facebook.com, youtube.com]
pointer=0

pointer=0
history = [leetcode.com, google.com, facebook.com, youtube.com]

pointer=1
maxlength=1
history = [leetcode.com, newwebsite.com, facebook.com, youtube.com]




"""
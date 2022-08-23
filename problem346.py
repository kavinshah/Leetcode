from collections import deque
class MovingAverage:
    def __init__(self, size):
      self.data=deque()
      self.currsum=0
      self.maxsize=size

    def next(self, val):
      if len(self.data)==self.maxsize:
        #remove the first element and add the last element
        self.currsum=self.currsum-self.data.popleft()
      #calculate the moving average
      self.data.append(val)
      self.currsum=self.currsum+val
      return self.currsum/len(self.data)
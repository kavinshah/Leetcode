/*

if when actualSize<size
    add to list and sum
    return sum/actualsize
else:
    remove at front and store val, add neeval at tail
    subtract front val from sum and add newval.
    return sum/size

https://replit.com/@vokoshyv/CompetentMoralBudgetrange#index.js

*/

public class MovingAverage {

    private long _totalSum=0;
    private int _size=0;
    private List<int> _data;
    
    public MovingAverage(int size) {
        this._size = size;
        this._data = new List<int>();
    }
    
    public double Next(int val) {
        _totalSum += val;
        _data.Add(val);
        if(_data.Count>_size){
            _totalSum-= _data[0];
            _data.RemoveAt(0);
        }
        return (double)_totalSum/_data.Count;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */
 
//time: O(1)
//Space: O(N)
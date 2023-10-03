public class Solution {
    IList<string> result = new List<string>();
    string input;
    public IList<string> LetterCasePermutation(string s) {
        input=s;
        FindPermutations(new StringBuilder(), 0);
        return result;
    }
    
    public void FindPermutations(StringBuilder str, int position){
        if(input.Length == position)
        {
            result.Add(String.Copy(str.ToString()));
            return;
        }
        
        if(Char.IsLetter(input.ElementAt(position)))
        {
            str.Append(Char.ToUpper(input.ElementAt(position)));
            FindPermutations(str, position+1);
            str.Remove(str.Length-1,1);
            str.Append(Char.ToLower(input.ElementAt(position)));
            FindPermutations(str, position+1);
        }
        else
        {
            str.Append(input.ElementAt(position));
            FindPermutations(str, position+1);
        }
        str.Remove(str.Length-1,1);
        return;
    }
}

//time: O(N)
//space: O(N)

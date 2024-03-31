public class Trie {
    bool isWord;
    Dictionary<char, Trie> words;
    public Trie() {
        isWord = false;
        words = new Dictionary<char, Trie>();
    }
    
    public void Insert(string word) {
        
        Trie current = this;
        char prev;
        foreach(char c in word)
        {
            if(!current.words.ContainsKey(c))
                current.words[c] = new Trie();
            current = current.words[c];
            prev = c;
        }
        current.isWord = true;
    }
    
    public bool Search(string word) {
        Trie current = this;
        foreach(char c in word)
        {
            if(!current.words.ContainsKey(c))
                return false;
            current = current.words[c];
        }
        return current.isWord;
    }
    
    public bool StartsWith(string prefix) {
        Trie current = this;
        foreach(char c in prefix)
        {
            if(!current.words.ContainsKey(c))
                return false;
            current = current.words[c];
        }
        return true;
    }
}

/*
insert:
	time: O(N)
	space: O(1)
search:
	time: O(N)
	space: O(1)
startsWith:
	time: O(N)
	space: O(1)
	
*/
/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
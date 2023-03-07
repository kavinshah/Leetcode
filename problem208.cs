/*

apple

i=0, current=a
i=1, current=[a[p]]
i=2, current=[a[p[p]]]
...
i=4, current=[a[p[p[l[e]]]]]

*/


public class Trie {
    Node root;
    public Trie() {
        root = new Node();
    }
    
    public void Insert(string word) {
        Node current=root;
        for(int i=0; i<word.Length; i++){
            if(!current.map.ContainsKey(word[i]))
                current.map[word[i]] = new Node();
            current=current.map[word[i]];
        }
        current.isWord=true;
    }
    
    public bool Search(string word) {
        Node current = root;
        return current.Search(word);
    }
    
    public bool StartsWith(string prefix) {
        Node node = root.StartsWith(prefix);
        if(node==null)
            return false;
        return true;
    }
}

public class Node{
    public Dictionary<char, Node> map;
    public bool isWord=false;
    public Node(){
        map = new Dictionary<char, Node>();
    }
    
    public void Print(string prefix){
        if(isWord){
            Console.WriteLine(prefix);
        }
        foreach(KeyValuePair<char, Node> kvp in map){
            map[kvp.Key].Print(prefix+kvp.Key);
        }
    }
    
    public bool Search(string word){
        Node node = StartsWith(word);
        if(node==null)
            return false;
        return node.isWord;
    }
    
    public Node StartsWith(string prefix){
        if(prefix.Length==0)
            return this;
        
        if(!map.ContainsKey(prefix[0])){
            return null;
        }
        
        return map[prefix[0]].StartsWith(prefix.Substring(1));
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
 
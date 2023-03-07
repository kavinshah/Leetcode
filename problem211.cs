public class WordDictionary {
    Node root;
    public WordDictionary() {
        root = new Node();
    }
    
    public void AddWord(string word) {
        Node current = root;
        for(int i=0; i<word.Length; i++){
            if(!current.map.ContainsKey(word[i]))
                current.map[word[i]]=new Node();
            current=current.map[word[i]];
        }
        current.isWord=true;
        return;
    }
    
    public bool Search(string word) {
        return root.Search(word);
    }
}

public class Node{
    public Dictionary<char, Node> map;
    public bool isWord=false;
    public Node(){
        map = new Dictionary<char, Node>();
    }
    
    public bool Search(string word){
        if(word.Length==0)
            return isWord;
        
        if(word[0]=='.'){
            foreach(var kv in map){
                if(map[kv.Key].Search(word.Substring(1)))
                   return true;
            }
            return false;
        }
        
        if(!map.ContainsKey(word[0]))
            return false;
        return map[word[0]].Search(word.Substring(1));
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
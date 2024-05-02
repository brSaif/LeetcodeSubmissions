public class WordDictionary {

    private readonly WordNode root = new WordNode();

    public void AddWord(string word) {
        word.Aggregate(root, (node, letter) => node.Next[letter - 'a'] ??= new WordNode())
            .IsWord = true;
    }

    public bool Search(string word) => Search(word, 0, root);

    private bool Search(string word, int index, WordNode node) {
        if (word.Length == index)
            return node.IsWord;

        return word[index] == '.'
            ? node.Next.Where(n => n != null).Any(n => Search(word, index + 1, n))
            : node.Next[word[index] - 'a'] != null
                && Search(word, index + 1, node.Next[word[index] - 'a']);
    }

    private class WordNode {
        public WordNode[] Next { get; } = new WordNode[26];
        public bool IsWord { get; set; }
    }

}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
import java.util.HashMap;
import java.util.Map;

class Trie {

  // Root node of the Trie.
  private final TrieNode root = new TrieNode(null);

  /**
   * Returns true of the complete word is present
   * in the Trie.
   *
   * @param word Word to search for.
   * @return True if the word is found, false otherwise.
   */
  public Boolean search(String word) {
    TrieNode node = root;
    for(int i = 0; i < word.length(); i++) {
      char c = word.charAt(i);
      if (node.children.containsKey(c)) {
        node = node.children.get(c);
      }
      else {
        return false;
      }
    }
    
    return node.isWordBoundary;
  }

  /*
   * **************************************************************
   * NOTE: Do not modify any code below this line, but use it.
   * as reference to see how TrieNode and insert() are implemented.
   */

  /**
   * Inserts the complete word into the Trie, marking the
   * bottom leaf node as a word boundary.
   *
   * @param word Word to insert.
   */
  public void insert(String word) {
    // Initialize an iterator node and set it to the root.
    TrieNode node = root;
    // Iterate over all the characters in the input word.
    for (int i = 0; i < word.length(); i++) {
      char c = word.charAt(i);
      // If the iterator _node_ has a child node with the associated
      // character, set _node_ to it, or if absent, set _node_ to a new
      // TrieNode and add it to its _children_ and advance.
      if (node.children.containsKey(c)) {
        node = node.children.get(c);
      } else {
        node.children.put(c, new TrieNode(c));
        node = node.children.get(c);
      }
      // If we're at the last character of the word, we'll mark the
      // current node to be a word boundary.
      if (i == word.length() - 1) {
        node.isWordBoundary = true;
      }
    }
  }
}

/**
 * Node of a Trie. Do not modify.
 */
class TrieNode {
  Character c; // The character associated with this node
  Boolean isWordBoundary = false; // If this node represents a word boundary.
  Map<Character, TrieNode> children = new HashMap<>(); // Child nodes.

  // Constructor
  public TrieNode(Character c) {
    this.c = c;
  }
}

/**
 * Solution class required for testing. Do not modify.
 */
public class Solution {

  private final Trie trie;

  Solution() {
    this.trie = new Trie();
    trie.insert("FIRE");
    trie.insert("FIRECODE");
    trie.insert("FIRESIDE");
  }

  public Boolean search(String word) {
    return this.trie.search(word);
  }
}
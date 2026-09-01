/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    private Node cloneUtil(Node node, Dictionary<Node,Node> map){
        Node newNode = new Node(node.val);
        map.Add(node,newNode);

        foreach(Node neighbor in node.neighbors){
            if(!map.ContainsKey(neighbor)) newNode.neighbors.Add(cloneUtil(neighbor,map));
            else newNode.neighbors.Add(map[neighbor]);
        }
        return newNode;
    }

    public Node CloneGraph(Node node) {
        if(node == null) return null;
        Dictionary<Node,Node> map = new Dictionary<Node,Node>();
        return cloneUtil(node,map);
    }
}

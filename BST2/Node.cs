using System;

namespace DataStructure.BST2;

public class Node 
{
    public Node(int key, Node left=null, Node right=null) 
    {
        this.key = key;
        this.left = left;
        this.right = right;
    }

    public int key { get; set; }
    public Node left { get; set; }
    public Node right { get; set; }
}

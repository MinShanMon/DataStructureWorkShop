using System;
using System.Collections.Generic;

namespace DataStructure.BST2; 

public class BST 
{
    private Node root;

    public const int prefix = 1;
    public const int infix = 2;
    public const int postfix = 3;

    public BST() 
    {
        root = null;
    }

    public Node Find(int key) 
    {
        return _Find(key, root);
    }

    private Node _Find(int key, Node node)
    {
        if (node == null) {
            // not found
            return null;
        }

        if (key == node.key) {
            // found
            return node;
        }

        if (key < node.key) {
            // go to left branch
            return _Find(key, node.left);
        }

        // go to right branch
        return _Find(key, node.right);
    }

    public bool Insert(Node node)
    {
        if (node == null) {
            // cannot insert null
            return false;
        }

        if (root == null) {
            // tree has no nodes yet, set this one as root
            root = node;
            return true;
        }

        return _Insert(node, root);
    }

    private bool _Insert(Node node, Node curr) 
    {
         if (node.key == curr.key) {
            return false;   // no duplicate keys allowed
        }

        if (node.key < curr.key) {                
            if (curr.left == null) {
                // found empty spot for new node
                curr.left = node;
                return true;
            }

            // go to left branch
            return _Insert(node, curr.left);
        }
        else {  
            if (curr.right == null) {
                // found empty spot for new node
                curr.right = node;
                return true;
            }                

            // go to right branch
            return _Insert(node, curr.right);
        }
    }

    public void DepthFirst(int mode) 
    {
        if (mode == prefix) {
            Prefix(root);
        }
        else if (mode == infix) {
            Infix(root);
        }
        else if (mode == postfix) {
            Postfix(root);
        }

        // clear trailing "%" character
        Console.WriteLine("");
    }

    private void Prefix(Node node) 
    {
        if (node == null) {
            return;
        }

        Console.Write("{0} ", node.key);
        Prefix(node.left);
        Prefix(node.right);
    }

    private void Infix(Node node) 
    {
        if (node == null) {
            return;
        }

        Infix(node.left);
        Console.Write("{0} ", node.key);
        Infix(node.right);
    }

    private void Postfix(Node node) 
    {
        if (node == null) {
            return;
        }

        Postfix(node.left);
        Postfix(node.right);
        Console.Write("{0} ", node.key);
    }

    public void BreadthFirst() 
    {
        List<Node> nodes = new List<Node>();

        if (root != null) {
            nodes.Add(root);
        }

        while (nodes.Count > 0) {
            Node node = nodes[0];
            Console.Write("{0} ", node.key);

            if (node.left != null) {
                nodes.Add(node.left);
            }
            if (node.right != null) {
                nodes.Add(node.right);
            }

            nodes.RemoveAt(0);
        }

        // clear trailing "%" character
        Console.WriteLine("");
    }
}























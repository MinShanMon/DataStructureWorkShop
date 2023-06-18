using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructure.BSTB
{
    class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

class BinaryTree
{
    private Node root;

    public BinaryTree()
    {
        root = null;
    }

    public void Insert(int data)
    {
        root = InsertRecursive(root, data);
    }

    private Node InsertRecursive(Node current, int data)
    {
        if (current == null)
        {
            return new Node(data);
        }

        if (data < current.Data)
        {
            current.Left = InsertRecursive(current.Left, data);
        }
        else if (data > current.Data)
        {
            current.Right = InsertRecursive(current.Right, data);
        }

        return current;
    }

    public void PrintBFS()
    {
        if (root == null)
        {
            Console.WriteLine("Binary search tree is empty.");
            return;
        }

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            Console.Write(current.Data + " ");

            if (current.Left != null)
            {
                queue.Enqueue(current.Left);
            }

            if (current.Right != null)
            {
                queue.Enqueue(current.Right);
            }
        }

        Console.WriteLine();
    }
}
}
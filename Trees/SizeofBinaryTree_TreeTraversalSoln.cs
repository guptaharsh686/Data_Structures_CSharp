using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
        
        Node root = new Node(10);
        root.left = new Node(20);
        root.left.left = new Node(30);
        root.right = new Node(40);
        root.right.left = new Node(50);
        root.right.right = new Node(60);
        
        Console.WriteLine("\n------------------- Size using Inorder Traversal---------------------\n");
        Console.WriteLine("Size of Binary Tree = " + printInorder(root));
    }
    
    public static int printInorder(Node root){
        if(root != null){
            return 1 + printInorder(root.left) +  printInorder(root.right);
        }
        else{
            return 0;
        }
        
    }
}

public class Node{
    public int key;
    public Node left,right;
    public Node(int x){
        key = x;
        left = right = null;
    }
}

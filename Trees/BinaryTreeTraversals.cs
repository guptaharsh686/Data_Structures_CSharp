// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Binary Tree traversal");
        
        Node root = new Node(10);
        root.left = new Node(20);
        root.left.left = new Node(30);
        root.right = new Node(40);
        root.right.left = new Node(50);
        root.right.right = new Node(60);
        
        Console.WriteLine("\n-------------------Inorder Traversal---------------------\n");
        printInorder(root);
        
        Console.WriteLine("\n-------------------Preorder Traversal---------------------\n");
        printPreorder(root);
        
        Console.WriteLine("\n-------------------Postorder Traversal--------------------\n");
        printPostorder(root);
    }
    
    public static void printInorder(Node root){
        if(root != null){
            printInorder(root.left);
            Console.Write(root.key + " ");
            printInorder(root.right);
        }
    }
    
    public static void printPreorder(Node root){
        if(root != null){
            Console.Write(root.key + " ");
            printInorder(root.left);
            printInorder(root.right);
        }
    }
    
    public static void printPostorder(Node root){
        if(root != null){
            printInorder(root.left);
            printInorder(root.right);
            Console.Write(root.key + " ");
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

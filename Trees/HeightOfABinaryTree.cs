// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
        
        Node root = new Node(10);
        root.left = new Node(20);
        root.left.left = new Node(30);
        root.right = new Node(400);
        root.right.left = new Node(50);
        root.right.right = new Node(60);
        
        Console.WriteLine("\n------------------- Size using Inorder Traversal---------------------\n");
        Console.WriteLine("MAximum node of Binary Tree = " + getHeight(root));
    }
    
    public static int getHeight(Node root){
        if(root != null){
            var height_left_subtree = getHeight(root.left);
            var height_right_subtree = getHeight(root.right);
            var maximum_height = height_left_subtree > height_right_subtree ? height_left_subtree : height_right_subtree;
            return 1 + maximum_height;
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

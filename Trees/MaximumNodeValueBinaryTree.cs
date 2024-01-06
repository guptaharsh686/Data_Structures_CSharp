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
        Console.WriteLine("MAximum node of Binary Tree = " + getMaxNode(root));
    }
    
    public static int getMaxNode(Node root){
        if(root != null){
            var max_left = getMaxNode(root.left);
            var max_right = getMaxNode(root.right);
            var maximum = max_left > max_right ? max_left : max_right;
            return root.key > maximum ? root.key : maximum;
        }
        else{
            return -1;
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

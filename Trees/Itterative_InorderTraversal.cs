// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;
using System.Collections.Generic;

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
        
        Console.WriteLine("\n------------------- Itterative Inorder Traversal---------------------\n");
        ItterativeInorder(root);
    }
    
    public static void ItterativeInorder(Node root){
        
        Stack<Node> st = new Stack<Node>();
        Node curr = root;
        
        while(curr != null || st.Count != 0){
            
            //move to leftmost node of subtree
            while(curr != null){
                st.Push(curr);
                curr = curr.left;
            }
            
            //use stack to backtrace element and move to right subtree
            curr = st.Pop();
            Console.Write(curr.key + " ");
            curr = curr.right;
            
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

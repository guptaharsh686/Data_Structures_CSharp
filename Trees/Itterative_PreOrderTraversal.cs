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
        
        Console.WriteLine("\n------------------- Itterative PreOrder Traversal---------------------\n");
        ItterativePreorder(root);
    }
    
    public static void ItterativePreorder(Node root){
        
        if(root == null) return;
        Stack<Node> st = new Stack<Node>();
        st.Push(root);
        
        while(st.Count > 0)
        {
            Node curr = st.Pop();
            
            Console.Write(curr.key + " ");
            
            //Order of pushing into stack is important. first right then left so we get leftmost first
            if(curr.right != null)
            {
                st.Push(curr.right);
            }
            
            if(curr.left != null)
            {
                st.Push(curr.left);
            }
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

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
        
        Node root = new Node(15);
        root.left = new Node(5);
        root.left.left = new Node(3);
        root.right = new Node(20);
        root.right.left = new Node(18);
        root.right.left.left = new Node(16);
        root.right.right = new Node(80);
        
        Console.WriteLine("\n------------------- Search in Normal BST ---------------------\n");
        

        Console.WriteLine("\n------------------- Itterative Insert in Normal BST insert key = 2 ---------------------\n");
        Console.WriteLine("\n Inorder Traversal Tree Before.... \n");
        ItterativeInorder(root);
        root = Insert_BST_Itterative(root,2);
        Console.WriteLine("\n Inorder Traversal Tree After.... \n");
        ItterativeInorder(root);
        
        Console.WriteLine("\n------------------- Recursive Search in Normal BST insert Key = 77 ---------------------\n");
        Console.WriteLine("\n Inorder Traversal Tree Before.... \n");
        ItterativeInorder(root);
        root = Insert_BST_Recursive(root,77);
        Console.WriteLine("\n Inorder Traversal Tree After.... \n");
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
    
    public static Node Insert_BST_Itterative(Node root,int x)
    {
        Node temp = new Node(x);
        Node parent = null;
        Node curr = root;
        while(curr != null)
        {
            parent = curr;
            
            if(root.key > x){
                curr = curr.left;
            }
            else if(root.key < x)
            {
                curr = curr.right;
            }
            else{
                return root;   // key already present no change
            }
        }
        
        if(parent == null){
            return temp;
        }
        if(parent.key > x){
            parent.left = temp;
        }
        else{
            parent.right = temp;
        }
        return root;
    }
    
    public static Node Insert_BST_Recursive(Node root,int x)
    {
        if(root == null)
            return new Node(x);
            
        else if(root.key > x)
        {
            root.left =  Insert_BST_Recursive(root.left,x);
        }
        else
        {
            root.right =  Insert_BST_Recursive(root.right,x);
        }
        
        return root;
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

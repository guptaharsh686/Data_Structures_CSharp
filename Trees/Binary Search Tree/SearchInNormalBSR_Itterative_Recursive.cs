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
        
        Console.WriteLine("\n------------------- Itterative Search in Normal BST key = 16 ---------------------\n");
        Console.WriteLine(Search_BST_Itterative(root,16));
        
        Console.WriteLine("\n------------------- Recursive Search in Normal BST Key = 77 ---------------------\n");
        Console.WriteLine(Search_BST_Recursive(root,77));
    }
    
    public static bool Search_BST_Itterative(Node root,int x)
    {
        while(root != null)
        {
            if(root.key == x){
                return true;
            }
            
            else if(root.key > x){
                root = root.left;
            }
            else
            {
                root = root.right;
            }
        }
        return false;
    }
    
    public static bool Search_BST_Recursive(Node root,int x)
    {
        if(root == null)
            return false;
            
        else if(root.key > x)
        {
            return  Search_BST_Recursive(root.left,x);
        }
        else
        {
            return  Search_BST_Recursive(root.right,x);
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

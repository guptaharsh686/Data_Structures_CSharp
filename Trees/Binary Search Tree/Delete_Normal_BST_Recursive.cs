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
        
        Console.WriteLine("\n------------------- Recursive Delete in Normal BST insert Key =  ---------------------\n");
        Console.WriteLine("\n Inorder Traversal Tree Before.... \n");
        ItterativeInorder(root);
        root = Delete_BST_Recursive(root,20);
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
    
    public static Node Delete_BST_Recursive(Node root,int x)
    {
        if(root == null) return null;
        
        if(root.key > x){
            root.left = Delete_BST_Recursive(root.left,x);
        }
        else if(root.key < x){
            root.right = Delete_BST_Recursive(root.right,x);
        }
        else{
            if(root.left == null){
                return root.right;
            }
            else if(root.right == null){
                return root.left;
            }
            else{
                Node succ = getInorderSucc(root);
                root.key = succ.key;
                root.right = Delete_BST_Recursive(root.right,succ.key);
            }
        } 
        return root;
    }
    
    public static Node getInorderSucc(Node root){
        Node curr = root.right;
        while(curr != null && curr.left != null){
            curr = curr.left;
        }
        return curr;
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

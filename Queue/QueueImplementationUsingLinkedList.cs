using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
        
        var que = new Queue();
        
        que.enqueue(10);
        que.enqueue(20);
        que.printQueue();
        
        Console.WriteLine($"Size = {que.getSize()}");
        
        que.dequeue();
        que.printQueue();
        Console.WriteLine($"Size = {que.getSize()}");
        
        Console.WriteLine($"getFront = {que.getFront()}");
        Console.WriteLine($"getRear = {que.getRear()}");

        que.enqueue(30);
        que.enqueue(40);
        que.printQueue();
        
        que.dequeue();
        que.printQueue();
        Console.WriteLine($"Size = {que.getSize()}");
        Console.WriteLine($"isEmpty = {que.isEmpty()}");
        
    }
}


public class Node{
    public Node next;
    public int data;
    public Node(int x){
        data = x;
        next = null;
    }
}

public class Queue{
    Node front,rear;
    int size = 0;
    
    public Queue(){
        front = null;
        rear = null;
    }
    
    public void printQueue(){
        if(isEmpty()){
            Console.WriteLine("Queue is empty!!");
        }else{
            Node temp = front;
            while(temp != null){
                Console.Write($"{temp.data} ");
                temp = temp.next;
            }
            Console.WriteLine(" ");
        }
    }
    
    public bool isEmpty(){
        if(front == null){
            return true;
        }
        return false;
    }
    
    public void enqueue(int x){
        if(rear == null){
            front = new Node(x);
            rear = front;
            size++;
        }else{
            Node temp = new Node(x);
            rear.next = temp;
            rear = rear.next;
            size++;
        }
        
    }
    
    public void dequeue(){
        if(isEmpty()){
            Console.WriteLine("No data in queue!!");
        }
        else{
            front = front.next;
            size--;
        }
    
    }
    
    public int getSize(){
        return size;
    }
    
    public int getFront(){
        if(isEmpty()){
            Console.WriteLine("Queue is empty");
            return -1;
        }else{
            return front.data;
        }
    }
    
    public int getRear(){
        if(isEmpty()){
            Console.WriteLine("Queue is empty");
            return -1;
        }else{
            return rear.data;
        }
    }
    
    
}

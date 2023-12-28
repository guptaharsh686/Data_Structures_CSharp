using System;

internal class Program
{
    public static void Main(string[] args)
    {
        var que = new Queue(10);
        que.enqueue(10);
        que.printQueue();
        
        que.enqueue(20);
        que.printQueue();
        
        que.dequeue();
        que.printQueue();
        
        que.enqueue(30);
        que.printQueue();
        
        Console.WriteLine($"Front = {que.getFront()}");
        Console.WriteLine($"Rear = {que.getRear()}");
        Console.WriteLine($"isFull = {que.isFull()}");
        Console.WriteLine($"isEmpty = {que.isEmpty()}");
        Console.WriteLine($"getSize = {que.getSize()}");

        
    }
}

public class Queue
{
    private int size,capacity;
    private int[] arr;
    public Queue(int c){
        capacity = c;
        size = 0;
        arr = new int[capacity]; 
    }
    
    public void printQueue(){
        Console.WriteLine("\n");
        for(int i=0;i<size;i++){
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine("\n");
    }
    
    public void enqueue(int x){
        if(size == capacity){
            Console.WriteLine("Queue Full cannot insert!");
        }
        else{
            size++;
            arr[size-1] = x;
        }
    }
    
    public void dequeue(){
        if(size == 0){
            Console.WriteLine("Queue empty cannot dequeue!");
        }
        else{
            size--;
        }
    }
    
    public int getFront(){
        return arr[0];
    }
    
    public int getRear(){
        return arr[size-1];
    }
    
    public bool isFull(){
        return size == capacity;
    }
    
    public bool isEmpty(){
        return size == 0;
    }
    
    public int getSize(){
        return size;
    }
}

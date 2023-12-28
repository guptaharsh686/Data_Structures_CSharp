// used circular array with that got O(1) enqueue,dequeue

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
    private int size,capacity,front;
    private int[] arr;
    public Queue(int c){
        capacity = c;
        size = 0;
        front = 0;
        arr = new int[capacity]; 
    }
    
    public void printQueue(){
        Console.WriteLine("\n");
        for(int i=front,j=0;j<size;j++,i = (i+1)%capacity){
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine("\n");
    }
    
    public void enqueue(int x){
        if(size == capacity){
            Console.WriteLine("Queue Full cannot insert!");
        }
        else{
            var rear = (front + size - 1) % capacity;
            rear = (rear + 1) % capacity;
            arr[rear] = x;
            size++;
        }
    }
    
    public void dequeue(){
        if(size == 0){
            Console.WriteLine("Queue empty cannot dequeue!");
        }
        else{
            front = (front + 1) % capacity;
            size--;
        }
    }
    
    public int getFront(){
        return front;
    }
    
    public int getRear(){
        return (front + size - 1) % capacity;
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

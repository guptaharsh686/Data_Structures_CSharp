// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
        
        var minHeap = new MinHeap(10);
        minHeap.insert(10);
        minHeap.insert(20);
        minHeap.insert(15);
        minHeap.insert(40);
        minHeap.insert(50);
        minHeap.insert(100);
        minHeap.insert(25);
        minHeap.insert(45);
        Console.WriteLine("\n Current condition of heap \n");
        minHeap.print();
        Console.WriteLine("\n Inserting wrong voilating value at arr[0] = 200 \n");
        minHeap.arr[0] = 200;
        minHeap.print();
        Console.WriteLine("\n Calling MinHeapify for root index\n");
        minHeap.minHeapify(0);
        Console.WriteLine("\n Heap state after heapify\n");
        minHeap.print();
    }
}

public class MinHeap{
    public int[] arr;
    public int size,capacity;
    
    public MinHeap(int c){
        arr = new int[c];
        size = 0;
        capacity = c;
    }
    
    public int parent(int i){
        return (i-1)/2;
    }
    
    public int left(int i){
        return (2 * i) + 1 ;
    }
    
    public int right(int i){
        return (2 * i) + 2 ;
    }
    
    public void print(){
        for(int i=0;i<size;i++){
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine(" ");
    }
    
    public void insert(int x){
        if(size == capacity){
            Console.WriteLine("capacity is full cannot insert!");
            return;
        }
        size++;
        arr[size-1] = x;
        int i = size - 1;
        while(i != 0 && arr[parent(i)] > arr[i]){
            
            int temp = arr[parent(i)];
            arr[parent(i)] = arr[i];
            arr[i] = temp;
            
            i = parent(i);
        }
    }
    
    public void minHeapify(int i){
        int lt = left(i);
        int rt = right(i);
        int smallest = i;
        
        if(lt < size && arr[lt] < arr[i]){
            smallest = lt;
        }
        
        if(rt < size && arr[rt] < arr[smallest]){
            smallest = rt;
        }
        
        if(smallest != i){
            int temp = arr[i];
            arr[i] = arr[smallest];
            arr[smallest] = temp;
            
            minHeapify(smallest);
        }
    }
}

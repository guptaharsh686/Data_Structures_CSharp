internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Node head = new Node(10);
        head.next = new Node(20);
        head.next.next = new Node(30);
        head.next.next.next = new Node(40);
        head.next.next.next.next = new Node(50);
        head.next.next.next.next.next = head;


        //int data = 55;

        //Console.WriteLine($"\nBefore insert of value {data}");
        printLinkedList(head);


        //head = RemoveDuplicateFromSortedList(head);
        //Console.WriteLine($"\n");

        //printLinkedList(head);
        
    }

    private static void printLinkedList(Node head)
    {
        if(head == null)
        {
            return;
        }

        Console.Write($"{head.data} ");
        
        for(Node curr = head.next; curr != head; curr = curr.next)
        {
            Console.Write(curr.data + " ");
        }
    }
}



    public class Node
    {
        public int data;
        public Node? next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }




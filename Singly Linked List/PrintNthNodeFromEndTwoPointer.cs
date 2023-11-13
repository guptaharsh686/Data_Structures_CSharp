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

        //int data = 55;

        //Console.WriteLine($"\nBefore insert of value {data}");
        printLinkedList(head);


        var value = getNthNodeFromEndOfLinkedList(head,5);
        Console.WriteLine($"\n{value}");

        //printLinkedList(head);
        
    }

    private static int? getNthNodeFromEndOfLinkedList(Node head,int n)
    {
        if(head == null)
            return null;
        Node first = head;
        Node second = head;

        for(int i=1; i <= n; i++)
        {
            if (first == null)
                return null;
            first = first.next;
        }
        


        while (first != null)
        {
            second = second.next;
            first = first.next;
        }

        return second.data;



    }

    private static void printLinkedList(Node head)
    {
        Node curr = head;
        while (curr != null)
        {
            Console.Write(curr.data + " ");
            curr = curr.next;
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




internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Node head = new Node(10);
        head.next = new Node(20);
        head.next.next = new Node(30);
        head.next.next.next = new Node(40);

        //int data = 55;

        //Console.WriteLine($"\nBefore insert of value {data}");
        printLinkedList(head);


        var value = getNthNodeFromEndOfLinkedList(head,5);
        Console.WriteLine($"\n{value}");

        //printLinkedList(head);
        
    }

    private static int? getNthNodeFromEndOfLinkedList(Node head,int n)
    {
        int count = 0;
        Node curr = head;
        for(int i=0; curr != null; i++)
        {
            count++;
            curr = curr.next;
        }

        if(count < n)
        {
            return null;
        }

        curr = head;
        for(int i=0; i < count - n; i++)
        {
            curr = curr.next;
        }

        return curr.data;

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




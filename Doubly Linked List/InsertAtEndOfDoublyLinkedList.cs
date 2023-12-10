internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Node head = new Node(10);
        //head.next = head;
        head.next = new Node(20);
        head.next.prev = head;
        //head.next.next = new Node(30);
        //head.next.next.next = new Node(40);
        //head.next.next.next.next = new Node(50);
        //head.next.next.next.next.next = head;


        //int data = 55;

        //Console.WriteLine($"\nBefore insert of value {data}");
        printLinkedList(head);


        head = InsertAtEndOfDoublyLinkedList(head,5);
        Console.WriteLine($"\n");

        printLinkedList(head);
        
    }

    private static Node InsertAtEndOfDoublyLinkedList(Node head,int data)
    {
        Node temp = new Node(data);

        if(head == null)
        {
            return temp;
        }

        Node curr = head;
        while(curr.next != null) 
        {
            curr = curr.next;
        }

        curr.next = temp;
        temp.prev = curr;

        return head;
    }

    private static void printLinkedList(Node head)
    {
        if(head == null)
        {
            return;
        }
        Node curr = head;
        do
        {
            Console.Write($"{curr.data} ");
            curr = curr.next;
        } while (curr != null);
    }
}



    public class Node
    {
        public int data;
        public Node? next;
        public Node? prev;
        public Node(int data)
        {
            this.data = data;
            next = null;
            prev = null;
        }
    }




internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Node head = new Node(10);
        //head.next = head;
        head.next = new Node(20);
        head.next.prev = head;
        head.next.next = new Node(30);
        head.next.next.prev = head.next;
        //head.next.next.next = new Node(40);
        //head.next.next.next.next = new Node(50);
        //head.next.next.next.next.next = head;


        //int data = 55;

        //Console.WriteLine($"\nBefore insert of value {data}");
        printLinkedList(head);


        head = ReverseADoublyLinkedList(head);
        Console.WriteLine($"\n");

        printLinkedList(head);
        
    }

    private static Node ReverseADoublyLinkedList(Node head)
    {
        if(head == null || head.next == null)
        {
            return head;
        }

        Node curr = head;
        while (curr.next != null)
        {
            Node curr_next = curr.next;
            Node curr_prev = curr.prev;

            curr.next = curr_prev;
            curr.prev = curr_next;

            curr = curr_next;
        }

        Node next = curr.next;
        Node prev = curr.prev;

        curr.next = prev;
        curr.prev = next;

        return curr;
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




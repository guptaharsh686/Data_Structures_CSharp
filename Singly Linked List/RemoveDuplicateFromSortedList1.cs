internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Node head = new Node(10);
        //head.next = new Node(20);
        //head.next.next = new Node(20);

        head.next = new Node(20);
        head.next.next = new Node(20);
        head.next.next.next = new Node(30);
        head.next.next.next.next = new Node(30);
        head.next.next.next.next.next = new Node(30);
        head.next.next.next.next.next.next = new Node(40);
        head.next.next.next.next.next.next.next = new Node(50);
        head.next.next.next.next.next.next.next.next = new Node(50);


        //int data = 55;

        //Console.WriteLine($"\nBefore insert of value {data}");
        printLinkedList(head);


        head = RemoveDuplicateFromSortedList(head);
        Console.WriteLine($"\n");

        printLinkedList(head);
        
    }

    private static Node RemoveDuplicateFromSortedList(Node head)
    {
        Node curr = head;
        Node next = head.next;

        if(head == null || head.next == null)
        {
            return head;
        }

        while (next != null)
        {
            if(curr.data == next.data)
            {
                while(next.next != null && curr.data == next.data)
                {
                    next = next.next;
                }
                if(next.next == null)
                {
                    curr.next = null;
                    next = null;
                }    
                else
                    curr.next = next;
            }
            else
            {
                curr = curr.next;
                next = curr.next;
            }
        }

        return head;
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




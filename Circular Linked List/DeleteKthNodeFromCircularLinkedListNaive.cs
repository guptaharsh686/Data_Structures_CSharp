internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Node head = new Node(10);
        //head.next = head;
        head.next = new Node(20);
        head.next.next = new Node(30);
        head.next.next.next = new Node(40);
        head.next.next.next.next = new Node(50);
        head.next.next.next.next.next = head;


        //int data = 55;

        //Console.WriteLine($"\nBefore insert of value {data}");
        printLinkedList(head);


        head = DeleteKthNodeFromCircularLinkedList(head,1);
        Console.WriteLine($"\n");

        printLinkedList(head);
        
    }

    private static Node? DeleteKthNodeFromCircularLinkedList(Node head, int k)
    {
        if(head == null || head.next == head)
        {
            if(k <= 1)
            {
                return null;
            }
            return head;
        }
        
        Node curr = head;
        while(curr.next != head)
        {
            k--;
            if(k == 0)
            {
                curr.data = curr.next.data;
                curr.next = curr.next.next;
            }
            curr = curr.next;
        }
        if(k == 1 && curr.next == head)
        {
            curr.data = curr.next.data;
            curr.next = curr.next.next;
            return curr;
        }

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
        } while (curr != head);
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




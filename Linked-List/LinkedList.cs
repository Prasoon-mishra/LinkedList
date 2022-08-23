namespace Linked_List
{
    public class Node //    CREATING THE NODE
    {
        public int element;
        public Node next;

        public Node(int a, Node n) // INITIALIZING THE VARIABLES USING COSTRUCTOR
        {
            this.element = a;
            this.next = n;
        }
    }
    internal class LinkedList
    {
        public Node head;
        public Node tail;
        public int size;

        public LinkedList()
        {
            head = null;
            tail = null;
            size= 0;    
        }

        public int Length()  //CALCULATING THE LENGTH OF LINKED LIST
        {
            return size;
        }

        public bool isEmpty() // TO CHECK WHETHER THE LIST IS EMPTY OR NOT
        {
            return size == 0;
        }

        public void addLast(int e) // ADDING THE NODES FROM THE LAST 
        {
            Node newest = new Node(e,null);
            if(isEmpty())
            {
                head = newest;
            }
            else
            {
                tail.next = newest;
            }
            tail = newest;
            size++;
        }

        public void display() 
        {
            Node p = head;
            while(p.next != null)
            {
                p = p.next;
                Console.Write(p.element+" --> ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------Linked List-------------------");
            LinkedList linkedList = new LinkedList();
            linkedList.addLast(7);
            linkedList.addLast(8);
            linkedList.addLast(9);
            linkedList.addLast(10);
            linkedList.addLast(11);
            linkedList.addLast(12);
            linkedList.addLast(13);
            linkedList.addLast(14);
            linkedList.display();
        }
    }
}
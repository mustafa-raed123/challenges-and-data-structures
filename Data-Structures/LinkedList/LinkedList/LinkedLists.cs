using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class LinkedLists
    {
        public node head;
        public node tail;
        public int count;
        public LinkedLists()
        {
            head = null;
            tail = null;
            count = 0;

        }
        public void InsertToHead(int data)
        {
            if (head == null)
            {
                head = new node();
                head.data = data;
                head.next = null;
                tail = head;
                count++;
            }
            else
            {
                node NewNode = new node();
                NewNode.data = data;
                NewNode.next = head;
                head = NewNode;
                count++;
            }
        }
        public void InsertToTail(int data)
        {
            if (tail == null)
                InsertToHead(data);
            else
            {
                node NewNode = new node();
                NewNode.data = data;
                tail.next = NewNode;
                tail = NewNode;
                count++;
            }
        }
        public void DeleteFromTail()
        {
            if (tail == null) return;


            node NewNode = head;
            while (NewNode.next != tail)
            {
                NewNode = NewNode.next;
            }
            tail = NewNode;
            NewNode.next = null;
            count--;
        }
        public bool Includes(int data)
        {
            if (head == null) return false;

            node node = head;
            while (node != null)
            {
                if (node.data == data) return true;
                node = node.next;
            }
            return false;
        }
        public void Remove(int data)
        {
            if (head == null) return;
            if (head.data == data)
                head = head.next;
            if (tail.data == data) DeleteFromTail();
            node node = head;
            while (node != null)
            {
                if (node.next == null) return;

                else if (node.next.data == data)

                    node.next = node.next.next;

                node = node.next;
            }
        }
        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("\t\tHead ----> null");
                return;
            }

            Console.Write("\t\tHead ----> ");
            node current = head;

            while (current != null)
            {

                Console.Write(current.data);

                if (current.next != null)
                    Console.Write(" --> ");

                current = current.next;
            }

            Console.WriteLine(" --> null");
        }

        public void RemoveDublicate()
        {
            if (head == null) return;
            node current = head;
            while (current.next != null)
            {
                if (current.data == current.next.data)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }

            }

        }
        public void MergeSortedLists(LinkedLists linkedlist)
        {
            count = 0;
            if (linkedlist == null && head == null) return;
            LinkedLists newlinkedList = new LinkedLists();
            sortLinkedList();
            linkedlist.sortLinkedList(); //method To sort a linkedlist from smallest to largest 
            node current1 = head;
            node current2 = linkedlist.head;
            while (current1 != null || current2 != null)
            {
                if (current1 != null && (current2 == null || current1.data <= current2.data))
                {
                    {
                        newlinkedList.InsertToTail(current1.data);
                        count++;
                        current1 = current1.next;
                    }
                }
                else if (current2 != null)
                {
                    newlinkedList.InsertToTail(current2.data);
                    count++;
                    current2 = current2.next;
                }
            }
            head = newlinkedList.head;
        }

        public void sortLinkedList()
        {
            List<int> list = new List<int>();
            if (head == null) return;
            while (head != null)
            {
                list.Add(head.data);
                head = head.next;
            }
            head = null;
            tail = null;
            foreach (var item in list.OrderBy(n => n).ToList())
            {
                InsertToTail(item);
            }


        }
        //public void RotateLeft(int K)
        //{
        //    if (head == null || K <= 0 || K > count)
        //        return;

        //    Node node1 = head;
        //    Node node2 = head;
        //    int i = 1;

        //    while (i <= K && node1 != null)
        //    {
        //        InsertToTail(node1.Data);
        //        node1 = node1.Next;
        //        i++;
        //    }
        //    head = node1;

        //}


        public void RotateLeft(int K)
        {
            if (head == null || head.next == null || K == 0)
                return;
            node current = head;

            while (current.next != null)
            {
                current = current.next;

            }
            K = K % count;
            if (K == 0)
                return;
            current.next = head;
            node newTail = head;
            for (int i = 1; i < count - K; i++)
            {
                newTail = newTail.next;
            }
            head = newTail.next;
            newTail.next = null;
        }

        public void RemoveDublicates()
        {
            if (head == null) return;
            HashSet<int> list = new HashSet<int>();
            node node = head;
            int i = 1;

            while (node != null)
            {

                if (list.Contains(node.data))
                {
                    Console.WriteLine(list.Count);
                    RemoveFromPos(i);
                }
                else
                {
                    Console.WriteLine(list.Count);
                    i++;
                    list.Add(node.data);
                }
                node = node.next;
            }
        }
        public void RemoveFromPos(int k)
        {
            var current = head;
            if (head == null || k < 1 || k > count) return;
            if (k == 1)
            {
                current = current.next.next;
                count--;
                return;

            }
            int c = 1;
            while (c < k - 1)
            {
                current = current.next;
                c++;
            }
            current.next = current.next.next;
            count--;
        }
        public void InserFromPos(int data, int pos)
        {
            if (pos > count + 1 || pos < 1 || (head == null && pos != 1)) return;
            if (head == null && pos == 1)
            {
                InsertToTail(data);

            }
            var current = head;
            int i = 1;
            while (i < pos - 1)
            {
                Console.WriteLine(current.data);
                current = current.next;
                i++;
            }
            node newNode = new node();
            newNode.data = data;
            newNode.next = current.next;
            current.next = newNode;
            count++;
        }
        public void repetitions()
        {
            if (head == null) return;
            var current = head;
            var i = count;
            var j = 1;
            while (j <= i)
            {
                node temp = new node();
                temp.data = current.data;
                temp.next = current.next;
                current.next = temp;
                count++;
                j++;
                current = current.next.next;
            }
        }
        public void repetition()
        {
            var current = head;
            var i = count;
            var j = 1;
            while (j <= i)
            {
                node temp = new node();
                temp.data = current.data;
                tail.next = temp;

                tail = temp;
                j++;
                current = current.next;
                count++;
            }


        }
        public void Add(int k)
        {
            if (head == null || k == 0) return;

            var current = head;
            int i = k % count;
            Console.WriteLine(i);
            int j = 1;
            while (j <= i)
            {
                node newNode = new node();
                newNode.data = current.data;
                tail.next = newNode;
                tail = newNode;
                count++;
                j++;
                current = current.next;
            }
        }
        public void DeleteFromPos(int pos)
        {
            if (head == null || pos == 0 || pos > count) return;
            var temp = head;
            var i = 1;

            while (i <= pos - 1)
            {
                temp = temp.next;
                i++;
            }
            temp.next = temp.next.next;
            count--;
        }
        public void PrintMiddleNode()
        {
            if (head == null) return;
            if (head.next == null)
            {
                Console.WriteLine(head.data);
                return;
            }
            int HalfCount = count / 2;

            node MiddleNode = head;
            int i = 1;
            while (i <= HalfCount)
            {
                MiddleNode = MiddleNode.next;
                i++;
            }
            Console.WriteLine(MiddleNode.data);

        }
        public void ReversLinkedList()
        {
            if (head == null || head.next == null)
            {
                return;
            }
            var current = head;
            node Prev = null;
            node Next = null;
            while (current != null)
            {
                Next = current.next;
                current.next = Prev;
                Prev = current;
                current = Next;
            }
            tail = head;
               // Console.WriteLine(tail.Data);
            head = Prev;
        }
        public void RotateLeftByK(int k)
        {
            if (head == null || head.next == null || k < 1) return;
            int count = 1;

            node Tail = head;
            while (Tail.next != null)
            {
                count++;
                Tail = Tail.next;

            }
            k = k % count;
            if (k == 0) return;
            int i = 1;
            node node = head;
            while (i < k)
            {
            InsertToTail(node.data);
            node = node.next;
                i++;
           }
            head = node;
        }
        public node Rotate( int k)
        { 
            if (k == 0 || head == null)
                return head;

            // Rotate the list by k nodes
            for (int i = 0; i < k; ++i)
            {
                node curr = head;
                while (curr.next != null)
                    curr = curr.next;

                // Move the first node to the last
                curr.next = head;
                curr = curr.next;
                head = head.next;
                curr.next = null;
            }
            return head;
        }
        //public void Rotate2(int k)
        //{
        //    if (head == null || head.Next == null || k < 1) return;
        //    Node current = head;
        //    int count = 1;
        //    while (current.Next != null)
        //    {
        //        current = current.Next;
        //        count++;
        //    }
        //    k = k % count;
        //    if (k == 0) return; 
        //    current.Next = head;
        //    for (int i = 0; i < k; i++)
        //    {
        //        current = current.Next;
        //    }
        //    head = current.Next;
        //    current.Next = null;
        //}
        //public void Rotate3(int k)
        //{
        //    if (head == null || head.Next == null || k < 1) return; // Base case check

        //    // Ensure k is within the bounds of the list length
        //    k = k % count;

        //    if (k == 0) return; // No rotation needed if k is 0 after modulo

        //    // Connect the tail to the head to make the list circular
        //    tail.Next = head;
        //    Console.WriteLine(tail.Data);
        //    // Traverse to the (count - k)th node
        //    Node current = tail; // Start at tail
        //    Console.WriteLine(current.Data);
        //    for (int i = 0; i < k; i++)
        //    {
        //      //  Console.WriteLine(current.Data);
        //        current = current.Next; // Move to the new tail position
        //    }

        //    // Update head and tail
        //    head = current.Next; // New head is the next node
        //    current.Next = null; // Break the circular link
        //    tail = current; // Update tail to the new tail
        //}
        //public  void FindFromEnd(int n)
        //{
        //    if (head == null || n < 1) return;
        //    int count = 1;
        //    node current = head;
        //    while (current.next != null)
        //    {
        //        current = current.next;
        //        count++;

        //    }
        //    int NodeTarget = count - n;

           
        //    if (n > count) return;
        //    node newNode = head;

        //    for (int i = 0; i < NodeTarget; i++)
        //    {
        //        newNode = newNode.next;
        //    }
        //    Console.WriteLine(newNode.data);
        //  }
        //public void DeleteLastOccurrence(int key)
        //{
        //    node last = null, lastPrev = null;
        //    node current = head, previous = null;
        //    while (current != null)
        //    {
        //        if (current.data == key)
        //        {
        //            lastPrev = previous; 
        //            last = current;      
        //        }
        //        previous = current;      
        //        current = current.next;  
        //    }
        //    if (last != null)
        //    {
        //        if (lastPrev != null)
        //        {
        //            lastPrev.next = last.next;
        //        }
        //        else
        //        {
        //            head = head.next; 
        //        }
        //    }
        //}
        //public void RemoveMiddleNode()
        //{
        //    if (head == null) return;
        //    if (head.next == null)
        //    {
        //        head = null;
        //        return;
        //    }
        //    var current = head;
        //    int count = 1;
        //    while (current != null)
        //    {
        //        count++;
        //        current = current.next;
        //    }
        //    int middleIndex = (count % 2 == 0) ? (count / 2) - 1 : (count / 2);
        //    node HalfNode = head;
        //    node prev = null;
        //    int i = 1;
        //    while (i <= middleIndex)
        //    {
        //        prev = HalfNode;
        //        HalfNode = HalfNode.next;
        //        i++;
        //    }
        //prev.next = HalfNode.next;
        //}
        //public bool IsPalindrome()
        //{
        //    if (head == null) return false;
        //    if (head.next == null) return true;

        //    // Find the length of the list
        //    int length = 0;
        //    node current = head;
        //    while (current != null)
        //    {
        //        length++;
        //        current = current.next;
        //    }

        //    current = head;

        //    // Iterate through the list
        //    for (int i = 0; i < length / 2; i++)
        //    {
        //        node last = current;
        //        node prev = null;

        //        // Find the last node in the list
        //        for (int j = i; j < length - i - 1; j++)
        //        {
        //            prev = last;
        //            last = last.next;
        //        }

        //        // Compare the values of the current node and the last node
        //        if (current.data != last.data)
        //        {
        //            return false; // Not a palindrome
        //        }

        //        // Move current pointer forward
        //        current = current.next;

        //        // Restore the list structure (no need for prev.next = null)
        //    }

        //    return true; // If all comparisons matched
        //}


    }

    }
    

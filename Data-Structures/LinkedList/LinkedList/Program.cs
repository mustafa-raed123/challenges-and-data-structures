﻿namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LinkedLists linkedList = new LinkedLists();
            //  linkedList.InsertToTail(1);
            //  linkedList.InsertToTail(2);
            //  linkedList.InsertToTail(3);
            //  linkedList.InsertToTail(34);
            //  linkedList.InsertToTail(6);                
            ////  linkedList.DeleteFromTail();           
            //  linkedList.PrintList();
            //  Console.WriteLine("\n\n\t\t\t\t\t After Remove 34");
            //  Console.WriteLine("\n");
            //  linkedList.Remove(34);
            //  linkedList.PrintList();
            //  Console.Write("\n\n\t\t\t\tCheck if the List Contains a 6");
            //  Console.WriteLine($"  ({linkedList.Includes(6)})");
            //  Console.Write("\n\n\t\t\t\tCheck if the List Contains a 34");
            //  Console.WriteLine($"  ({linkedList.Includes(34)})");
            //  Console.ReadKey();
            LinkedLists linkedList1 = new LinkedLists();
            linkedList1.InsertToTail(8);
            linkedList1.InsertToTail(3);
            linkedList1.InsertToTail(4);
            linkedList1.InsertToTail(4);
            linkedList1.InsertToTail(3);
            linkedList1.InsertToTail(8);
            Console.WriteLine(linkedList1.IsPalindrome());

            //linkedList1.InsertToTail(5);
            //linkedList1.InsertToTail(6);
            //linkedList1.InsertToTail(23);
            //linkedList1.InsertToTail(5);
            //linkedList1.InsertToTail(6);
            //linkedList1.InsertToTail(6);
            // linkedList1.InsertToPos(3, 9);
            //  linkedList1.RemoveDuplicate();
            // linkedList1.RemoveFromPos(6);
            //  linkedList1.DeleteEvenNumber();
            //linkedList1.repetition();
            // linkedList1.RepetitionEvenNumberInLastList();
            // linkedList1.Reverse();
            // linkedList1.PrintList();
            // linkedList1.PrintMiddleNode();
            //  linkedList1.ReversLinkedList();
            //  linkedList1.FindFromEnd(11);
            linkedList1.PrintList();

          //  linkedList1.DeleteLastOccurrence(4);
          linkedList1.RemoveMiddleNode();
            linkedList1.PrintList();
           // linkedList1.Rotate3(3);
         //   linkedList1.PrintList();
            //LinkedLists linkedList2 = new LinkedLists();
            //linkedList2.InsertToTail(2);
            //linkedList2.InsertToTail(10);
            //linkedList2.InsertToTail(7);
            //linkedList2.InsertToTail(5);
            //Console.WriteLine("\t\t\t\tLinkedList1 Before Sorted ");
            //Console.WriteLine();
            //linkedList1.PrintList();
            //Console.WriteLine();

            //Console.WriteLine("\t\t\t\tLinkedList1 After Sorted ");
            //Console.WriteLine();
            //linkedList1.sortLinkedList();
            //Console.WriteLine();
            //linkedList1.PrintList();
            //Console.WriteLine();
            //Console.WriteLine("\t\t\t\tLinkedList2 Before Sorted ");
            //Console.WriteLine();
            //Console.WriteLine();

            //linkedList2.PrintList();
            //Console.WriteLine();
            //Console.WriteLine("\t\t\t\tLinkedList2 After Sorted ");
            //Console.WriteLine();
            //linkedList2.sortLinkedList();
            //Console.WriteLine();    
            //linkedList2.PrintList();
            //Console.WriteLine();
            //Console.WriteLine("\t\t\t\tLinked List After Merge");
            //Console.WriteLine();
            //linkedList1.MergeSortedLists(linkedList2);
            //linkedList1.PrintList();
            //Console.WriteLine("\t\t\tLinkedList before Rotate");
            //Console.WriteLine();
            //linkedList1.PrintList();
            //Console.WriteLine();
            //Console.WriteLine("\t\t\tLinkedList After Rotate K = 3");
            //linkedList1.RotateLeft(3);
            //linkedList1.PrintList();

        }
    }
}

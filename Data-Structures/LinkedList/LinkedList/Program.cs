namespace LinkedList
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
            LinkedLists linkedList = new LinkedLists();
            linkedList.InsertToTail(1);
            linkedList.InsertToTail(2);
            linkedList.InsertToTail(2);
            linkedList.InsertToTail(3);
            linkedList.InsertToTail(3);
            linkedList.InsertToTail(3);
            linkedList.InsertToTail(34);
            linkedList.InsertToTail(6);
            linkedList.PrintList();
            Console.WriteLine("\t\t\t\tAfter Remove Duplicate");
            linkedList.RemoveDublicate();
            linkedList.PrintList();
        }
    }
}

namespace Common_Elements
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1,2,3,4,5,4 };
            int[] arr2 = { 4,5,6,7,4};

            int[] arr3 = { 4,6,7,8,9};
            List<int> list1 = CommonElements(arr1,arr2);
            List<int> list2 = CommonElements(arr2,arr3);
            PrintArray(arr1, arr2, list1);
            PrintArray(arr2, arr3, list2);

        }
       
        public static void PrintArray(int[] arr1 , int[] arr2, List<int> list)
        {
            Console.Write("Input ==> ");
            Console.WriteLine("[");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (i == arr1.Length - 1)
                {
                    Console.Write(arr1[i]);
                }
                else
                {
                    Console.Write($"{arr1[i]},");
                }
            }
            Console.Write("] , ");
            Console.Write("[");
            for (int i = 0; i < arr2.Length; i++)
            {
                if (i == arr2.Length - 1)
                {
                    Console.Write(arr2[i]);
                }
                else
                {
                    Console.Write($"{arr2[i]},");
                }
            }
            Console.WriteLine("]");

            Console.Write("Output ==>");
            Console.Write("[");
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    Console.Write(list[i]);
                }
                else
                {
                    Console.Write($"{list[i]},");
                }
            }
            Console.WriteLine("]");
            Console.WriteLine("==============================");
        }
      
        public static List<int> CommonElements(int[] arr1, int[] arr2)
      {
            List<int> list = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!dic.ContainsKey(arr1[i]))
                {
                    dic.Add(arr1[i], 1);
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                if (dic.ContainsKey(arr2[i]))
                {
                    dic[arr2[i]]+=1;
                }
            }
            int count = 0; 
            foreach (var item in dic)
                {
                     if(item.Value > 1)
                {
                    list.Add(item.Key) ;
                }
              
  }
            return list;

        }
    }
}

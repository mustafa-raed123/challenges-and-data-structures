namespace FindDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 1, 3, 3, 3, 2, 1, 4, 5, 6, 6 };
            int[] arr2 = {6 ,8,7,8,7,6,5,73, 3, 2, 2,3,4,3,2};
            int[] arr3 = { 1,10,4,3,4,5,7,7,7,71,23,2,4,1,2,3,2,1};
            List<int> arr4 = FindDuplicates(arr);
            List<int> arr5 = FindDuplicates(arr2);
            List<int> arr6 = FindDuplicates(arr3);
            PrintArray(arr,arr4);
            PrintArray(arr2,arr5);
            PrintArray(arr3,arr6);
        }
        public static void PrintArray(int[] array, List<int> arr)
        {
            Console.Write("Input ==>");

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write($"{array[i]},");
                }
            }
            Console.WriteLine("]");

            Console.Write("Output ==>");
            Console.Write("[");
            for (int i = 0; i < arr.Count; i++)
            {
                if (i == arr.Count - 1)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    Console.Write($"{arr[i]},");
                }
            }
            Console.WriteLine("]");
            Console.WriteLine("==============================");
        }


        public static List<int> FindDuplicates(int[] arr)
        {
            List<int> arr2 = new List<int>();
            Dictionary<int, int> dub = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dub.ContainsKey(arr[i]))
                {
                    dub[arr[i]] += 1;
                }
                else
                {
                    dub.Add(arr[i], 1);
                }
            }
            foreach (var item in dub)
            {
                if (item.Value > 1)
                {

                    arr2.Add(item.Key);
                }
            }
            return arr2;
        }
    }
}

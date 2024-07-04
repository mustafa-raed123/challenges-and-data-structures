namespace ReverseWords
{
    public class Program
    {
        static void Main(string[] args)
        {
                  string Sentence1 = "csharp is programming language";
                  string Reverse1 = ReverseWords(Sentence1);
                   PrintArray(Sentence1, Reverse1);
                   string Sentence2 = "Reverse the words in this sentence";
                    string Reverse2=  ReverseWords(Sentence2);
                    PrintArray(Sentence2, Reverse2);


            
        }
        public static void PrintArray(string Sentence, string Reverse)
        {
           

            Console.Write("Input ==> " );
            Console.WriteLine(Sentence);


            Console.Write("Output ==> ");
            

            Console.WriteLine(Reverse);


            Console.WriteLine("==============================");
            
        }

        public static string ReverseWords(string words)
        {
            string[] SpllitSentence = words.Split(' ');
            List<string> ReverseString = new List<string> { } ;
            for (int i = 1; i <= SpllitSentence.Length ; i++)
            {
             ReverseString.Add(SpllitSentence[SpllitSentence.Length-i]);
            }
            return string.Join(" ", ReverseString) ;
         }
    }
}

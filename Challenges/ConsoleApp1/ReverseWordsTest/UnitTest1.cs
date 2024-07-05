

using ReverseWords;

namespace ReverseWordsTest
{
    public class UnitTest1
    {
        [Fact]
        public void ReversalWordTest()
        {
            //Act 
            string Sentence1 = "language programming is csharp";
            string Sentence2 = "sentence this in words the Reverse";
            string Sentence3 = "structures data and challenges";

            //Arrange
            string ReverealWord1  = Program.ReverseWords("csharp is programming language");
            string ReverealWord2  = Program.ReverseWords("Reverse the words in this sentence");
            string ReverealWord3  = Program.ReverseWords("challenges and data structures");

            //Assert
            Assert.Equal(Sentence1, ReverealWord1);
            Assert.Equal(Sentence2, ReverealWord2);
            Assert.Equal(Sentence3, ReverealWord3);
        }
    }
}
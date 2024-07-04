

using ReverseWords;

namespace ReverseWordsTest
{
    public class UnitTest1
    {
        [Fact]
        public void ReversalWordTest()
        {
            //Act 
            string Sentence = "sentence this in words the Reverse";

            //Arrange
            string ReverealWord  = Program.ReverseWords("Reverse the words in this sentence");

            //Assert
            Assert.Equal(Sentence, ReverealWord);
        }
    }
}
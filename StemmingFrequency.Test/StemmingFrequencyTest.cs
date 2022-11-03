using Microsoft.VisualStudio.TestTools.UnitTesting;
using StemLibrary;

namespace StemmingFrequency.Test
{
    [TestClass]
    public class StemmingFrequencyTest
    {
        const string paragraph = "Friends are friendlier friendlies that are friendly and classify the friendly classification class. Flowery flowers flow through following the flower flows.";
        string[] paragraphWordList = paragraph.Split(" ");

        [TestMethod]
        public void ValidInput()
        {
            //Arrange
            string inputText = "classification";

            int expectedResult = 3;

            //Act
            int output = StemmingFrequencyMain.GetStemFrequency(inputText, paragraphWordList);

            //Assert
            Assert.AreEqual(expectedResult, output);
        }

        [TestMethod]
        public void InputTextEmpty()
        {
            //Arrange
            string inputText = "";

            int expectedResult = 0;

            //Act
            int output = StemmingFrequencyMain.GetStemFrequency(inputText, paragraphWordList);

            //Assert
            Assert.AreEqual(expectedResult, output);
        }

        [TestMethod]
        public void InputTextNotPartOfTheParagraph()
        {
            //Arrange
            string inputText = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            int expectedResult = 0;

            //Act
            int output = StemmingFrequencyMain.GetStemFrequency(inputText, paragraphWordList);

            //Assert
            Assert.AreEqual(expectedResult, output);
        }

        [TestMethod]
        public void ValidInputTextUpperCase()
        {
            //Arrange
            string inputText = "FLOW";

            int expectedResult = 2;

            //Act
            int output = StemmingFrequencyMain.GetStemFrequency(inputText, paragraphWordList);

            //Assert
            Assert.AreEqual(expectedResult, output);
        }
    }
}

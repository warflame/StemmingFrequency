using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StemmingFrequency.Test
{
    [TestClass]
    public class StemmingFrequencyTest
    {
        [TestMethod]
        public void ValidInput()
        {
            //Arrange
            Helper helper = new Helper();
            string[] paragraphWordList = helper.GetParagraphWordList();
            string inputText = "classification";

            int expectedResult = 3;

            //Act
            int output = StemmingFrequencyMain.GetWordFrequency(inputText, paragraphWordList);

            //Assert
            Assert.AreEqual(expectedResult, output);
        }

        [TestMethod]
        public void InputTextEmpty()
        {
            //Arrange
            Helper helper = new Helper();
            string[] paragraphWordList = helper.GetParagraphWordList();
            string inputText = "";

            int expectedResult = 0;

            //Act
            int output = StemmingFrequencyMain.GetWordFrequency(inputText, paragraphWordList);

            //Assert
            Assert.AreEqual(expectedResult, output);
        }

        [TestMethod]
        public void InputTextNotPartOfTheParagraph()
        {
            //Arrange
            Helper helper = new Helper();
            string[] paragraphWordList = helper.GetParagraphWordList();
            string inputText = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            int expectedResult = 0;

            //Act
            int output = StemmingFrequencyMain.GetWordFrequency(inputText, paragraphWordList);

            //Assert
            Assert.AreEqual(expectedResult, output);
        }

        [TestMethod]
        public void ValidInputTextUpperCase()
        {
            //Arrange
            Helper helper = new Helper();
            string[] paragraphWordList = helper.GetParagraphWordList();
            string inputText = "FLOW";

            int expectedResult = 2;

            //Act
            int output = StemmingFrequencyMain.GetWordFrequency(inputText, paragraphWordList);

            //Assert
            Assert.AreEqual(expectedResult, output);
        }
    }
}

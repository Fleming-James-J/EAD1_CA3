using EAD1_CA_3_X00149830;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EAD1_CA_3_X00149830_Test
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestExtractDogType()
        {
            //Arrange
            Root testData = new Root();
            string dogImageUrl = "https://images.dog.ceo/breeds/setter-irish/n02100877_5883.jpg";
            string actual;
            string expected = "setter-irish";

            //Act
            actual = testData.ExtractDogType(dogImageUrl);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestFormatDogType()
        {
            //Arrange
            Root testData = new Root();
            string dogType = "setter-irish";
            string actual;
            string expected = "Irish Setter";
            //Act
            actual = testData.FormatDogType(dogType);
            //Assert
            Assert.AreEqual(expected, actual);

        }


    }
}


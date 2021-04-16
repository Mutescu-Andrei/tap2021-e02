using NUnit.Framework;

namespace TestMethod
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {/Arrange
            string DNA = "AGTTPAGT";
            
            //Act
            try
                { bool isValidDnaSequence=DnaExtension.isValidDnaSequence(DNA);
                }
                catch (ExpectedExceptionAttribute) {
                    exceptionThrown = true;
                }
           

            //Assert
              Assert.IsTrue(exceptionThrown);
        }
    }
}
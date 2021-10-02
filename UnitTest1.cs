using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;


namespace MoodAnalyser
{
    [TestClass]
    public class MoodAnalyser
    {
        [TestMethod]
        public void GivenhappyShouldbereturnHappy()
        {

            //AAA metodology
            //Arrange
            string Expected = "happy";
            MoodAnalysertest obj = new MoodAnalysertest("Happy");

            //Act
            string actuall = obj.AnalyseMood();

            //Assert
            Assert.AreEqual(Expected, actuall);
        }
        [TestMethod]
        public void GivensadShouldbereturnsad()
        {

            //AAA metodology
            //Arrange
            string Expected = "sad";
            MoodAnalysertest obj = new MoodAnalysertest("sad");

            //Act
            string actuall = obj.AnalyseMood();

            //Assert
            Assert.AreEqual(Expected, actuall);
        }
        [TestMethod]
        [TestCategory("negativesenario")]
        public void GivenNullshouldbereturnhappy()
        {
            //AAA Methodology
            //Arrange
            string Expected = "happy";
            MoodAnalysertest obj = new MoodAnalysertest(null);

            //Act
            string actuall = obj.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, actuall);

        }
        [TestMethod]
        [TestCategory("customException")]
        public void GivenNullMoodshouldthrowcustomnemptyException()
        {
            //AAA metodology
            //Arrange
            string Excepted = "message should not be empty";
            MoodAnalysertest obj = new MoodAnalysertest(string.Empty);
            try
            {
                //Act
                string actuall = obj.AnalyseMood();
            }
            catch(CustomMoodAnalyserException Ex)
            {
                //Assert
                Assert.AreEqual(Excepted, Ex);
            }
        }
        [TestMethod]
        [TestCategory("customException")]
        public void GivenNullMoodshouldthrowcustomnullException()
        {
            //AAA metodology
            //Arrange
            string Excepted = "message should not be null";
            MoodAnalysertest obj = new MoodAnalysertest(null);
            try
            {
                //Act
                string actuall = obj.AnalyseMood();
            }
            catch (CustomMoodAnalyserException Ex)
            {
                //Assert
                Assert.AreEqual(Excepted, Ex);
            }
        }
    }
}

using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_AnalyzerProblems;

namespace MoodAnalyserTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]

        public void GivenSadMessage_WhenAnalyzer_ShouldReturnSadMood()
        {
            //Arrange
            string message = "I am in Sad Mood";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.AnalyserMood();
            //Assert
            Assert.AreEqual(actual, "Sad");
        }
        [TestMethod]
        public void GivenAnyMessage_WhenAnalyzer_ShouldReturnHappyMood()
        {
            //Arrange
            string message = "I am in Any Mood";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.AnalyserMood();
            //Assert
            Assert.AreEqual(actual, "Happy");
        }
        [TestMethod]
        public void GivenNullMood_WhenAnalyzer_ShouldReturnHappyMood()
        {
            //Arrange
            string message=null;
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.AnalyserMood();
            //Assert
            Assert.AreEqual(actual, "Happy");
        }
    }
}

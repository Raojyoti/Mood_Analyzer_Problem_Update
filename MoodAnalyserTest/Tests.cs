using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_AnalyzerProblems;

namespace MoodAnalyserTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void GivenMessage_WhenAnalyzer_ShouldReturnSadMood()
        {
            //Arrange
            string message = "I am in Sad Mood";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer();
            string actual = analyser.AnalyserMood(message);
            //Assert
            Assert.AreEqual(actual, "Sad");
        }
        [TestMethod]
        public void GivenAnyMessage_WhenAnalyzer_ShouldReturnHappyMood()
        {
            //Arrange
            string message = "I am in Any Mood";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer();
            string actual = analyser.AnalyserMood(message);
            //Assert
            Assert.AreEqual(actual, "Happy");
        }
    }
}

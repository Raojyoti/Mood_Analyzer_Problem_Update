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
            string message = "Iam in Sad Mood";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer();
            string actual = analyser.AnalyserMood(message);
            //Assert
            Assert.AreEqual(actual, "Sad");
        }
    }
}
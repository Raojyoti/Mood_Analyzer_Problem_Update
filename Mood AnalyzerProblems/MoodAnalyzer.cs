using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_AnalyzerProblems
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyserMood()
        {
            if (message.ToLower().Contains("sad"))
                return "Sad";
            return "Happy";
        }
    }
}

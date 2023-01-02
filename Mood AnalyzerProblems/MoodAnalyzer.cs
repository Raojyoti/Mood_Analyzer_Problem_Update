using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_AnalyzerProblems
{
    public class MoodAnalyzer
    {
        public string AnalyserMood(string message)
        {
            if (message.ToLower().Contains("sad"))
                return "Sad";
            return "Happy";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    /// <summary>
    ///uc1 Analzing user mood based on happy or sad word.
    /// </summary>
    public class MoodAnalysertest
    {
        //Iam in Happy mood
        public string message;
        public MoodAnalysertest(string message)
        {

            this.message = message;
        }

        //create Analyse method for analyser mood of the user
        public string AnalyseMood()
        {

            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }

        }
        
    }
}

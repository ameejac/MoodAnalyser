using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    /// <summary>
    ///uc2  handle exception if user mood invalid.
    /// </summary>
    public class MoodAnalysertest
    {
        //invalid mood 
        public string message;
        public MoodAnalysertest(string message)
        {

            this.message = message;
        }

     
        //create Analyse method for analyser mood of the user
        public string AnalyseMood()
        {
            try
            {
              /* if (message == string.Empty)
                 {
                      message = null;
                      Console.WriteLine(message);
                 } */
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (Exception ex)
            {
                return "happy";
            }
        }
        
    }
}

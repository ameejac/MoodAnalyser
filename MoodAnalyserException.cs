using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MoodAnalyser
{
    public class CustomMoodAnalyserException:Exception
    {
        public ExceptionType Exception;
        public enum ExceptionType
        {
            Null_Type_Exception,
            Empty_Type_Exception
        }
        public CustomMoodAnalyserException(ExceptionType type,string message): base(message)
        {
            this.Exception = type;
        }
    }
}

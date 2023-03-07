using System.Runtime.CompilerServices;

namespace LSM.Stopwatch.BL
{
    public class StartStop
    {
        //fields
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public TimeSpan ElapsedTime
        {
            get
            {
                return EndTime - StartTime;
            }

        }
    }
        


    public class StartException : Exception
    {
        public StartException() : base("Stopwatch is already running.") { }
    }

    public class StopException : Exception
    {
        public StopException() : base("Stopwatch has not been started.") { }
    }

   
   
}
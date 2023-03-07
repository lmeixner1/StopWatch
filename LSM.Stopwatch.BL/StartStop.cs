using System.Runtime.CompilerServices;

namespace LSM.Stopwatch.BL
{
    public class StartStop
    {
        //fields
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }

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
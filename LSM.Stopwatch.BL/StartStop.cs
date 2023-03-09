using System.Runtime.CompilerServices;

namespace LSM.Stopwatch.BL
{
    //<summary>
    // This is class StartStop is used to hold the variables of startTime,
    // ..endTime and elapsedTime and to set
    // ..our custom exceptions if the user starts the timer while it's already running
    // ..and attempts to stop it if has already stopped
    //<summary>
    public class StartStop
    {
        //fields
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string elapsedTime 
        { 
            get 
            { 
                TimeSpan ts = DateTime.Now - startTime;
                return ts.ToString(@"hh\:mm\:ss");
            } 
        }

    }

    // Exceptions
    public class StartException : Exception
    {
        public StartException() : base("Stopwatch is already running.") { }
    }

    public class StopException : Exception
    {
        public StopException() : base("Stopwatch has not been started.") { }
    }

}
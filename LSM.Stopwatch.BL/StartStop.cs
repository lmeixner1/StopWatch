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
        public bool timeStarted = false;
        public bool timeStopped = true;
        //fields
        public DateTime startTime { get; set; }
        public DateTime stopTime { get; set; }
        public string elapsedTime 
        { 
            get 
            {
                // For future devs I am using negative logic to avoid the delay issue I was having
                TimeSpan ts;
                if (!timeStarted)
                {
                    ts = stopTime - startTime;
                }
                else
                {
                    ts = DateTime.Now - startTime;     
                }
                return ts.ToString(@"hh\:mm\:ss");
            } 
        }
        public void StartClock()
        {
            if (!timeStopped)
            {
                throw new StartException();
            }
            else
            {
                startTime = DateTime.Now;
                timeStarted = true;
                timeStopped = false;
            }
          
        }

        public void StopClock()
        {
         
            if (!timeStarted)
             {
                throw new StopException();
             }
            else
            {
                stopTime = DateTime.Now;
                timeStopped = true;
                timeStarted = false;
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

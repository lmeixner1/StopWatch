using LSM.Stopwatch.BL;

namespace LSM.Stopwatch
{
    //<summary>
    // This is my Stopwatch application that begins when the user invokes the StartClock method
    // ..and ends when the user invokes the StopClock method.
    //<summary>

    public partial class StopWatch : Form
    {
        public bool timeStarted = false;
        public bool timeStopped = true;

        StartStop userStopwatch = new StartStop();

      
        
        

        public StopWatch()
        {
            InitializeComponent();
            
        }
       
        // Within the StartClock method the user clicks the start button invoking the method
        // ..and the method checks if the boolean timeStopped is false, if so the program starts the
        // ..timer and makes the timeStarted boolean true and sets the boolean timeStopped to false.
        private void StartClock (object sender, EventArgs e) 
        {
            
            try
            {
                if (!timeStopped)
                {
                    throw new StartException();
                } else
                {
                    userStopwatch.startTime = DateTime.Now;
                    timeStarted = true;
                    timeStopped= false;
                    tmrTime.Enabled = true;
                    
                }
            }
            catch (StartException ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        // Within the StopClock method the user clicks the stop button invoking the method
        // ..and the method checks if the boolean timeStarted is false, if so the program stops the
        // ..timer and makes the timeStarted boolean false and sets the boolean timeStopped to true
        // .. it then displays the elapsed time in the label lblElapsedTime.
        private void StopClock (object sender, EventArgs e)
        {
            try
            {
                if (!timeStarted)
                {
                    throw new StopException();
                }
                else
                {
                    userStopwatch.endTime = DateTime.Now;
                    timeStopped = true;
                    timeStarted = false;
                    lblElapsedTime.Text = userStopwatch.elapsedTime;
                    tmrTime.Enabled = false;
                    //userStopwatch.startTime= DateTime.Now;
                }
            }
            catch (StopException ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
        //Timer for display
        private void tmrTime_Tick(object sender, EventArgs e)
        {
      
            lblElapsedTime.Text = userStopwatch.elapsedTime;
        }

       
    }
}
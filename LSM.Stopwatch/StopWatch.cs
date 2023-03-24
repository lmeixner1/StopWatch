using LSM.Stopwatch.BL;

namespace LSM.Stopwatch
{
    //<summary>
    // This is my Stopwatch application that begins when the user invokes the StartClock method
    // ..and ends when the user invokes the StopClock method.
    //<summary>

    public partial class StopWatch : Form
    {
        StartStop userStopwatch = new StartStop();

      
        
        

        public StopWatch()
        {
            InitializeComponent();
            
        }
       
        // Within the StartClock method the user clicks the start button invoking the method
        // ..and the method checks if the boolean timeStopped is false, if so the program starts the
        // ..timer and makes the timeStarted boolean true and sets the boolean timeStopped to false.
        private void btnStart (object sender, EventArgs e)
        {
            try
            {
                userStopwatch.StartClock();
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
        private void btnStop (object sender, EventArgs e)
        {
            try 
            { 
                userStopwatch.StopClock();
            }
            catch(StopException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            //lblElapsedTime.Text = userStopwatch.elapsedTime;
          
          
        }
        
        //Timer for display
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblElapsedTime.Text = userStopwatch.elapsedTime;
            //if (userStopwatch.timeStarted)
            //{
            //    lblElapsedTime.Text = userStopwatch.elapsedTime;
            //}
            //else
            //{
            //    //lblElapsedTime.Text = "--:--:--";
            //}
        }

       
    }
}
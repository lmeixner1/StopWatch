using LSM.Stopwatch.BL;

namespace LSM.Stopwatch
{

    
    public partial class StopWatch : Form
    {
        public bool timeStarted = false;
        public bool timeStopped = true;
        StartStop userStopwatch = new StartStop();
        public DateTime startTime = DateTime.MinValue;
        

        public StopWatch()
        {
            InitializeComponent();

            userStopwatch.startTime= DateTime.Now;
        }
       
        private void start_Click (object sender, EventArgs e) 
        {
            try
            {
                if (!timeStopped)
                {
                    throw new StartException();
                } else
                {
                    timeStarted = true;
                    timeStopped= false;
                    //tmrTime.Enabled = true;
                }
            }
            catch (StartException ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void stop_Click (object sender, EventArgs e)
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
                    TimeSpan elapsed = userStopwatch.endTime - userStopwatch.startTime;
                    lblElapsedTime.Text = elapsed.ToString("hh\\:mm\\:ss");
                    //tmrTime.Enabled = false;
                    startTime= DateTime.Now;
                }
            }
            catch (StopException ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }       
    }
}
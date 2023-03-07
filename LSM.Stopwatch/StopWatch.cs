using LSM.Stopwatch.BL;

namespace LSM.Stopwatch
{

    
    public partial class StopWatch : Form
    {
        StartStop userStopwatch = new StartStop();
        public bool timeStarted = false;
        public bool timeStopped = true;
        
        
        
        

        public StopWatch()
        {
            InitializeComponent();

           userStopwatch.StartTime= DateTime.MinValue;
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
                    tmrTime.Enabled = true;
                    
                    
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
                    userStopwatch.EndTime = DateTime.Now;
                    timeStopped = true;
                    timeStarted = false;                
                    txtElapsedTime.Text = userStopwatch.ElapsedTime.ToString("hh\\:mm\\:ss");
                    userStopwatch.StartTime= DateTime.Now;
                    tmrTime.Enabled = false;
                }
            }
            catch (StopException ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            if (tmrTime.Enabled)
            {
                txtElapsedTime.Text = userStopwatch.ElapsedTime.ToString("hh\\:mm\\:ss");
            }
           
        }
    }
}
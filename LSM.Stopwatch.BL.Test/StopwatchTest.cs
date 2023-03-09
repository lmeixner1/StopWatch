namespace LSM.Stopwatch.BL.Test;

    [TestClass]
public class StopwatchTest
    {
    /// <summary>
    /// This code tests our StartClock and StopClock Method by testing 
    /// if our Stopwatch time is greater than or equal to our expectedElapsed time
    /// </summary>
        [TestMethod]
    public void TestStartStop()
        {

        StartStop userStopWatch = new StartStop();
        double expectedElapsed = 5000.0;
        userStopWatch.startTime= DateTime.Now;
        Thread.Sleep((int)expectedElapsed);     
        userStopWatch.endTime= DateTime.Now;

        double elapsedTime; 
        if (double.TryParse(userStopWatch.elapsedTime, out elapsedTime))
        {
            Assert.IsTrue(elapsedTime >= expectedElapsed, "Time can't be less than expected time");
        }
      
    }

}
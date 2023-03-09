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
            Stopwatch user = new Stopwatch();

        StartStop userStopWatch = new StartStop();
        double expectedElapsed = 5000.0;
        userStopWatch.startTime= DateTime.Now;
        Thread.Sleep((int)expectedElapsed);
            
        userStopWatch.endTime= DateTime.Now;
        Assert.IsTrue(userStopWatch.elapsedTime.TotalMilliseconds >= expectedElapsed, "Time can't be less than expected time");
    }
}
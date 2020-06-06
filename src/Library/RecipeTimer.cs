namespace Full_GRASP_And_SOLID
{
    public class RecipeTimer : TimerClient
    {
        private CountdownTimer countdownTimer = new CountdownTimer();
        public void TimeOut()
        {
        }

        public void GetTimeOut(int time)
        {
            this.countdownTimer.Register(time, this);
        }

    }
}
namespace OzowDevAssessment
{
    public class MainFormModel
    {
        private int maxSpeed = 1200;
        public int GridWidth { get; set; } = 3;
        public int GridHeight { get; set; } = 3;
        public int SpeedSelection { get; set; }
        public bool EvaluatationInProgress { get; set; }
        public bool GridHasBeenInitialized { get; set; }
        public bool CanModifyValues => EvaluatationInProgress ? false : true;
        public string OutputText { get; set; }
        public int GenerationCount { get; set; } = 0;
        public int ThreadSleep
        {
            get
            {
                if (SpeedSelection > maxSpeed)
                    return 0;

                return maxSpeed - SpeedSelection;
            }
        }
    }
}

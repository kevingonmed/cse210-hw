namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int timesCompleted;
        private int requiredTimes;

        public ChecklistGoal(string name, int points, int requiredTimes) : base(name, points)
        {
            this.requiredTimes = requiredTimes;
            timesCompleted = 0;
        }

        public override void RecordEvent()
        {
            if (timesCompleted < requiredTimes)
            {
                timesCompleted++;
                Points += 50; // Points for each event
                if (timesCompleted == requiredTimes)
                {
                    Points += 500; // Bonus points
                }
            }
        }

        public override string GetStatus()
        {
            return $"{timesCompleted}/{requiredTimes} completed";
        }

        public override string GetInfo()
        {
            return $"{Name} - {GetStatus()} - {Points} points (Checklist)";
        }
    }
}

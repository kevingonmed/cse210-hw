using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name, points) { }

        public override void RecordEvent()
        {
            completionCount++;
            UpdateStreak();
        }

        private void UpdateStreak()
        {
            if (lastCompletionDate.Date == DateTime.Today.AddDays(-1).Date)
            {
                streak++;
            }
            else if (lastCompletionDate.Date < DateTime.Today)
            {
                streak = 1;
            }
            lastCompletionDate = DateTime.Today;
        }

        public override string GetInfo()
        {
            return $"{Name} (Eternal Goal) - Completed: {completionCount} times - Streak: {GetStreak()} - {GetPoints()} points";
        }
    }
}

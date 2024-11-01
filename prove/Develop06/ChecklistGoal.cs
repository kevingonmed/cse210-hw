using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        public int RequiredTimes { get; private set; }

        public ChecklistGoal(string name, int points, int requiredTimes) : base(name, points)
        {
            RequiredTimes = requiredTimes;
        }

        public override void RecordEvent()
        {
            if (completionCount < RequiredTimes)
            {
                completionCount++;
                UpdateStreak();
            }
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
            return $"{Name} (Checklist Goal) - Completed: {completionCount}/{RequiredTimes} - Streak: {GetStreak()} - {GetPoints()} points";
        }
    }
}

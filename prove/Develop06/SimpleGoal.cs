using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool IsCompleted;

        public SimpleGoal(string name, int points) : base(name, points)
        {
            IsCompleted = false;
        }

        public override void RecordEvent()
        {
            IsCompleted = true;
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
            return $"{Name} - {(IsCompleted ? "[X]" : "[ ]")} - Streak: {GetStreak()} - {GetPoints()} points";
        }
    }
}

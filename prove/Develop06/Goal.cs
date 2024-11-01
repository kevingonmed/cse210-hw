using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        public string Name { get; private set; }
        protected int Points;
        protected int completionCount;
        protected int streak;
        protected DateTime lastCompletionDate;

        public Goal(string name, int points)
        {
            Name = name;
            Points = points;
            completionCount = 0;
            streak = 0;
            lastCompletionDate = DateTime.MinValue;
        }

        public abstract void RecordEvent();
        public abstract string GetInfo();

        public int GetPoints()
        {
            return Points * completionCount;
        }

        public int GetStreak()
        {
            return streak;
        }
    }
}
using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        protected string Name;
        protected int Points;
        protected bool IsCompleted;

        public Goal(string name, int points)
        {
            Name = name;
            Points = points;
            IsCompleted = false;
        }

        public abstract void RecordEvent();
        public abstract string GetStatus();
        public abstract string GetInfo();

        public int GetPoints()
        {
            return Points;
        }
    }
}

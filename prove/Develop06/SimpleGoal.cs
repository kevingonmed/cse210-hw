namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int points) : base(name, points) { }

        public override void RecordEvent()
        {
            IsCompleted = true;
        }

        public override string GetStatus()
        {
            return IsCompleted ? "[X]" : "[ ]";
        }

        public override string GetInfo()
        {
            return $"{Name} - {GetStatus()} - {Points} points";
        }
    }
}

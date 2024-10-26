namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name, points) { }

        public override void RecordEvent()
        {
            Points += 100; // Increment points each time
        }

        public override string GetStatus()
        {
            return "[ ]"; // Always incomplete
        }

        public override string GetInfo()
        {
            return $"{Name} - {GetStatus()} - {Points} points (Eternal)";
        }
    }
}

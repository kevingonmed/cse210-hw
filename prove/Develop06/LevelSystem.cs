using System;

namespace EternalQuest
{
    public class LevelSystem
    {
        private int totalPoints;
        private int level;

        public LevelSystem()
        {
            totalPoints = 0;
            level = 1;
        }

        public void AddPoints(int points)
        {
            totalPoints += points;
            level = totalPoints / 1000;
        }

        public int GetLevel() => level;
    }
}

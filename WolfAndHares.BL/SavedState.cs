namespace WolfAndHares.BL
{
    using System.Collections.Generic;

    public class SavedState
    {
        public SavedState()
        {
            SavedLevelStates = new List<SavedLevelState>();
        }

        public List<SavedLevelState> SavedLevelStates { get; set; }
    }

    public class SavedLevelState
    {
        public int LevelNumber { get; set; }
        public int Points { get; set; }
    }
}
namespace test_four
{
    using System.Collections.Generic;

    public interface IGameLogic
    {
        void NewGame();
        void StartLevel(int number);
        ILevelState GetLevelState();
        void GoLeft();
        void GoRight();
        void GoUp();
        void GoDown();
        void SaveGame();
        void LoadGame();
        List<ILevel> GetLevels();
    }
}

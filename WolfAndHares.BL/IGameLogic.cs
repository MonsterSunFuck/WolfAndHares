namespace WolfAndHares.BL
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
        List<ILevel> GetLevels();
        void Pause();
        void Play();
        void Restart();
        int GetCurrentLevelNumber();
        bool IsAllLevelsWin();
        int GetAllPoints();
        SavedState GetSavedState();
        void DeleteSave();
        bool LoadGame();
    }
}

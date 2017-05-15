namespace WolfAndHares.BL
{
    using System.Collections.Generic;

    public interface ILevelLoader
    {
        List<ILevel> LoadLevels();
        SavedState GetSavedSate();
        void SaveLevelState(SavedLevelState levelStateForSave);
        void DeleteSave();
    }
}

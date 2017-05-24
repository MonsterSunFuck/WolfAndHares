namespace WolfAndHares.BL
{
    using GameObjects;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FromFileLevelLoader
    {
        private const string SaveFilePath = "Saves/save";
        public List<Level> LoadLevels()
        {
            var levels = new List<Level>();

            var fileNames =
                new DirectoryInfo(@"Levels").GetFileSystemInfos("*.level")
                    .OrderBy(
                        f =>
                            int.Parse(f.Name.Substring(0,
                                f.Name.Length - f.Extension.Length)))
                    .Select(x => x.FullName).ToList();

            foreach (var path in fileNames)
            {
                var fileLines = File.ReadAllLines(path);
                var level = new Level(5, 5);
                for (var i = 0; i < fileLines.Length; i++)
                {
                    var fileLine = fileLines[i];
                    for (var j = 0; j < fileLine.Length; j++)
                    {
                        level.GameObjects[i, j] = ConverCharToGameObject(fileLine[j]);
                    }
                }

                level.AllCarrotsCount = level.GameObjects.Cast<GameObject>().Count(x => x is Carrot);
                level.AllRabbitsCount = level.GameObjects.Cast<GameObject>().Count(x => x is Hare);
                level.InitialState = (Level)level.Clone();
                levels.Add(level);
            }

            return levels;
        }

        public SavedState GetSavedSate()
        {
            if (!File.Exists(SaveFilePath))
                return new SavedState();

            var json = File.ReadAllText(SaveFilePath);
            return JsonConvert.DeserializeObject<SavedState>(json) ?? new SavedState();
        }

        public void SaveLevelState(SavedLevelState levelStateForSave)
        {
            var state = GetSavedSate();
            var savedLevelState = state.SavedLevelStates.FirstOrDefault(x => x.LevelNumber == levelStateForSave.LevelNumber);
            if (savedLevelState != null)
            {
                savedLevelState.Points = levelStateForSave.Points;
            }
            else
            {
                state.SavedLevelStates.Add(levelStateForSave);
            }

            var json = JsonConvert.SerializeObject(state);
            File.WriteAllText(SaveFilePath, json);
        }

        public void DeleteSave()
        {
            if (File.Exists(SaveFilePath))
                File.Delete(SaveFilePath);
        }

        private static GameObject ConverCharToGameObject(char @char)
        {
            switch (@char)
            {
                case 'g':
                    return new Glade();
                case 'r':
                    return new Hare();
                case 'w':
                    return new Wolf();
                case 'c':
                    return new Carrot();
                case 's':
                    return new Stump();
                case 't':
                    return new Trap();
                default:
                    return new Glade();
            }
        }
    }
}
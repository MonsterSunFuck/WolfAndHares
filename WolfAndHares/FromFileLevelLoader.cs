namespace test_four
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FromFileLevelLoader : ILevelLoader
    {
        public List<ILevel> LoadLevels()
        {
            var levels = new List<ILevel>();

            var fileNames = Directory.GetFiles("Levels");

            foreach (var path in fileNames)
            {
                var fileLines = File.ReadLines(path).ToList();
                var level = new Level(fileLines.Count);
                for (var i = 0; i < fileLines.Count; i++)
                {
                    var fileLine = fileLines[i];
                    for (var j = 0; j < fileLine.Length; j++)
                    {
                        level.GameObjects[i, j] = ConverCharToGameObject(fileLine[j]);
                    }
                }

                level.AllCarrotsCount = level.GameObjects.Cast<IGameObject>().Count(x => x is Carrot);
                level.AllRabbitsCount = level.GameObjects.Cast<IGameObject>().Count(x => x is Rabbit);
                levels.Add(level);
            }

            return levels;
        }

        private static IGameObject ConverCharToGameObject(char @char)
        {
            switch (@char)
            {
                case 'g':
                    return new Glade();
                case 'r':
                    return new Rabbit();
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
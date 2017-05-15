namespace WolfAndHares.BL
{
    using GameObjects;

    public class Level : ILevel
    {
        public Level(int height, int withd)
        {
            GameObjects = new GameObject[height, withd];
        }

        public ILevel InitialState { get; set; }
        public GameObject[,] GameObjects { get; set; }

        public int AllCarrotsCount { get; set; }
        public int AllRabbitsCount { get; set; }
        public void SetToInitialState()
        {
            GameObjects = new GameObject[GameObjects.GetLength(0), GameObjects.GetLength(1)];
            for (var i = 0; i < GameObjects.GetLength(0); i++)
            {
                for (var j = 0; j < GameObjects.GetLength(1); j++)
                {
                    GameObjects[i, j] = (GameObject)InitialState.GameObjects[i, j].Clone();
                }
            }
            AllCarrotsCount = InitialState.AllCarrotsCount;
            AllRabbitsCount = InitialState.AllRabbitsCount;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
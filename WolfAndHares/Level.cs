namespace test_four
{
    public class Level : ILevel
    {
        public Level(int count)
        {
            GameObjects = new IGameObject[count, count];
        }

        public IGameObject[,] GameObjects { get; }

        public int AllCarrotsCount { get; set; }
        public int AllRabbitsCount { get; set; }
    }
}
namespace test_four
{
    public interface ILevel
    {
        IGameObject[,] GameObjects { get; }

        int AllCarrotsCount { get; }
        int AllRabbitsCount { get; }
    }
}
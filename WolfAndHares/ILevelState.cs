namespace test_four
{
    public interface ILevelState
    {
        int Lives { get; set; }
        ILevel Level { get; set; }
        int AllCarrotsCount { get; set; }
        int AllRabbitsCount { get; set; }
        int Carrots { get; set; }
        int Rabbits { get; set; }
    }
}
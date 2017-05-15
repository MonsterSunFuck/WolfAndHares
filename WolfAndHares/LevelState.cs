namespace test_four
{
    public class LevelState : ILevelState
    {
        public int Lives { get; set; }
        public ILevel Level { get; set; }
        public int AllCarrotsCount { get; set; }
        public int AllRabbitsCount { get; set; }
        public int Carrots { get; set; }
        public int Rabbits { get; set; }
    }
}
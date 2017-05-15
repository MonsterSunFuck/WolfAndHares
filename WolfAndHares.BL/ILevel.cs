namespace WolfAndHares.BL
{
    using System;
    using GameObjects;

    public interface ILevel : ICloneable
    {
        ILevel InitialState { get; set; }
        GameObject[,] GameObjects { get; }

        int AllCarrotsCount { get; }
        int AllRabbitsCount { get; }
        void SetToInitialState();
    }
}
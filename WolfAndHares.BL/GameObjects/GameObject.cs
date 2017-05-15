namespace WolfAndHares.BL.GameObjects
{
    using System;
    using System.Drawing;

    public abstract class GameObject : ICloneable
    {
        public abstract Image Image { get; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
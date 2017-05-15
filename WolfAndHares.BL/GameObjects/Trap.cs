namespace WolfAndHares.BL.GameObjects
{
    using System.Drawing;

    public class Trap : GameObject
    {
        public Trap()
        {
            Image = new Bitmap("Content/field/trap.png");
        }

        public override Image Image { get; }
    }
}
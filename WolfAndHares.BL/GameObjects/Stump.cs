namespace WolfAndHares.BL.GameObjects
{
    using System.Drawing;

    public class Stump : GameObject
    {
        public Stump()
        {
            Image = new Bitmap("Content/field/stump.png");
        }

        public override Image Image { get; }
    }
}
namespace WolfAndHares.BL.GameObjects
{
    using System.Drawing;

    public class Hare : GameObject
    {
        public Hare()
        {
            Image = new Bitmap("Content/field/hare.png");
        }

        public override Image Image { get; }
    }
}
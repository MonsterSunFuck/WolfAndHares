namespace WolfAndHares.BL.GameObjects
{
    using System.Drawing;

    public class Wolf : GameObject
    {
        public Wolf()
        {
            Image = new Bitmap("Content/field/wolf.png");
        }

        public override Image Image { get; }
    }
}